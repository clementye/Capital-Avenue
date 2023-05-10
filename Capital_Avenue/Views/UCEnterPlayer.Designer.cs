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
            Player1 = new TextBox();
            button1 = new Button();
            Avatar = new Label();
            comboBox1 = new ComboBox();
            imageList1 = new ImageList(components);
            Player2 = new TextBox();
            label3 = new Label();
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
            // Player1
            // 
            Player1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Player1.Location = new Point(290, 127);
            Player1.Name = "Player1";
            Player1.Size = new Size(201, 51);
            Player1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(337, 360);
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
            // Player2
            // 
            Player2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Player2.Location = new Point(290, 216);
            Player2.Name = "Player2";
            Player2.Size = new Size(201, 51);
            Player2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(159, 228);
            label3.Name = "label3";
            label3.Size = new Size(134, 34);
            label3.TabIndex = 7;
            label3.Text = "Joueur 2 :";
            // 
            // UCEnterPlayer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(label3);
            Controls.Add(Player2);
            Controls.Add(comboBox1);
            Controls.Add(Avatar);
            Controls.Add(button1);
            Controls.Add(Player1);
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
        private TextBox Player1;
        private Button button1;
        private Label Avatar;
        private ComboBox comboBox1;
        private ImageList imageList1;
        private TextBox Player2;
        private Label label3;
    }
}
