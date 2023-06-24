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
            button2 = new Button();
            label2 = new Label();
            price = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(12, 12);
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
            pictureBox2.Location = new Point(12, 94);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(345, 337);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(43, 316);
            button1.Name = "button1";
            button1.Size = new Size(272, 40);
            button1.TabIndex = 4;
            button1.Text = "Acheter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(43, 376);
            button2.Name = "button2";
            button2.Size = new Size(272, 40);
            button2.TabIndex = 5;
            button2.Text = "Quitter";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(23, 293);
            label2.Name = "label2";
            label2.Size = new Size(213, 20);
            label2.TabIndex = 6;
            label2.Text = "Les maisons coûtent chacune";
            // 
            // price
            // 
            price.AutoSize = true;
            price.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            price.Location = new Point(252, 293);
            price.Name = "price";
            price.Size = new Size(50, 20);
            price.TabIndex = 7;
            price.Text = "label3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(27, 147);
            label3.Name = "label3";
            label3.Size = new Size(145, 20);
            label3.TabIndex = 8;
            label3.Text = "Lyer avec  1 maison";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(31, 183);
            label4.Name = "label4";
            label4.Size = new Size(141, 20);
            label4.TabIndex = 9;
            label4.Text = "Lyer avec 2 maison";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(31, 218);
            label5.Name = "label5";
            label5.Size = new Size(141, 20);
            label5.TabIndex = 10;
            label5.Text = "Lyer avec 3 maison";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(27, 256);
            label6.Name = "label6";
            label6.Size = new Size(141, 20);
            label6.TabIndex = 11;
            label6.Text = "Lyer avec 4 maison";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(265, 147);
            label7.Name = "label7";
            label7.Size = new Size(42, 23);
            label7.TabIndex = 12;
            label7.Text = "20 €";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(265, 183);
            label8.Name = "label8";
            label8.Size = new Size(42, 23);
            label8.TabIndex = 13;
            label8.Text = "40 €";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(260, 216);
            label9.Name = "label9";
            label9.Size = new Size(42, 23);
            label9.TabIndex = 14;
            label9.Text = " 60€";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(265, 253);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.Yes;
            label10.Size = new Size(42, 23);
            label10.TabIndex = 15;
            label10.Text = " 80€";
            // 
            // Carte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(370, 446);
            ControlBox = false;
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(price);
            Controls.Add(label2);
            Controls.Add(button2);
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
        private Button button2;
        private Label label2;
        private Label price;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}