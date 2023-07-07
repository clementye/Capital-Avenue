namespace Capital_Avenue.Views
{
    partial class HomePage
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            menu = new Panel();
            btn_exit = new PictureBox();
            btn_Start = new PictureBox();
            pictureBox1 = new PictureBox();
            menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_exit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Start).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menu
            // 
            menu.BackColor = Color.WhiteSmoke;
            menu.BackgroundImage = (Image)resources.GetObject("menu.BackgroundImage");
            menu.BackgroundImageLayout = ImageLayout.Stretch;
            menu.Controls.Add(btn_exit);
            menu.Controls.Add(btn_Start);
            menu.Location = new Point(729, 330);
            menu.Name = "menu";
            menu.Size = new Size(397, 436);
            menu.TabIndex = 1;
            // 
            // btn_exit
            // 
            btn_exit.BackgroundImage = (Image)resources.GetObject("btn_exit.BackgroundImage");
            btn_exit.BackgroundImageLayout = ImageLayout.Stretch;
            btn_exit.Location = new Point(150, 254);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(100, 52);
            btn_exit.SizeMode = PictureBoxSizeMode.Zoom;
            btn_exit.TabIndex = 3;
            btn_exit.TabStop = false;
            btn_exit.Click += exit_Click;
            btn_exit.MouseLeave += btn_exit_Click_Mouveleave;
            btn_exit.MouseHover += btn_exit_Click;
            // 
            // btn_Start
            // 
            btn_Start.BackgroundImage = (Image)resources.GetObject("btn_Start.BackgroundImage");
            btn_Start.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Start.Location = new Point(150, 123);
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new Size(100, 49);
            btn_Start.SizeMode = PictureBoxSizeMode.Zoom;
            btn_Start.TabIndex = 1;
            btn_Start.TabStop = false;
            btn_Start.Click += Start_Click;
            btn_Start.MouseLeave += btn_Start_Click_Mouveleave;
            btn_Start.MouseHover += btn_Start_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(318, -68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1164, 528);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(menu);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "HomePage";
            Size = new Size(1503, 852);
            menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btn_exit).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Start).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel menu;
        private PictureBox btn_Start;
        private PictureBox btn_exit;
        private PictureBox pictureBox1;
    }
}
