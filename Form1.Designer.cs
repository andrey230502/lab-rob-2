
namespace lab_rob_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.HEX = new System.Windows.Forms.Label();
            this.DEC = new System.Windows.Forms.Label();
            this.OCT = new System.Windows.Forms.Label();
            this.BIN = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_OCT = new System.Windows.Forms.TextBox();
            this.textBox_HEX = new System.Windows.Forms.TextBox();
            this.textBox_DEC = new System.Windows.Forms.TextBox();
            this.textBox_BIN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HEX
            // 
            this.HEX.AutoSize = true;
            this.HEX.Location = new System.Drawing.Point(349, 67);
            this.HEX.Name = "HEX";
            this.HEX.Size = new System.Drawing.Size(29, 13);
            this.HEX.TabIndex = 0;
            this.HEX.Text = "HEX";
            // 
            // DEC
            // 
            this.DEC.AutoSize = true;
            this.DEC.Location = new System.Drawing.Point(349, 101);
            this.DEC.Name = "DEC";
            this.DEC.Size = new System.Drawing.Size(29, 13);
            this.DEC.TabIndex = 1;
            this.DEC.Text = "DEC";
            this.DEC.Click += new System.EventHandler(this.label2_Click);
            // 
            // OCT
            // 
            this.OCT.AutoSize = true;
            this.OCT.Location = new System.Drawing.Point(349, 133);
            this.OCT.Name = "OCT";
            this.OCT.Size = new System.Drawing.Size(29, 13);
            this.OCT.TabIndex = 2;
            this.OCT.Text = "OCT";
            this.OCT.Click += new System.EventHandler(this.label3_Click);
            // 
            // BIN
            // 
            this.BIN.AutoSize = true;
            this.BIN.Location = new System.Drawing.Point(349, 165);
            this.BIN.Name = "BIN";
            this.BIN.Size = new System.Drawing.Size(25, 13);
            this.BIN.TabIndex = 3;
            this.BIN.Text = "BIN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "HEX";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "DEC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "OCT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(94, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "BIN";
            // 
            // textBox_OCT
            // 
            this.textBox_OCT.Location = new System.Drawing.Point(152, 130);
            this.textBox_OCT.Name = "textBox_OCT";
            this.textBox_OCT.Size = new System.Drawing.Size(139, 20);
            this.textBox_OCT.TabIndex = 8;
            this.textBox_OCT.TextChanged += new System.EventHandler(this.textBox_ALL_TextChanged);
            // 
            // textBox_HEX
            // 
            this.textBox_HEX.Location = new System.Drawing.Point(152, 67);
            this.textBox_HEX.Name = "textBox_HEX";
            this.textBox_HEX.Size = new System.Drawing.Size(139, 20);
            this.textBox_HEX.TabIndex = 9;
            this.textBox_HEX.TextChanged += new System.EventHandler(this.textBox_ALL_TextChanged);
            // 
            // textBox_DEC
            // 
            this.textBox_DEC.Location = new System.Drawing.Point(152, 101);
            this.textBox_DEC.Name = "textBox_DEC";
            this.textBox_DEC.Size = new System.Drawing.Size(139, 20);
            this.textBox_DEC.TabIndex = 10;
            this.textBox_DEC.TextChanged += new System.EventHandler(this.textBox_ALL_TextChanged);
            // 
            // textBox_BIN
            // 
            this.textBox_BIN.Location = new System.Drawing.Point(152, 158);
            this.textBox_BIN.Name = "textBox_BIN";
            this.textBox_BIN.Size = new System.Drawing.Size(139, 20);
            this.textBox_BIN.TabIndex = 11;
            this.textBox_BIN.TextChanged += new System.EventHandler(this.textBox_ALL_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_BIN);
            this.Controls.Add(this.textBox_DEC);
            this.Controls.Add(this.textBox_HEX);
            this.Controls.Add(this.textBox_OCT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BIN);
            this.Controls.Add(this.OCT);
            this.Controls.Add(this.DEC);
            this.Controls.Add(this.HEX);
            this.Name = "Form1";
            this.Text = "Form 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HEX;
        private System.Windows.Forms.Label DEC;
        private System.Windows.Forms.Label OCT;
        private System.Windows.Forms.Label BIN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_OCT;
        private System.Windows.Forms.TextBox textBox_HEX;
        private System.Windows.Forms.TextBox textBox_DEC;
        private System.Windows.Forms.TextBox textBox_BIN;
    }
}

