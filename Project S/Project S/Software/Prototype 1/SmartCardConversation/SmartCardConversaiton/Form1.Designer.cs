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
            this.tbAantalPuntjes = new System.Windows.Forms.TextBox();
            this.test = new MetroFramework.Controls.MetroTabControl();
            this.Home = new MetroFramework.Controls.MetroTabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialRaisedButton4 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.Debug = new MetroFramework.Controls.MetroTabPage();
            this.test.SuspendLayout();
            this.Home.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbAantalPuntjes
            // 
            this.tbAantalPuntjes.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tbAantalPuntjes.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.tbAantalPuntjes.Location = new System.Drawing.Point(647, 462);
            this.tbAantalPuntjes.Name = "tbAantalPuntjes";
            this.tbAantalPuntjes.Size = new System.Drawing.Size(104, 47);
            this.tbAantalPuntjes.TabIndex = 3;
            // 
            // test
            // 
            this.test.Controls.Add(this.Home);
            this.test.Controls.Add(this.Debug);
            this.test.Location = new System.Drawing.Point(0, -2);
            this.test.Name = "test";
            this.test.SelectedIndex = 0;
            this.test.Size = new System.Drawing.Size(1024, 768);
            this.test.Style = MetroFramework.MetroColorStyle.Black;
            this.test.TabIndex = 6;
            this.test.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.White;
            this.Home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Home.BackgroundImage")));
            this.Home.Controls.Add(this.groupBox1);
            this.Home.HorizontalScrollbarBarColor = true;
            this.Home.Location = new System.Drawing.Point(4, 35);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(1016, 729);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.VerticalScrollbarBarColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.materialRaisedButton4);
            this.groupBox1.Controls.Add(this.materialRaisedButton3);
            this.groupBox1.Controls.Add(this.materialRaisedButton2);
            this.groupBox1.Controls.Add(this.materialRaisedButton1);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.tbAantalPuntjes);
            this.groupBox1.Location = new System.Drawing.Point(-35, -42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1048, 757);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // materialRaisedButton4
            // 
            this.materialRaisedButton4.Depth = 0;
            this.materialRaisedButton4.Location = new System.Drawing.Point(-9, 367);
            this.materialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton4.Name = "materialRaisedButton4";
            this.materialRaisedButton4.Primary = true;
            this.materialRaisedButton4.Size = new System.Drawing.Size(254, 31);
            this.materialRaisedButton4.TabIndex = 9;
            this.materialRaisedButton4.Text = "Koop een koffie";
            this.materialRaisedButton4.UseVisualStyleBackColor = true;
            this.materialRaisedButton4.Click += new System.EventHandler(this.materialRaisedButton4_Click);
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Location = new System.Drawing.Point(-9, 319);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(254, 31);
            this.materialRaisedButton3.TabIndex = 8;
            this.materialRaisedButton3.Text = "Ken punten toe";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            this.materialRaisedButton3.Click += new System.EventHandler(this.materialRaisedButton3_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(0, 271);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(245, 31);
            this.materialRaisedButton2.TabIndex = 7;
            this.materialRaisedButton2.Text = "Informatie Lezen";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.BackColor = System.Drawing.Color.ForestGreen;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(-32, 224);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(277, 31);
            this.materialRaisedButton1.TabIndex = 6;
            this.materialRaisedButton1.Text = "Kaart Lezen";
            this.materialRaisedButton1.UseCompatibleTextRendering = true;
            this.materialRaisedButton1.UseVisualStyleBackColor = false;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.White;
            this.materialLabel1.Location = new System.Drawing.Point(573, 512);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(123, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "STATUS: Waiting";
            // 
            // Debug
            // 
            this.Debug.HorizontalScrollbarBarColor = true;
            this.Debug.Location = new System.Drawing.Point(4, 35);
            this.Debug.Name = "Debug";
            this.Debug.Size = new System.Drawing.Size(1016, 729);
            this.Debug.TabIndex = 1;
            this.Debug.Text = "Debug";
            this.Debug.VerticalScrollbarBarColor = true;
            // 
            // Kaartlezer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.test);
            this.Name = "Kaartlezer";
            this.Text = "Kaartlezer";
            this.test.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbAantalPuntjes;
        private MetroFramework.Controls.MetroTabControl test;
        private MetroFramework.Controls.MetroTabPage Home;
        private MetroFramework.Controls.MetroTabPage Debug;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton4;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}

