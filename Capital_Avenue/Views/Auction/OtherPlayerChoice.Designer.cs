namespace Capital_Avenue.Views.Auction
{
    partial class OtherPlayerChoice
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
            Cancel = new Button();
            Header = new Label();
            SuspendLayout();
            // 
            // Cancel
            // 
            Cancel.BackColor = Color.Red;
            Cancel.Location = new Point(70, 170);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(183, 29);
            Cancel.TabIndex = 3;
            Cancel.Text = "Annuler";
            Cancel.UseVisualStyleBackColor = false;
            Cancel.Click += Cancel_Click;
            // 
            // Header
            // 
            Header.AutoSize = true;
            Header.Location = new Point(12, 42);
            Header.Name = "Header";
            Header.Size = new Size(50, 20);
            Header.TabIndex = 4;
            Header.Text = "label1";
            // 
            // OtherPlayerChoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 253);
            Controls.Add(Header);
            Controls.Add(Cancel);
            Location = new Point(840, 380);
            Name = "OtherPlayerChoice";
            StartPosition = FormStartPosition.Manual;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Cancel;
        private Label Header;
    }
}
