namespace Hotel_Interface
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // button1
            // 
            button1.Location = new Point(373, 99);
            button1.Name = "button1";
            button1.Size = new Size(199, 32);
            button1.TabIndex = 1;
            button1.Text = "Show all  Clients";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(373, 158);
            button2.Name = "button2";
            button2.Size = new Size(199, 31);
            button2.TabIndex = 2;
            button2.Text = "Get Client by id";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(373, 213);
            button3.Name = "button3";
            button3.Size = new Size(199, 32);
            button3.TabIndex = 3;
            button3.Text = "Get Client statistics";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(373, 271);
            button4.Name = "button4";
            button4.Size = new Size(199, 29);
            button4.TabIndex = 4;
            button4.Text = "Create new Client";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(373, 326);
            button5.Name = "button5";
            button5.Size = new Size(199, 35);
            button5.TabIndex = 5;
            button5.Text = "Update Client by id";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(373, 391);
            button6.Name = "button6";
            button6.Size = new Size(199, 35);
            button6.TabIndex = 6;
            button6.Text = "Delete Client by id";
            button6.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(318, 394);
            label6.Name = "label6";
            label6.Size = new Size(28, 32);
            label6.TabIndex = 12;
            label6.Text = "6";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(318, 329);
            label1.Name = "label1";
            label1.Size = new Size(28, 32);
            label1.TabIndex = 13;
            label1.Text = "5";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(318, 268);
            label2.Name = "label2";
            label2.Size = new Size(28, 32);
            label2.TabIndex = 14;
            label2.Text = "4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(318, 213);
            label3.Name = "label3";
            label3.Size = new Size(28, 32);
            label3.TabIndex = 15;
            label3.Text = "3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(318, 158);
            label4.Name = "label4";
            label4.Size = new Size(28, 32);
            label4.TabIndex = 16;
            label4.Text = "2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(318, 99);
            label5.Name = "label5";
            label5.Size = new Size(28, 32);
            label5.TabIndex = 17;
            label5.Text = "1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 529);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form2";
            Text = " ";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}