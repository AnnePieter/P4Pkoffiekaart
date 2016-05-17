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
            this.butLeesUit = new System.Windows.Forms.Button();
            this.butVoornaam = new System.Windows.Forms.Button();
            this.butPuntGeven = new System.Windows.Forms.Button();
            this.tbAantalPuntjes = new System.Windows.Forms.TextBox();
            this.butKoffieKopen = new System.Windows.Forms.Button();
            this.test = new MetroFramework.Controls.MetroTabControl();
            this.Home = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.test.SuspendLayout();
            this.Home.SuspendLayout();
            this.SuspendLayout();
            // 
            // butLeesUit
            // 
            this.butLeesUit.Location = new System.Drawing.Point(60, 144);
            this.butLeesUit.Name = "butLeesUit";
            this.butLeesUit.Size = new System.Drawing.Size(134, 55);
            this.butLeesUit.TabIndex = 0;
            this.butLeesUit.Text = "Kaartinformatie lezen";
            this.butLeesUit.UseVisualStyleBackColor = true;
            this.butLeesUit.Click += new System.EventHandler(this.butLeesUit_Click);
            // 
            // butVoornaam
            // 
            this.butVoornaam.Location = new System.Drawing.Point(60, 78);
            this.butVoornaam.Name = "butVoornaam";
            this.butVoornaam.Size = new System.Drawing.Size(122, 51);
            this.butVoornaam.TabIndex = 1;
            this.butVoornaam.Text = "Persoonsinformatie uitlezen";
            this.butVoornaam.UseVisualStyleBackColor = true;
            this.butVoornaam.Click += new System.EventHandler(this.butVoornaam_Click);
            // 
            // butPuntGeven
            // 
            this.butPuntGeven.Location = new System.Drawing.Point(208, 86);
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
            this.tbAantalPuntjes.Location = new System.Drawing.Point(78, 16);
            this.tbAantalPuntjes.Name = "tbAantalPuntjes";
            this.tbAantalPuntjes.Size = new System.Drawing.Size(104, 47);
            this.tbAantalPuntjes.TabIndex = 3;
            // 
            // butKoffieKopen
            // 
            this.butKoffieKopen.Location = new System.Drawing.Point(219, 144);
            this.butKoffieKopen.Name = "butKoffieKopen";
            this.butKoffieKopen.Size = new System.Drawing.Size(134, 54);
            this.butKoffieKopen.TabIndex = 4;
            this.butKoffieKopen.Text = "Koop een koffie!";
            this.butKoffieKopen.UseVisualStyleBackColor = true;
            this.butKoffieKopen.Click += new System.EventHandler(this.butKoffieKopen_Click);
            // 
            // test
            // 
            this.test.Controls.Add(this.Home);
            this.test.Controls.Add(this.metroTabPage2);
            this.test.Location = new System.Drawing.Point(0, -2);
            this.test.Name = "test";
            this.test.SelectedIndex = 0;
            this.test.Size = new System.Drawing.Size(1024, 768);
            this.test.Style = MetroFramework.MetroColorStyle.Black;
            this.test.TabIndex = 6;
            this.test.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.test.UseSelectable = true;
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Yellow;
            this.Home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Home.BackgroundImage")));
            this.Home.Controls.Add(this.tbAantalPuntjes);
            this.Home.Controls.Add(this.butVoornaam);
            this.Home.Controls.Add(this.butPuntGeven);
            this.Home.Controls.Add(this.butLeesUit);
            this.Home.Controls.Add(this.butKoffieKopen);
            this.Home.HorizontalScrollbarBarColor = true;
            this.Home.HorizontalScrollbarHighlightOnWheel = false;
            this.Home.HorizontalScrollbarSize = 10;
            this.Home.Location = new System.Drawing.Point(4, 38);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(1016, 726);
            this.Home.TabIndex = 0;
            this.Home.Text = "metroTabPage1";
            this.Home.VerticalScrollbarBarColor = true;
            this.Home.VerticalScrollbarHighlightOnWheel = false;
            this.Home.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1016, 726);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "metroTabPage2";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // Kaartlezer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.test);
            this.Name = "Kaartlezer";
            this.Text = "Kaartlezer";
            this.test.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butLeesUit;
        private System.Windows.Forms.Button butVoornaam;
        private System.Windows.Forms.Button butPuntGeven;
        private System.Windows.Forms.TextBox tbAantalPuntjes;
        private System.Windows.Forms.Button butKoffieKopen;
        private MetroFramework.Controls.MetroTabControl test;
        private MetroFramework.Controls.MetroTabPage Home;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
    }
}

