namespace KlijentskiInterfejs
{
    partial class FrmKlijent
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSendToAll = new System.Windows.Forms.RichTextBox();
            this.txtSendToOne = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbOnlineKorisnici = new System.Windows.Forms.ComboBox();
            this.btnSendToAll = new System.Windows.Forms.Button();
            this.btnSendToOne = new System.Windows.Forms.Button();
            this.txtNajnovije = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSve = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Poruka(Svima):";
            // 
            // txtSendToAll
            // 
            this.txtSendToAll.Location = new System.Drawing.Point(129, 13);
            this.txtSendToAll.Name = "txtSendToAll";
            this.txtSendToAll.Size = new System.Drawing.Size(398, 117);
            this.txtSendToAll.TabIndex = 1;
            this.txtSendToAll.Text = "";
            // 
            // txtSendToOne
            // 
            this.txtSendToOne.Location = new System.Drawing.Point(129, 199);
            this.txtSendToOne.Name = "txtSendToOne";
            this.txtSendToOne.Size = new System.Drawing.Size(398, 117);
            this.txtSendToOne.TabIndex = 3;
            this.txtSendToOne.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Poruka(Privatno):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Online korisnici: ";
            // 
            // cbOnlineKorisnici
            // 
            this.cbOnlineKorisnici.FormattingEnabled = true;
            this.cbOnlineKorisnici.Location = new System.Drawing.Point(129, 151);
            this.cbOnlineKorisnici.Name = "cbOnlineKorisnici";
            this.cbOnlineKorisnici.Size = new System.Drawing.Size(181, 24);
            this.cbOnlineKorisnici.TabIndex = 5;
            // 
            // btnSendToAll
            // 
            this.btnSendToAll.Location = new System.Drawing.Point(429, 136);
            this.btnSendToAll.Name = "btnSendToAll";
            this.btnSendToAll.Size = new System.Drawing.Size(98, 46);
            this.btnSendToAll.TabIndex = 6;
            this.btnSendToAll.Text = "Posalji";
            this.btnSendToAll.UseVisualStyleBackColor = true;
            this.btnSendToAll.Click += new System.EventHandler(this.btnSendToAll_Click);
            // 
            // btnSendToOne
            // 
            this.btnSendToOne.Location = new System.Drawing.Point(429, 322);
            this.btnSendToOne.Name = "btnSendToOne";
            this.btnSendToOne.Size = new System.Drawing.Size(98, 46);
            this.btnSendToOne.TabIndex = 7;
            this.btnSendToOne.Text = "Posalji";
            this.btnSendToOne.UseVisualStyleBackColor = true;
            // 
            // txtNajnovije
            // 
            this.txtNajnovije.Location = new System.Drawing.Point(129, 392);
            this.txtNajnovije.Name = "txtNajnovije";
            this.txtNajnovije.Size = new System.Drawing.Size(558, 73);
            this.txtNajnovije.TabIndex = 8;
            this.txtNajnovije.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Najnovije:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 499);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sve:";
            // 
            // txtSve
            // 
            this.txtSve.Location = new System.Drawing.Point(129, 496);
            this.txtSve.Name = "txtSve";
            this.txtSve.Size = new System.Drawing.Size(558, 173);
            this.txtSve.TabIndex = 10;
            this.txtSve.Text = "";
            // 
            // FrmKlijent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 681);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSve);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNajnovije);
            this.Controls.Add(this.btnSendToOne);
            this.Controls.Add(this.btnSendToAll);
            this.Controls.Add(this.cbOnlineKorisnici);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSendToOne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSendToAll);
            this.Controls.Add(this.label1);
            this.Name = "FrmKlijent";
            this.Text = "Klijentski intefejs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmKlijent_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtSendToAll;
        private System.Windows.Forms.RichTextBox txtSendToOne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbOnlineKorisnici;
        private System.Windows.Forms.Button btnSendToAll;
        private System.Windows.Forms.Button btnSendToOne;
        private System.Windows.Forms.RichTextBox txtNajnovije;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtSve;
    }
}

