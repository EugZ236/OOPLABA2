namespace xmlGraduate
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            відкритиToolStripMenuItem = new ToolStripMenuItem();
            зберегтиToolStripMenuItem = new ToolStripMenuItem();
            richTextBox1 = new RichTextBox();
            linqButton = new RadioButton();
            domButton = new RadioButton();
            saxButton = new RadioButton();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            htmlButton = new Button();
            departamentComboBox = new ComboBox();
            faculcyComboBox = new ComboBox();
            nameComboBox = new ComboBox();
            button1 = new Button();
            label4 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(445, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { відкритиToolStripMenuItem, зберегтиToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // відкритиToolStripMenuItem
            // 
            відкритиToolStripMenuItem.Name = "відкритиToolStripMenuItem";
            відкритиToolStripMenuItem.Size = new Size(155, 26);
            відкритиToolStripMenuItem.Text = "Відкрити";
            відкритиToolStripMenuItem.Click += відкритиToolStripMenuItem_Click;
            // 
            // зберегтиToolStripMenuItem
            // 
            зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            зберегтиToolStripMenuItem.Size = new Size(155, 26);
            зберегтиToolStripMenuItem.Text = "Зберегти";
            зберегтиToolStripMenuItem.Click += зберегтиToolStripMenuItem_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.ForeColor = Color.ForestGreen;
            richTextBox1.Location = new Point(41, 37);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(285, 340);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // linqButton
            // 
            linqButton.AutoSize = true;
            linqButton.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linqButton.ForeColor = Color.Blue;
            linqButton.Location = new Point(334, 220);
            linqButton.Margin = new Padding(3, 4, 3, 4);
            linqButton.Name = "linqButton";
            linqButton.Size = new Size(60, 28);
            linqButton.TabIndex = 7;
            linqButton.TabStop = true;
            linqButton.Text = "LINQ";
            linqButton.UseVisualStyleBackColor = true;
            // 
            // domButton
            // 
            domButton.AutoSize = true;
            domButton.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            domButton.ForeColor = Color.Blue;
            domButton.Location = new Point(334, 187);
            domButton.Margin = new Padding(3, 4, 3, 4);
            domButton.Name = "domButton";
            domButton.Size = new Size(85, 28);
            domButton.TabIndex = 6;
            domButton.TabStop = true;
            domButton.Text = "DOM API";
            domButton.UseVisualStyleBackColor = true;
            // 
            // saxButton
            // 
            saxButton.AutoSize = true;
            saxButton.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            saxButton.ForeColor = Color.Blue;
            saxButton.Location = new Point(334, 153);
            saxButton.Margin = new Padding(3, 4, 3, 4);
            saxButton.Name = "saxButton";
            saxButton.Size = new Size(82, 28);
            saxButton.TabIndex = 5;
            saxButton.TabStop = true;
            saxButton.Text = "SAX API";
            saxButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(53, 716);
            label3.Name = "label3";
            label3.Size = new Size(96, 24);
            label3.TabIndex = 19;
            label3.Text = "Departament";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(70, 672);
            label2.Name = "label2";
            label2.Size = new Size(62, 24);
            label2.TabIndex = 18;
            label2.Text = "Faculcy";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(73, 625);
            label1.Name = "label1";
            label1.Size = new Size(48, 24);
            label1.TabIndex = 17;
            label1.Text = "Name";
            // 
            // htmlButton
            // 
            htmlButton.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            htmlButton.Location = new Point(41, 465);
            htmlButton.Margin = new Padding(3, 4, 3, 4);
            htmlButton.Name = "htmlButton";
            htmlButton.Size = new Size(286, 76);
            htmlButton.TabIndex = 16;
            htmlButton.Text = "save to html";
            htmlButton.UseVisualStyleBackColor = true;
            htmlButton.Click += htmlButton_Click;
            // 
            // departamentComboBox
            // 
            departamentComboBox.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            departamentComboBox.FormattingEnabled = true;
            departamentComboBox.Location = new Point(146, 709);
            departamentComboBox.Margin = new Padding(3, 4, 3, 4);
            departamentComboBox.Name = "departamentComboBox";
            departamentComboBox.Size = new Size(180, 32);
            departamentComboBox.TabIndex = 15;
            departamentComboBox.SelectedIndexChanged += departamentComboBox_SelectedIndexChanged;
            // 
            // faculcyComboBox
            // 
            faculcyComboBox.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            faculcyComboBox.FormattingEnabled = true;
            faculcyComboBox.Location = new Point(146, 665);
            faculcyComboBox.Margin = new Padding(3, 4, 3, 4);
            faculcyComboBox.Name = "faculcyComboBox";
            faculcyComboBox.Size = new Size(180, 32);
            faculcyComboBox.TabIndex = 14;
            faculcyComboBox.SelectedIndexChanged += faculcyComboBox_SelectedIndexChanged;
            // 
            // nameComboBox
            // 
            nameComboBox.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameComboBox.FormattingEnabled = true;
            nameComboBox.Location = new Point(146, 621);
            nameComboBox.Margin = new Padding(3, 4, 3, 4);
            nameComboBox.Name = "nameComboBox";
            nameComboBox.Size = new Size(180, 32);
            nameComboBox.TabIndex = 13;
            nameComboBox.SelectedIndexChanged += nameComboBox_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(41, 387);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(286, 76);
            button1.TabIndex = 20;
            button1.Text = "Reset all";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(146, 567);
            label4.Name = "label4";
            label4.Size = new Size(99, 36);
            label4.TabIndex = 21;
            label4.Text = "Filtering";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 761);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(htmlButton);
            Controls.Add(departamentComboBox);
            Controls.Add(faculcyComboBox);
            Controls.Add(nameComboBox);
            Controls.Add(linqButton);
            Controls.Add(domButton);
            Controls.Add(saxButton);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Lab2";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem відкритиToolStripMenuItem;
        private ToolStripMenuItem зберегтиToolStripMenuItem;
        private RichTextBox richTextBox1;
        private RadioButton linqButton;
        private RadioButton domButton;
        private RadioButton saxButton;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button htmlButton;
        private ComboBox departamentComboBox;
        private ComboBox faculcyComboBox;
        private ComboBox nameComboBox;
        private Button button1;
        private Label label4;
    }
}