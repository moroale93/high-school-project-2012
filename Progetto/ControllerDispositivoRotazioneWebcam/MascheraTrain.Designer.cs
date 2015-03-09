namespace ControllerDispositivoRotazioneWebcam
{
    partial class MascheraTrain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MascheraTrain));
            this.Delete_Data_BTN = new System.Windows.Forms.Button();
            this.NAME_PERSON = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ADD_BTN = new System.Windows.Forms.Button();
            this.face_PICBX = new System.Windows.Forms.PictureBox();
            this.image_PICBX = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.face_PICBX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_PICBX)).BeginInit();
            this.SuspendLayout();
            // 
            // Delete_Data_BTN
            // 
            this.Delete_Data_BTN.Location = new System.Drawing.Point(326, 217);
            this.Delete_Data_BTN.Name = "Delete_Data_BTN";
            this.Delete_Data_BTN.Size = new System.Drawing.Size(120, 23);
            this.Delete_Data_BTN.TabIndex = 23;
            this.Delete_Data_BTN.Text = "Cancella tutti i dati";
            this.Delete_Data_BTN.UseVisualStyleBackColor = true;
            this.Delete_Data_BTN.Click += new System.EventHandler(this.Single_btn_Click);
            // 
            // NAME_PERSON
            // 
            this.NAME_PERSON.Location = new System.Drawing.Point(362, 135);
            this.NAME_PERSON.Name = "NAME_PERSON";
            this.NAME_PERSON.Size = new System.Drawing.Size(84, 20);
            this.NAME_PERSON.TabIndex = 21;
            this.NAME_PERSON.Text = "inserisci nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "NAME:";
            // 
            // ADD_BTN
            // 
            this.ADD_BTN.Location = new System.Drawing.Point(326, 176);
            this.ADD_BTN.Name = "ADD_BTN";
            this.ADD_BTN.Size = new System.Drawing.Size(120, 23);
            this.ADD_BTN.TabIndex = 17;
            this.ADD_BTN.Text = "Aggiungi Train";
            this.ADD_BTN.UseVisualStyleBackColor = true;
            this.ADD_BTN.Click += new System.EventHandler(this.ADD_BTN_Click);
            // 
            // face_PICBX
            // 
            this.face_PICBX.Location = new System.Drawing.Point(326, 0);
            this.face_PICBX.Name = "face_PICBX";
            this.face_PICBX.Size = new System.Drawing.Size(120, 120);
            this.face_PICBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.face_PICBX.TabIndex = 16;
            this.face_PICBX.TabStop = false;
            // 
            // image_PICBX
            // 
            this.image_PICBX.Location = new System.Drawing.Point(0, 0);
            this.image_PICBX.Name = "image_PICBX";
            this.image_PICBX.Size = new System.Drawing.Size(320, 240);
            this.image_PICBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image_PICBX.TabIndex = 15;
            this.image_PICBX.TabStop = false;
            // 
            // MascheraTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 240);
            this.Controls.Add(this.Delete_Data_BTN);
            this.Controls.Add(this.NAME_PERSON);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ADD_BTN);
            this.Controls.Add(this.face_PICBX);
            this.Controls.Add(this.image_PICBX);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MascheraTrain";
            this.Text = "MascheraTrain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Training_Form_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.face_PICBX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_PICBX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Delete_Data_BTN;
        private System.Windows.Forms.TextBox NAME_PERSON;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ADD_BTN;
        private System.Windows.Forms.PictureBox face_PICBX;
        private System.Windows.Forms.PictureBox image_PICBX;
    }
}