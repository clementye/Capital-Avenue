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
            button1 = new Button();
            leftPlayerPanel = new FlowLayoutPanel();
            imageList1 = new ImageList(components);
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(516, 473);
            button1.Name = "button1";
            button1.Size = new Size(160, 50);
            button1.TabIndex = 0;
            button1.Text = "Confirmer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // leftPlayerPanel
            // 
            leftPlayerPanel.Location = new Point(3, 14);
            leftPlayerPanel.Name = "leftPlayerPanel";
            leftPlayerPanel.Size = new Size(413, 548);
            leftPlayerPanel.TabIndex = 1;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Voiture");
            imageList1.Images.SetKeyName(1, "Velo");
            // 
            // UCEnterPlayer
            // 
            Controls.Add(button1);
            Controls.Add(leftPlayerPanel);
            Name = "UCEnterPlayer";
            Size = new Size(1178, 638);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private FlowLayoutPanel leftPlayerPanel;
        private ImageList imageList1;
    }
}
