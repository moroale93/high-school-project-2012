using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Emgu.CV.UI;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

using System.IO;
using System.Xml;
using System.Runtime.InteropServices;
using System.Threading;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace ControllerDispositivoRotazioneWebcam
{
    public partial class Form1 : Form
    {
        #region variables

        Capture grabber;
        //frame in ingresso
        Image<Bgr, Byte> currentFrame;
        Image<Gray, byte> gray_frame = null;
        Image<Gray, byte> result, TrainedFace = null;

        //imposto la figura dell'Haar Cascade
        public HaarCascade Face = new HaarCascade(Application.StartupPath + "/Cascades/haarcascade_frontalface_alt2.xml");

        //font per scrivere il nome del volto
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_COMPLEX, 0.5, 0.5);

        //imposta la directory per il deposito dei train per il confronto facciale
        CTrain Eigen_Recog = new CTrain();

        //posizione volto
        Point Location;
        string personaScelta = "";

        //vettore con tutti i volti nel frame
        CPosizione[] posPersona;

        bool stoRuotando = false;
        bool voltoPresente = false;


        int passiX = 0;
        int passiY = 0;

        #endregion

        public Form1()
        {
            InitializeComponent();
            bool collegato;
            do
            {
                try
                {
                    serialPort1.Open();
                    collegato = true;
                }
                catch
                {
                    collegato = false;
                    MessageBox.Show("collega il dispositivo MT");
                }
            } while (!collegato);
            riempioComboBox();
            label2.Text = barOffsetX.Value.ToString();
            label3.Text = barOffsetY.Value.ToString();
            initialise_capture(); 
        }

        public void riempioComboBox()
        {
            //controllo se sono stati impostati i Train altrimenti apro la form per impostarli
            if (!Eigen_Recog.IsTrained)
            {
                MessageBox.Show("Non sono state impostate le immagini di confronto.\r\nImpostarle dal menù Train.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                comboBox1.ResetText();
                comboBox1.Items.Clear();
                comboBox1.Items.Add("");
                XmlTextReader reader = new XmlTextReader(Application.StartupPath + "/FacceTrain/Train.xml");
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        if (reader.Name == "NAME")
                        {
                            reader.Read();
                            comboBox1.Items.Add(reader.Value);
                        }
                    }
                }
            }
        }

        //Open training form and pass this
        private void trainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Stop Camera
            stop_capture();
            //OpenForm
            MascheraTrain TrainForm = new MascheraTrain(this);
            TrainForm.Show();
        }

        public void retrain()
        {
            Eigen_Recog = new CTrain();
            comboBox1.Refresh();
        }

        //Camera Start Stop
        public void initialise_capture()
        {
            grabber = new Capture(3);
            grabber.QueryFrame();
            //imposto la posizione del volto, non ancora riconosciuto, al centro dell'inquadratura
            Location = new Point(grabber.Width / 2, grabber.Height / 2);
            //Initialize the FrameGraber event
            Application.Idle += new EventHandler(FrameGrabber);
            Application.Idle += new EventHandler(SpostaWebCam);
        }

        private void stop_capture()
        {
            Application.Idle -= new EventHandler(FrameGrabber);
            Application.Idle -= new EventHandler(SpostaWebCam);
            if (grabber != null)
            {
                grabber.Dispose();
            }
        }

        void SpostaWebCam(object sender, EventArgs e)
        {
            tbxTest1.Text = "";
            tbxTest2.Text = "";

            //offset spostamento
            int kx = barOffsetX.Value;
            int ky = barOffsetY.Value;

            //calcolo di quanto si stnno spostando dal centro dell'inquadratura la persona
            int spostamentoX = (Location.X - currentFrame.Width / 2);
            int spostamentoY = (Location.Y - currentFrame.Height / 2);

            //#####  test freccia
            pictureBox1.Refresh();
            Graphics g = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black, 8);
            pen.StartCap = LineCap.ArrowAnchor;
            pen.EndCap = LineCap.Flat;
            g.DrawLine(pen, pictureBox1.Width / 2, pictureBox1.Height / 2, pictureBox1.Width / 2 + spostamentoX * pictureBox1.Width / currentFrame.Width, pictureBox1.Height / 2 + spostamentoY * pictureBox1.Height / currentFrame.Height);
            g.DrawEllipse(new Pen(Color.Red, 5), new Rectangle(pictureBox1.Width / 2 -1, pictureBox1.Height / 2-1, 2, 2));
            //######

            if (Math.Abs(spostamentoX) > kx)
            {
                //controllo verso dove si sta spostando dal centro dell'inquadratura la persona
                if (spostamentoX > 0)
                {
                    //sposto a sinistra 
                    tbxTest1.Text = "sx=" + spostamentoX.ToString();
                    try
                    {
                        serialPort1.Write(new byte[] { 49 }, 0, 1);
                        passiX++;
                    }
                    catch
                    {
                        MessageBox.Show("dispositivo MT scollegato");
                    }
                }
                else
                {
                    //sposto a destra 
                    tbxTest1.Text = "dx=" + spostamentoX.ToString();
                    try
                    {
                        serialPort1.Write(new byte[] { 50 }, 0, 1);
                        passiX--;
                    }
                    catch
                    {
                        MessageBox.Show("dispositivo MT scollegato");
                    }
                }
            }

            if (Math.Abs(spostamentoY) > ky)
            {
                if (spostamentoY > 0)
                {
                    //sposto giu
                    tbxTest2.Text = "giu=" + spostamentoY.ToString();
                    try
                    {
                        serialPort1.Write(new byte[] { 51 }, 0, 1);
                        passiY++;
                    }
                    catch
                    {
                        MessageBox.Show("dispositivo MT scollegato");
                    }
                }
                else
                {
                    //sposto su
                    tbxTest2.Text = "su=" + spostamentoY.ToString();
                    try
                    {
                        serialPort1.Write(new byte[] { 52 }, 0, 1);
                        passiY--;
                    }
                    catch
                    {
                        MessageBox.Show("dispositivo MT scollegato");
                    }
                }
            }
            spostamentoX = 0;
            spostamentoY = 0;
        }

        //Process Frame
        void FrameGrabber(object sender, EventArgs e)
        {
            //istanzio il frame derivante dalla webcam e ne riduco la risoluzione
            currentFrame = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            
            if (currentFrame != null)
            {
                //creo un frame in scala di grigi per avere un'immagine più facile da lavorare
                gray_frame = currentFrame.Convert<Gray, Byte>();

                //rintraccio l'Haar Cascade all'interno dell'immagine ricevuta
                MCvAvgComp[][] facesDetected = gray_frame.DetectHaarCascade(Face, 1.2, 2, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));

                posPersona = new CPosizione[facesDetected[0].Length];
                int i = 0;

                foreach (MCvAvgComp face_found in facesDetected[0])
                {
                    //imposto i vari risultati da elaborare ritornati come ROI (region of interest) e li comverto in scala di grigi
                    result = currentFrame.Copy(face_found.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                    //equalizzo l'istogramma un metodo che migliora il contrasto di un'immagine, al fine di allungare l'intervallo di intensità (http://opencv.itseez.com/doc/tutorials/imgproc/histograms/histogram_equalization/histogram_equalization.html)
                    result._EqualizeHist();//added
                    //disegno nel frame originale il rettangolo per mostrare il riconoscimento di un volto
                    currentFrame.Draw(face_found.rect, new Bgr(Color.Lime), 1);
                    
                    if (Eigen_Recog.IsTrained) // se sono disponibili Train
                    {
                        //riconosco di chi è il volto e ne ritorno il nome
                        string name = Eigen_Recog.Recognise(result);
                        //disegno nel frame originale il nome del volto riconosciuto
                        currentFrame.Draw(name, ref font, new Point(face_found.rect.X, face_found.rect.Y), new Bgr(Color.Red));
                        currentFrame.Draw(new Rectangle(currentFrame.Width / 2 - barOffsetX.Value / 2 - face_found.rect.Width / 2, currentFrame.Height / 2 - barOffsetY.Value / 2 - face_found.rect.Height / 2, barOffsetX.Value + face_found.rect.Width, barOffsetY.Value + face_found.rect.Height), new Bgr(Color.Blue), 1);

                        //elimino la ricreca in rotazione
                        if (stoRuotando)
                            if (name == personaScelta)
                            {
                                Application.Idle -= new EventHandler(rotazioneWebCam);
                                labelRotaz.Text = "";
                                stoRuotando = false;
                            }

                        //riempio il vettore di tutte le persone presenti in questa istanza
                        posPersona[i] = new CPosizione(name, new Point(face_found.rect.Width / 2 + face_found.rect.X, face_found.rect.Height / 2 + face_found.rect.Y));
                        i++;
                    }
                }

                //elimino persone duplicate
                for (int p1 = 0; p1 < posPersona.Length && posPersona[p1] != null; p1++)
                {
                    for (int p2 = 0; p2 < posPersona.Length && p2 != p1 && posPersona[p2] != null; p2++)
                    {
                        if (posPersona[p1].Nome == posPersona[p2].Nome)
                        {
                            //se la distanza (calcolata con pitagora) del volto p1 è maggiore di quella di p2 (ipotizzo,data la velocità di calcolo,che si sia spostato di poco)
                            if (Math.Sqrt(Math.Pow(Math.Abs(posPersona[p1].Posizione.X - Location.X), 2) - Math.Pow(Math.Abs(posPersona[p1].Posizione.Y - Location.Y), 2)) <= Math.Sqrt(Math.Pow(Math.Abs(posPersona[p2].Posizione.X - Location.X), 2) - Math.Pow(Math.Abs(posPersona[p2].Posizione.Y - Location.Y), 2)))
                            {
                                posPersona[p2] = null;
                            }
                            else
                            {
                                posPersona[p1] = null;
                            }
                        }
                    }
                }

                voltoPresente = false;
                //aggiorno la posizione della persona scelta
                foreach (CPosizione p in posPersona)
                {
                    if (p != null)
                    {
                        if (p.Nome == personaScelta)
                        {
                            voltoPresente = true;
                            Location = new Point(p.Posizione.X, p.Posizione.Y);
                        }
                    }
                }

                if (!stoRuotando)
                    if (!voltoPresente && personaScelta != "")
                    {
                        //faccio girare la webcam (quando troverà il volto desiderato si fermerà)
                        Application.Idle += new EventHandler(rotazioneWebCam);
                    }

                //Show the faces procesed and recognized
                pbxCam.Image = currentFrame.ToBitmap();
            }
        }


        bool passiSu = true;
        bool passiDestra = true;

        void rotazioneWebCam(object sender, EventArgs e)
        {
            stoRuotando = true;
            //TODO: TEX rotazione continua
            labelRotaz.Text = "Ruoto alla ricerca\n\rdi '" + personaScelta + "'";

            try
            {
                //if (passiSu)
                //    serialPort1.Write(new byte[] { 51 }, 0, 1);
                //else
                //    serialPort1.Write(new byte[] { 52 }, 0, 1);

                //if (passiDestra)
                //    serialPort1.Write(new byte[] { 50 }, 0, 1);
                //else
                //    serialPort1.Write(new byte[] { 49 }, 0, 1);
            }
            catch
            {
                MessageBox.Show("dispositivo MT scollegato");
            }

            //configurazione metodo di ricerca
            if (passiY > 20)
                passiSu = !passiSu;
            else
                if (passiY < -20)
                    passiSu = !passiSu;

            if (passiX > 100)
                passiDestra = !passiDestra;
            else
                if (passiX < -100)
                    passiDestra = !passiDestra;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            personaScelta = ((ComboBox)sender).Items[((ComboBox)sender).SelectedIndex].ToString();
        }

        private void barOffsetX_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = barOffsetX.Value.ToString();
            label3.Text = barOffsetY.Value.ToString();
        }
    }
}
