namespace Capital_Avenue.Views
{
    partial class UCChoicePlayer
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
            Valider = new Button();
            NumberPlayer = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // Valider
            // 
            Valider.Location = new Point(430, 179);
            Valider.Name = "Valider";
            Valider.Size = new Size(133, 45);
            Valider.TabIndex = 1;
            Valider.Text = "Valider";
            Valider.UseVisualStyleBackColor = true;
            Valider.Click += Valider_Click;
            // 
            // NumberPlayer
            // 
            NumberPlayer.FormattingEnabled = true;
            NumberPlayer.Location = new Point(421, 133);
            NumberPlayer.Name = "NumberPlayer";
            NumberPlayer.Size = new Size(142, 28);
            NumberPlayer.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(303, 68);
            label1.Name = "label1";
            label1.Size = new Size(407, 39);
            label1.TabIndex = 3;
            label1.Text = "Choisir le nombre de joueurs";
            // 
            // UCChoicePlayer
            // 
            Controls.Add(label1);
            Controls.Add(NumberPlayer);
            Controls.Add(Valider);
            Name = "UCChoicePlayer";
            Size = new Size(1085, 484);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Valider;
        private ComboBox NumberPlayer;
        private Label label1;
    }
}
