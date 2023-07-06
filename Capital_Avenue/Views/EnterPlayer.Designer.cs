namespace Capital_Avenue.Views
{
    partial class EnterPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterPlayer));
            leftPlayerPanel = new FlowLayoutPanel();
            imageList1 = new ImageList(components);
            NumberPlayer = new ComboBox();
            SuspendLayout();
            // 
            // leftPlayerPanel
            // 
            leftPlayerPanel.BackColor = Color.Transparent;
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
            // NumberPlayer
            // 
            NumberPlayer.FormattingEnabled = true;
            NumberPlayer.Location = new Point(572, 46);
            NumberPlayer.Name = "NumberPlayer";
            NumberPlayer.Size = new Size(74, 28);
            NumberPlayer.TabIndex = 2;
            NumberPlayer.SelectionChangeCommitted += OnMyPawnPrinterChanged;
            // 
            // EnterPlayer
            // 
            Controls.Add(NumberPlayer);
            Controls.Add(leftPlayerPanel);
            DoubleBuffered = true;
            Name = "EnterPlayer";
            Size = new Size(1178, 638);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel leftPlayerPanel;
        private ImageList imageList1;
        private ComboBox NumberPlayer;
    }
}
