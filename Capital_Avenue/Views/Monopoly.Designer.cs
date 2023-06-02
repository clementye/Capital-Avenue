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
            onDice = new Button();
            onBankrupt = new Button();
            currentPlayerName = new Label();
            DiceShow = new Label();
            DiceResultShow = new Label();
            ucBoard1 = new Board.Board();
            Test = new Label();
            SuspendLayout();
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
            onDice.Click += onDice_Click;
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
            // currentPlayerName
            // 
            currentPlayerName.AutoSize = true;
            currentPlayerName.Location = new Point(857, 269);
            currentPlayerName.Name = "currentPlayerName";
            currentPlayerName.Size = new Size(50, 20);
            currentPlayerName.TabIndex = 42;
            currentPlayerName.Text = "label1";
            // 
            // DiceShow
            // 
            DiceShow.AutoSize = true;
            DiceShow.Location = new Point(857, 301);
            DiceShow.Name = "DiceShow";
            DiceShow.Size = new Size(50, 20);
            DiceShow.TabIndex = 43;
            DiceShow.Text = "label2";
            // 
            // DiceResultShow
            // 
            DiceResultShow.AutoSize = true;
            DiceResultShow.Location = new Point(857, 332);
            DiceResultShow.Name = "DiceResultShow";
            DiceResultShow.Size = new Size(50, 20);
            DiceResultShow.TabIndex = 44;
            DiceResultShow.Text = "label3";
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
            // Test
            // 
            Test.AutoSize = true;
            Test.Location = new Point(1186, 269);
            Test.Name = "Test";
            Test.Size = new Size(50, 20);
            Test.TabIndex = 45;
            Test.Text = "label1";
            // 
            // Monopoly
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(Test);
            Controls.Add(DiceResultShow);
            Controls.Add(DiceShow);
            Controls.Add(currentPlayerName);
            Controls.Add(onBankrupt);
            Controls.Add(onDice);
            Controls.Add(ucBoard1);
            Name = "Monopoly";
            Size = new Size(1884, 1069);
            Load += UCMonopoly_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button onDice;
        private Button onBankrupt;
        private Board.Board ucBoard1;
        private Label currentPlayerName;
        private Label DiceShow;
        private Label DiceResultShow;
        private Label Test;
    }
}
