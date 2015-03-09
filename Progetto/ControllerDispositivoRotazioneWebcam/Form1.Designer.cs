namespace ControllerDispositivoRotazioneWebcam
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbxCam = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelRotaz = new System.Windows.Forms.Label();
            this.barOffsetX = new System.Windows.Forms.TrackBar();
            this.barOffsetY = new System.Windows.Forms.TrackBar();
            this.tbxTest1 = new System.Windows.Forms.TextBox();
            this.tbxTest2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barOffsetX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barOffsetY)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxCam
            // 
            this.pbxCam.Location = new System.Drawing.Point(0, 24);
            this.pbxCam.Name = "pbxCam";
            this.pbxCam.Size = new System.Drawing.Size(320, 240);
            this.pbxCam.TabIndex = 0;
            this.pbxCam.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(371, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 108);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelRotaz
            // 
            this.labelRotaz.AutoSize = true;
            this.labelRotaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRotaz.Location = new System.Drawing.Point(335, 241);
            this.labelRotaz.Name = "labelRotaz";
            this.labelRotaz.Size = new System.Drawing.Size(0, 15);
            this.labelRotaz.TabIndex = 2;
            // 
            // barOffsetX
            // 
            this.barOffsetX.Location = new System.Drawing.Point(346, 173);
            this.barOffsetX.Maximum = 250;
            this.barOffsetX.Minimum = 1;
            this.barOffsetX.Name = "barOffsetX";
            this.barOffsetX.Size = new System.Drawing.Size(131, 45);
            this.barOffsetX.TabIndex = 4;
            this.barOffsetX.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.barOffsetX.Value = 250;
            this.barOffsetX.ValueChanged += new System.EventHandler(this.barOffsetX_ValueChanged);
            // 
            // barOffsetY
            // 
            this.barOffsetY.Location = new System.Drawing.Point(326, 47);
            this.barOffsetY.Maximum = 150;
            this.barOffsetY.Minimum = 1;
            this.barOffsetY.Name = "barOffsetY";
            this.barOffsetY.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.barOffsetY.Size = new System.Drawing.Size(45, 131);
            this.barOffsetY.TabIndex = 5;
            this.barOffsetY.Value = 150;
            this.barOffsetY.ValueChanged += new System.EventHandler(this.barOffsetX_ValueChanged);
            // 
            // tbxTest1
            // 
            this.tbxTest1.Location = new System.Drawing.Point(338, 210);
            this.tbxTest1.Name = "tbxTest1";
            this.tbxTest1.Size = new System.Drawing.Size(59, 20);
            this.tbxTest1.TabIndex = 6;
            // 
            // tbxTest2
            // 
            this.tbxTest2.Location = new System.Drawing.Point(410, 210);
            this.tbxTest2.Name = "tbxTest2";
            this.tbxTest2.Size = new System.Drawing.Size(59, 20);
            this.tbxTest2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Persona da seguire:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.trainToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(481, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // trainToolStripMenuItem
            // 
            this.trainToolStripMenuItem.Name = "trainToolStripMenuItem";
            this.trainToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.trainToolStripMenuItem.Text = "&Train";
            this.trainToolStripMenuItem.Click += new System.EventHandler(this.trainToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(338, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(131, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 13;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 283);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxTest2);
            this.Controls.Add(this.tbxTest1);
            this.Controls.Add(this.barOffsetY);
            this.Controls.Add(this.barOffsetX);
            this.Controls.Add(this.labelRotaz);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbxCam);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barOffsetX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barOffsetY)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxCam;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelRotaz;
        private System.Windows.Forms.TrackBar barOffsetX;
        private System.Windows.Forms.TrackBar barOffsetY;
        private System.Windows.Forms.TextBox tbxTest1;
        private System.Windows.Forms.TextBox tbxTest2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

