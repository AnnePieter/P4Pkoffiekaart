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
            this.butLeesUit = new System.Windows.Forms.Button();
            this.butVoornaam = new System.Windows.Forms.Button();
            this.butPuntGeven = new System.Windows.Forms.Button();
            this.tbAantalPuntjes = new System.Windows.Forms.TextBox();
            this.butKoffieKopen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butLeesUit
            // 
            this.butLeesUit.Location = new System.Drawing.Point(136, 167);
            this.butLeesUit.Name = "butLeesUit";
            this.butLeesUit.Size = new System.Drawing.Size(134, 55);
            this.butLeesUit.TabIndex = 0;
            this.butLeesUit.Text = "Kaartinformatie lezen";
            this.butLeesUit.UseVisualStyleBackColor = true;
            this.butLeesUit.Click += new System.EventHandler(this.butLeesUit_Click);
            // 
            // butVoornaam
            // 
            this.butVoornaam.Location = new System.Drawing.Point(8, 169);
            this.butVoornaam.Name = "butVoornaam";
            this.butVoornaam.Size = new System.Drawing.Size(122, 51);
            this.butVoornaam.TabIndex = 1;
            this.butVoornaam.Text = "Persoonsinformatie uitlezen";
            this.butVoornaam.UseVisualStyleBackColor = true;
            this.butVoornaam.Click += new System.EventHandler(this.butVoornaam_Click);
            // 
            // butPuntGeven
            // 
            this.butPuntGeven.Location = new System.Drawing.Point(135, 4);
            this.butPuntGeven.Name = "butPuntGeven";
            this.butPuntGeven.Size = new System.Drawing.Size(135, 52);
            this.butPuntGeven.TabIndex = 2;
            this.butPuntGeven.Text = "Ken punten toe";
            this.butPuntGeven.UseVisualStyleBackColor = true;
            this.butPuntGeven.Click += new System.EventHandler(this.butPuntGeven_Click);
            // 
            // tbAantalPuntjes
            // 
            this.tbAantalPuntjes.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.tbAantalPuntjes.Location = new System.Drawing.Point(12, 9);
            this.tbAantalPuntjes.Name = "tbAantalPuntjes";
            this.tbAantalPuntjes.Size = new System.Drawing.Size(104, 47);
            this.tbAantalPuntjes.TabIndex = 3;
            // 
            // butKoffieKopen
            // 
            this.butKoffieKopen.Location = new System.Drawing.Point(136, 85);
            this.butKoffieKopen.Name = "butKoffieKopen";
            this.butKoffieKopen.Size = new System.Drawing.Size(134, 54);
            this.butKoffieKopen.TabIndex = 4;
            this.butKoffieKopen.Text = "Koop een koffie!";
            this.butKoffieKopen.UseVisualStyleBackColor = true;
            this.butKoffieKopen.Click += new System.EventHandler(this.butKoffieKopen_Click);
            // 
            // Kaartlezer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(305, 253);
            this.Controls.Add(this.butKoffieKopen);
            this.Controls.Add(this.tbAantalPuntjes);
            this.Controls.Add(this.butPuntGeven);
            this.Controls.Add(this.butVoornaam);
            this.Controls.Add(this.butLeesUit);
            this.Name = "Kaartlezer";
            this.Text = "Kaartlezer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butLeesUit;
        private System.Windows.Forms.Button butVoornaam;
        private System.Windows.Forms.Button butPuntGeven;
        private System.Windows.Forms.TextBox tbAantalPuntjes;
        private System.Windows.Forms.Button butKoffieKopen;
    }
}

