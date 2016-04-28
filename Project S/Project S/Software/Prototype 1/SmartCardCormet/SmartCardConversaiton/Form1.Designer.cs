namespace SmartCardConversaiton
{
    partial class Kaartlezer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kaartlezer));
            this.butPuntGeven = new System.Windows.Forms.Button();
            this.butKoffieKopen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // butPuntGeven
            // 
            this.butPuntGeven.BackColor = System.Drawing.Color.Gold;
            this.butPuntGeven.Location = new System.Drawing.Point(12, 12);
            this.butPuntGeven.Name = "butPuntGeven";
            this.butPuntGeven.Size = new System.Drawing.Size(230, 303);
            this.butPuntGeven.TabIndex = 2;
            this.butPuntGeven.Text = "Ken een punt toe";
            this.butPuntGeven.UseVisualStyleBackColor = false;
            this.butPuntGeven.Click += new System.EventHandler(this.butPuntGeven_Click);
            // 
            // butKoffieKopen
            // 
            this.butKoffieKopen.BackColor = System.Drawing.Color.LimeGreen;
            this.butKoffieKopen.Location = new System.Drawing.Point(248, 12);
            this.butKoffieKopen.Name = "butKoffieKopen";
            this.butKoffieKopen.Size = new System.Drawing.Size(230, 303);
            this.butKoffieKopen.TabIndex = 4;
            this.butKoffieKopen.Text = "Koop een koffie!";
            this.butKoffieKopen.UseVisualStyleBackColor = false;
            this.butKoffieKopen.Click += new System.EventHandler(this.butKoffieKopen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SmartCardConversaiton.Properties.Resources.Cormet;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(74, 323);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Kaartlezer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(485, 486);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.butKoffieKopen);
            this.Controls.Add(this.butPuntGeven);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kaartlezer";
            this.Text = "Cormet: Punten systeem";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butPuntGeven;
        private System.Windows.Forms.Button butKoffieKopen;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

