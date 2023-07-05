namespace Capital_Avenue
{
    partial class Carte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            Nom_propiéte = new Label();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            ButtonQuitter = new Button();
            label2 = new Label();
            price = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            PriceOneHouse = new Label();
            PriceTowHouse = new Label();
            PriceThreeHouse = new Label();
            PriceFourHouse = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(345, 85);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(112, 21);
            label1.Name = "label1";
            label1.Size = new Size(114, 31);
            label1.TabIndex = 1;
            label1.Text = "Propriété";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Nom_propiéte
            // 
            Nom_propiéte.AutoSize = true;
            Nom_propiéte.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Nom_propiéte.Location = new Point(112, 57);
            Nom_propiéte.Name = "Nom_propiéte";
            Nom_propiéte.Size = new Size(124, 25);
            Nom_propiéte.TabIndex = 2;
            Nom_propiéte.Text = "Nom propiété";
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(3, 85);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(345, 337);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(34, 321);
            button1.Name = "button1";
            button1.Size = new Size(272, 40);
            button1.TabIndex = 4;
            button1.Text = "Acheter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ButtonQuitter
            // 
            ButtonQuitter.Location = new Point(34, 367);
            ButtonQuitter.Name = "ButtonQuitter";
            ButtonQuitter.Size = new Size(272, 40);
            ButtonQuitter.TabIndex = 5;
            ButtonQuitter.Text = "Quitter";
            ButtonQuitter.UseVisualStyleBackColor = true;
            ButtonQuitter.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 284);
            label2.Name = "label2";
            label2.Size = new Size(213, 20);
            label2.TabIndex = 6;
            label2.Text = "Les maisons coûtent chacune";
            // 
            // price
            // 
            price.AutoSize = true;
            price.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            price.Location = new Point(243, 284);
            price.Name = "price";
            price.Size = new Size(35, 20);
            price.TabIndex = 7;
            price.Text = "rent";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(14, 138);
            label3.Name = "label3";
            label3.Size = new Size(155, 20);
            label3.TabIndex = 8;
            label3.Text = "Loyer avec  1 maison";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(14, 172);
            label4.Name = "label4";
            label4.Size = new Size(151, 20);
            label4.TabIndex = 9;
            label4.Text = "Loyer avec 2 maison";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(14, 206);
            label5.Name = "label5";
            label5.Size = new Size(151, 20);
            label5.TabIndex = 10;
            label5.Text = "Loyer avec 3 maison";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(14, 246);
            label6.Name = "label6";
            label6.Size = new Size(151, 20);
            label6.TabIndex = 11;
            label6.Text = "Loyer avec 4 maison";
            // 
            // PriceOneHouse
            // 
            PriceOneHouse.AutoSize = true;
            PriceOneHouse.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PriceOneHouse.Location = new Point(231, 135);
            PriceOneHouse.Name = "PriceOneHouse";
            PriceOneHouse.Size = new Size(52, 23);
            PriceOneHouse.TabIndex = 12;
            PriceOneHouse.Text = "price ";
            // 
            // PriceTowHouse
            // 
            PriceTowHouse.AutoSize = true;
            PriceTowHouse.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PriceTowHouse.Location = new Point(231, 169);
            PriceTowHouse.Name = "PriceTowHouse";
            PriceTowHouse.Size = new Size(47, 23);
            PriceTowHouse.TabIndex = 13;
            PriceTowHouse.Text = "price";
            // 
            // PriceThreeHouse
            // 
            PriceThreeHouse.AutoSize = true;
            PriceThreeHouse.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PriceThreeHouse.Location = new Point(231, 206);
            PriceThreeHouse.Name = "PriceThreeHouse";
            PriceThreeHouse.Size = new Size(47, 23);
            PriceThreeHouse.TabIndex = 14;
            PriceThreeHouse.Text = "price";
            // 
            // PriceFourHouse
            // 
            PriceFourHouse.AutoSize = true;
            PriceFourHouse.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PriceFourHouse.Location = new Point(231, 243);
            PriceFourHouse.Name = "PriceFourHouse";
            PriceFourHouse.RightToLeft = RightToLeft.Yes;
            PriceFourHouse.Size = new Size(47, 23);
            PriceFourHouse.TabIndex = 15;
            PriceFourHouse.Text = "price";
            // 
            // Carte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(351, 425);
            ControlBox = false;
            Controls.Add(PriceFourHouse);
            Controls.Add(PriceThreeHouse);
            Controls.Add(PriceTowHouse);
            Controls.Add(PriceOneHouse);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(price);
            Controls.Add(label2);
            Controls.Add(ButtonQuitter);
            Controls.Add(button1);
            Controls.Add(Nom_propiéte);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Location = new Point(1470, 100);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Carte";
            StartPosition = FormStartPosition.Manual;
            Text = "Carte";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label Nom_propiéte;
        private PictureBox pictureBox2;
        private Button button1;
        private Button ButtonQuitter;
        private Label label2;
        private Label price;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label PriceOneHouse;
        private Label PriceTowHouse;
        private Label PriceThreeHouse;
        private Label PriceFourHouse;
        protected Label label3;
    }
}