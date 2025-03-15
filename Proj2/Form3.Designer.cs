namespace Proj2
{
    partial class Form3
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
            listBox2 = new ListBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(12, 12);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(234, 184);
            listBox2.TabIndex = 10;
            listBox2.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(80, 202);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 9;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 209);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 8;
            label3.Text = "Cena";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(211, 209);
            label4.Name = "label4";
            label4.Size = new Size(20, 20);
            label4.TabIndex = 11;
            label4.Text = "zł";
            // 
            // button2
            // 
            button2.Location = new Point(145, 248);
            button2.Name = "button2";
            button2.Size = new Size(112, 35);
            button2.TabIndex = 13;
            button2.Text = "ANULUJ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 248);
            button1.Name = "button1";
            button1.Size = new Size(111, 35);
            button1.TabIndex = 12;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 288);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(listBox2);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Name = "Form3";
            Text = "Monitor";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Button button2;
        private Button button1;
    }
}