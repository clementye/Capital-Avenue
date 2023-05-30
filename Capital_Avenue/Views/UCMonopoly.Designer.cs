namespace Capital_Avenue.Views
{
    partial class UCMonopoly
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCMonopoly));
            pictureBox1 = new PictureBox();
            onDice = new Button();
            onBankrupt = new Button();
            ucBoard1 = new Board.UCBoard();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(554, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(900, 900);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // onDice
            // 
            onDice.Anchor = AnchorStyles.Right;
            onDice.Location = new Point(766, 542);
            onDice.Margin = new Padding(3, 4, 3, 4);
            onDice.Name = "onDice";
            onDice.Size = new Size(86, 31);
            onDice.TabIndex = 40;
            onDice.Text = "Lancer les dés";
            onDice.UseVisualStyleBackColor = true;
            // 
            // onBankrupt
            // 
            onBankrupt.Anchor = AnchorStyles.Right;
            onBankrupt.Location = new Point(1135, 542);
            onBankrupt.Margin = new Padding(3, 4, 3, 4);
            onBankrupt.Name = "onBankrupt";
            onBankrupt.Size = new Size(86, 31);
            onBankrupt.TabIndex = 41;
            onBankrupt.Text = "Faillite";
            onBankrupt.UseVisualStyleBackColor = true;
            // 
            // ucBoard1
            // 
            ucBoard1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ucBoard1.AutoValidate = AutoValidate.EnablePreventFocusChange;
            ucBoard1.BackColor = Color.Transparent;
            ucBoard1.BackgroundImageLayout = ImageLayout.None;
            ucBoard1.BorderStyle = BorderStyle.FixedSingle;
            ucBoard1.ForeColor = Color.Transparent;
            ucBoard1.Location = new Point(554, 55);
            ucBoard1.Name = "ucBoard1";
            ucBoard1.Size = new Size(900, 900);
            ucBoard1.TabIndex = 42;
            // 
            // UCMonopoly
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(onBankrupt);
            Controls.Add(onDice);
            Controls.Add(ucBoard1);
            Controls.Add(pictureBox1);
            Name = "UCMonopoly";
            Size = new Size(1884, 1069);
            Load += UCMonopoly_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button onDice;
        private Button onBankrupt;
        private Board.UCBoard ucBoard1;
    }
}
