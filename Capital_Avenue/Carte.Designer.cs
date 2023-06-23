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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(49, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(345, 120);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(159, 27);
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
            Nom_propiéte.Location = new Point(159, 74);
            Nom_propiéte.Name = "Nom_propiéte";
            Nom_propiéte.Size = new Size(124, 25);
            Nom_propiéte.TabIndex = 2;
            Nom_propiéte.Text = "Nom propiété";
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(49, 127);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(345, 346);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(80, 329);
            button1.Name = "button1";
            button1.Size = new Size(272, 40);
            button1.TabIndex = 4;
            button1.Text = "Acheter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(80, 391);
            button2.Name = "button2";
            button2.Size = new Size(272, 40);
            button2.TabIndex = 5;
            button2.Text = "Ne pas acheter";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(60, 303);
            label2.Name = "label2";
            label2.Size = new Size(213, 20);
            label2.TabIndex = 6;
            label2.Text = "Les maisons coûtent chacune";
            // 
            // price
            // 
            price.AutoSize = true;
            price.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            price.Location = new Point(293, 303);
            price.Name = "price";
            price.Size = new Size(50, 20);
            price.TabIndex = 7;
            price.Text = "label3";
            // 
            // Carte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(476, 476);
            Controls.Add(price);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Nom_propiéte);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "Carte";
            StartPosition = FormStartPosition.CenterScreen;
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
    }
}