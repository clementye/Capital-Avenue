namespace Capital_Avenue.Views
{
    partial class Monopoly
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Monopoly));
            onBankruptButton = new Button();
            currentPlayerName = new Label();
            ucBoard1 = new Board.Board();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            Dice_lef = new PictureBox();
            dice_right = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Quit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Dice_lef).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dice_right).BeginInit();
            SuspendLayout();
            // 
            // onBankruptButton
            // 
            onBankruptButton.Anchor = AnchorStyles.Right;
            onBankruptButton.Location = new Point(1123, 626);
            onBankruptButton.Margin = new Padding(3, 4, 3, 4);
            onBankruptButton.Name = "onBankruptButton";
            onBankruptButton.Size = new Size(86, 36);
            onBankruptButton.TabIndex = 41;
            onBankruptButton.Text = "Faillite";
            onBankruptButton.UseVisualStyleBackColor = true;
            onBankruptButton.Click += onBankruptButton_Click;
            // 
            // currentPlayerName
            // 
            currentPlayerName.AllowDrop = true;
            currentPlayerName.AutoSize = true;
            currentPlayerName.BackColor = SystemColors.ButtonHighlight;
            currentPlayerName.Font = new Font("Rockwell Extra Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            currentPlayerName.Location = new Point(1031, 237);
            currentPlayerName.Name = "currentPlayerName";
            currentPlayerName.Size = new Size(215, 27);
            currentPlayerName.TabIndex = 45;
            currentPlayerName.Text = "Nom du joueur";
            currentPlayerName.UseWaitCursor = true;
            // 
            // ucBoard1
            // 
            ucBoard1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ucBoard1.AutoValidate = AutoValidate.EnablePreventFocusChange;
            ucBoard1.BackColor = Color.Transparent;
            ucBoard1.BackgroundImageLayout = ImageLayout.None;
            ucBoard1.BorderStyle = BorderStyle.FixedSingle;
            ucBoard1.ForeColor = Color.Transparent;
            ucBoard1.Location = new Point(566, 56);
            ucBoard1.Name = "ucBoard1";
            ucBoard1.Size = new Size(887, 900);
            ucBoard1.TabIndex = 42;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(862, 491);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 64);
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1084, 485);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 70);
            pictureBox2.TabIndex = 48;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Dice_lef
            // 
            Dice_lef.BackColor = SystemColors.ButtonHighlight;
            Dice_lef.Location = new Point(804, 315);
            Dice_lef.Name = "Dice_lef";
            Dice_lef.Size = new Size(134, 111);
            Dice_lef.TabIndex = 49;
            Dice_lef.TabStop = false;
            // 
            // dice_right
            // 
            dice_right.BackColor = SystemColors.ControlLightLight;
            dice_right.Location = new Point(1060, 315);
            dice_right.Name = "dice_right";
            dice_right.Size = new Size(132, 111);
            dice_right.TabIndex = 50;
            dice_right.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(836, 573);
            label1.Name = "label1";
            label1.Size = new Size(117, 23);
            label1.TabIndex = 51;
            label1.Text = "Lancés les dés";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1073, 573);
            label2.Name = "label2";
            label2.Size = new Size(105, 23);
            label2.TabIndex = 52;
            label2.Text = "Fin de partie";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(847, 233);
            label3.Name = "label3";
            label3.Size = new Size(178, 31);
            label3.TabIndex = 53;
            label3.Text = "Joueur Actuel :";
            // 
            // Quit
            // 
            Quit.BackgroundImage = (Image)resources.GetObject("Quit.BackgroundImage");
            Quit.Location = new Point(1826, 882);
            Quit.Name = "Quit";
            Quit.Size = new Size(55, 74);
            Quit.TabIndex = 54;
            Quit.UseVisualStyleBackColor = true;
            Quit.Click += quitButton_Click;
            // 
            // Monopoly
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(Quit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dice_right);
            Controls.Add(Dice_lef);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(currentPlayerName);
            Controls.Add(onBankruptButton);
            Controls.Add(ucBoard1);
            DoubleBuffered = true;
            Name = "Monopoly";
            Size = new Size(1884, 1069);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Dice_lef).EndInit();
            ((System.ComponentModel.ISupportInitialize)dice_right).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button onBankruptButton;
        private Board.Board ucBoard1;
        private Label currentPlayerName;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private PictureBox Dice_lef;
        private PictureBox dice_right;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button Quit;
    }
}
