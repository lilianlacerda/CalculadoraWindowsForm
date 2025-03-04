namespace CalculadoraWindowsForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            button6 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(45, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(221, 50);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(45, 148);
            button1.Name = "button1";
            button1.Size = new Size(125, 29);
            button1.TabIndex = 2;
            button1.Text = "Soma";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnSoma_Click;
            // 
            // button2
            // 
            button2.Location = new Point(221, 148);
            button2.Name = "button2";
            button2.Size = new Size(125, 29);
            button2.TabIndex = 3;
            button2.Text = "Subtração";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnSubtracao_Click;
            // 
            // button3
            // 
            button3.Location = new Point(45, 217);
            button3.Name = "button3";
            button3.Size = new Size(125, 29);
            button3.TabIndex = 4;
            button3.Text = "Multiplicação";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnMultiplicacao_Click;
            // 
            // button4
            // 
            button4.Location = new Point(221, 217);
            button4.Name = "button4";
            button4.Size = new Size(125, 29);
            button4.TabIndex = 5;
            button4.Text = "Divisão";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnDivisao_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(158, 99);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 6;
            label1.Text = "Resultado";
            // 
            // button6
            // 
            button6.Location = new Point(134, 275);
            button6.Name = "button6";
            button6.Size = new Size(125, 29);
            button6.TabIndex = 8;
            button6.Text = "C";
            button6.UseVisualStyleBackColor = true;
            button6.Click += resetarCalculo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 329);
            Controls.Add(button6);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Button button6;
    }
}
