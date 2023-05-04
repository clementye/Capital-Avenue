namespace Capital_Avenue.Views
{
    partial class UCEnterPlayer
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCEnterPlayer));
            label1 = new Label();
            label2 = new Label();
            Joueur1 = new TextBox();
            button1 = new Button();
            Avatar = new Label();
            comboBox1 = new ComboBox();
            imageList1 = new ImageList(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(290, 63);
            label1.Name = "label1";
            label1.Size = new Size(311, 42);
            label1.TabIndex = 0;
            label1.Text = "Entrer  Les  Joueurs";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(159, 139);
            label2.Name = "label2";
            label2.Size = new Size(134, 34);
            label2.TabIndex = 1;
            label2.Text = "Joueur 1 :";
            // 
            // Joueur1
            // 
            Joueur1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Joueur1.Location = new Point(290, 127);
            Joueur1.Name = "Joueur1";
            Joueur1.Size = new Size(201, 51);
            Joueur1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(336, 242);
            button1.Name = "button1";
            button1.Size = new Size(139, 46);
            button1.TabIndex = 3;
            button1.Text = "Confirmer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Avatar
            // 
            Avatar.AutoSize = true;
            Avatar.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Avatar.Location = new Point(521, 139);
            Avatar.Name = "Avatar";
            Avatar.Size = new Size(92, 34);
            Avatar.TabIndex = 4;
            Avatar.Text = "Avatar";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.White;
            comboBox1.DrawMode = DrawMode.OwnerDrawVariable;
            comboBox1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.ItemHeight = 60;
            comboBox1.Location = new Point(619, 112);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(94, 66);
            comboBox1.TabIndex = 5;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "token_green.png");
            imageList1.Images.SetKeyName(1, "token_2");
            // 
            // UCEnterPlayer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(comboBox1);
            Controls.Add(Avatar);
            Controls.Add(button1);
            Controls.Add(Joueur1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UCEnterPlayer";
            Size = new Size(1013, 470);
            Load += UCEnterPlayer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Joueur1;
        private Button button1;
        private Label Avatar;
        private ComboBox comboBox1;
        private ImageList imageList1;
    }
}
