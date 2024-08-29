namespace Lab1
{
    partial class BookSales
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            calculateToolStripMenuItem = new ToolStripMenuItem();
            summaryToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            checkStudent = new CheckBox();
            checkDiscount = new CheckBox();
            label6 = new Label();
            txtNetDue = new TextBox();
            label5 = new Label();
            txtDiscount = new TextBox();
            label4 = new Label();
            txtExtended = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            txtTitle = new TextBox();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, calculateToolStripMenuItem, summaryToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(125, 22);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // calculateToolStripMenuItem
            // 
            calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            calculateToolStripMenuItem.Size = new Size(125, 22);
            calculateToolStripMenuItem.Text = "Calculate";
            calculateToolStripMenuItem.Click += calculateToolStripMenuItem_Click;
            // 
            // summaryToolStripMenuItem
            // 
            summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            summaryToolStripMenuItem.Size = new Size(125, 22);
            summaryToolStripMenuItem.Text = "Summary";
            summaryToolStripMenuItem.Click += summaryToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(125, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkStudent);
            groupBox1.Controls.Add(checkDiscount);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtNetDue);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtDiscount);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtExtended);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(txtTitle);
            groupBox1.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(144, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(534, 354);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Book Information";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // checkStudent
            // 
            checkStudent.AutoSize = true;
            checkStudent.Location = new Point(370, 306);
            checkStudent.Name = "checkStudent";
            checkStudent.Size = new Size(113, 19);
            checkStudent.TabIndex = 13;
            checkStudent.Text = "Distinct Student";
            checkStudent.UseVisualStyleBackColor = true;
            // 
            // checkDiscount
            // 
            checkDiscount.AutoSize = true;
            checkDiscount.Location = new Point(370, 258);
            checkDiscount.Name = "checkDiscount";
            checkDiscount.Size = new Size(116, 19);
            checkDiscount.TabIndex = 12;
            checkDiscount.Text = "Normal Discount";
            checkDiscount.UseVisualStyleBackColor = true;
            checkDiscount.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.WindowText;
            label6.Location = new Point(32, 308);
            label6.Name = "label6";
            label6.Size = new Size(55, 17);
            label6.TabIndex = 11;
            label6.Text = "NetDue";
            // 
            // txtNetDue
            // 
            txtNetDue.Enabled = false;
            txtNetDue.Location = new Point(160, 306);
            txtNetDue.Name = "txtNetDue";
            txtNetDue.ReadOnly = true;
            txtNetDue.Size = new Size(166, 22);
            txtNetDue.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.WindowText;
            label5.Location = new Point(32, 257);
            label5.Name = "label5";
            label5.Size = new Size(60, 17);
            label5.TabIndex = 9;
            label5.Text = "Discount";
            // 
            // txtDiscount
            // 
            txtDiscount.Enabled = false;
            txtDiscount.Location = new Point(160, 255);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.ReadOnly = true;
            txtDiscount.Size = new Size(166, 22);
            txtDiscount.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.WindowText;
            label4.Location = new Point(32, 205);
            label4.Name = "label4";
            label4.Size = new Size(98, 17);
            label4.TabIndex = 7;
            label4.Text = "Extended Price";
            // 
            // txtExtended
            // 
            txtExtended.Enabled = false;
            txtExtended.Location = new Point(160, 203);
            txtExtended.Name = "txtExtended";
            txtExtended.ReadOnly = true;
            txtExtended.ShortcutsEnabled = false;
            txtExtended.Size = new Size(166, 22);
            txtExtended.TabIndex = 6;
            txtExtended.TextChanged += txtExtended_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.WindowText;
            label3.Location = new Point(32, 154);
            label3.Name = "label3";
            label3.Size = new Size(39, 17);
            label3.TabIndex = 5;
            label3.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.WindowText;
            label2.Location = new Point(32, 101);
            label2.Name = "label2";
            label2.Size = new Size(58, 17);
            label2.TabIndex = 4;
            label2.Text = "Quantity";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(32, 48);
            label1.Name = "label1";
            label1.Size = new Size(33, 17);
            label1.TabIndex = 3;
            label1.Text = "Title";
            label1.Click += label1_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(160, 152);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(166, 22);
            txtPrice.TabIndex = 2;
            // 
            // txtQuantity
            // 
            txtQuantity.AccessibleName = "";
            txtQuantity.Location = new Point(160, 99);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(166, 22);
            txtQuantity.TabIndex = 1;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(160, 46);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(326, 22);
            txtTitle.TabIndex = 0;
            // 
            // BookSales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 445);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "BookSales";
            Text = "BookSales";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private TextBox txtTitle;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox txtExtended;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem calculateToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem summaryToolStripMenuItem;
        private Label label5;
        private TextBox txtDiscount;
        private Label label6;
        private TextBox txtNetDue;
        private CheckBox checkDiscount;
        private CheckBox checkStudent;
    }
}