namespace Capital_Avenue.Views.Auction
{
    partial class Auction
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
            button1 = new Button();
            label1 = new Label();
            checkedListBox1 = new CheckedListBox();
            CapitalP1 = new TextBox();
            AuctionConfirm = new Button();
            AuctionCancel = new Button();
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            CapitalP2 = new TextBox();
            checkedListBox2 = new CheckedListBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(169, 25);
            label1.Name = "label1";
            label1.Size = new Size(198, 54);
            label1.TabIndex = 2;
            label1.Text = "Échanges";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(33, 137);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(150, 114);
            checkedListBox1.TabIndex = 4;
            // 
            // CapitalP1
            // 
            CapitalP1.Location = new Point(33, 277);
            CapitalP1.Name = "CapitalP1";
            CapitalP1.Size = new Size(150, 27);
            CapitalP1.TabIndex = 5;
            // 
            // AuctionConfirm
            // 
            AuctionConfirm.Location = new Point(191, 330);
            AuctionConfirm.Name = "AuctionConfirm";
            AuctionConfirm.Size = new Size(151, 29);
            AuctionConfirm.TabIndex = 6;
            AuctionConfirm.Text = "Confirmer l'enchère";
            AuctionConfirm.UseVisualStyleBackColor = true;
            AuctionConfirm.Click += AuctionConfirm_Click;
            // 
            // AuctionCancel
            // 
            AuctionCancel.BackColor = Color.Red;
            AuctionCancel.Location = new Point(216, 365);
            AuctionCancel.Name = "AuctionCancel";
            AuctionCancel.Size = new Size(94, 29);
            AuctionCancel.TabIndex = 7;
            AuctionCancel.Text = "Annuler";
            AuctionCancel.UseVisualStyleBackColor = false;
            AuctionCancel.Click += AuctionCancel_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(101, 67);
            panel1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 23);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 0;
            label2.Text = "label2";
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Location = new Point(430, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(101, 67);
            panel2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 19);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 1;
            label3.Text = "label3";
            // 
            // CapitalP2
            // 
            CapitalP2.Location = new Point(345, 277);
            CapitalP2.Name = "CapitalP2";
            CapitalP2.Size = new Size(150, 27);
            CapitalP2.TabIndex = 10;
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Location = new Point(345, 137);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(150, 114);
            checkedListBox2.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 254);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 12;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(345, 254);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 13;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 114);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 14;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(348, 114);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 15;
            label7.Text = "label7";
            // 
            // Auction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 406);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(checkedListBox2);
            Controls.Add(CapitalP2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(AuctionCancel);
            Controls.Add(AuctionConfirm);
            Controls.Add(CapitalP1);
            Controls.Add(checkedListBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Location = new Point(750, 340);
            Name = "Auction";
            StartPosition = FormStartPosition.Manual;
            Text = "Auction";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private CheckedListBox checkedListBox1;
        private TextBox CapitalP1;
        private Button AuctionConfirm;
        private Button AuctionCancel;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private TextBox CapitalP2;
        private CheckedListBox checkedListBox2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}