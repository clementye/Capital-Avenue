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
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(573, 535);
            button1.Name = "button1";
            button1.Size = new Size(180, 50);
            button1.TabIndex = 0;
            button1.Text = "Jouer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            DoubleBuffered = true;
            Name = "HomePage";
            Size = new Size(1354, 603);
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
    }
}
