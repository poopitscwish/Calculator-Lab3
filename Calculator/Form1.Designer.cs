
namespace Calculator
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
            this.real2 = new System.Windows.Forms.TextBox();
            this.imagine2 = new System.Windows.Forms.TextBox();
            this.imagine1 = new System.Windows.Forms.TextBox();
            this.real1 = new System.Windows.Forms.TextBox();
            this.operation = new System.Windows.Forms.ComboBox();
            this.answer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // real2
            // 
            this.real2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.real2.Location = new System.Drawing.Point(60, 105);
            this.real2.Name = "real2";
            this.real2.Size = new System.Drawing.Size(150, 28);
            this.real2.TabIndex = 8;
            this.real2.Text = "5";
            this.real2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.real2.TextChanged += new System.EventHandler(this.real2_TextChanged);
            // 
            // imagine2
            // 
            this.imagine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imagine2.Location = new System.Drawing.Point(320, 105);
            this.imagine2.Name = "imagine2";
            this.imagine2.Size = new System.Drawing.Size(150, 28);
            this.imagine2.TabIndex = 7;
            this.imagine2.Text = "-7";
            this.imagine2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.imagine2.TextChanged += new System.EventHandler(this.imagine2_TextChanged);
            // 
            // imagine1
            // 
            this.imagine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imagine1.Location = new System.Drawing.Point(320, 33);
            this.imagine1.Name = "imagine1";
            this.imagine1.Size = new System.Drawing.Size(150, 28);
            this.imagine1.TabIndex = 6;
            this.imagine1.Text = "3";
            this.imagine1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.imagine1.TextChanged += new System.EventHandler(this.imagine1_TextChanged);
            // 
            // real1
            // 
            this.real1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.real1.Location = new System.Drawing.Point(60, 33);
            this.real1.Name = "real1";
            this.real1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.real1.Size = new System.Drawing.Size(150, 28);
            this.real1.TabIndex = 5;
            this.real1.Text = "2";
            this.real1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.real1.TextChanged += new System.EventHandler(this.real1_TextChanged);
            // 
            // operation
            // 
            this.operation.CausesValidation = false;
            this.operation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.operation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operation.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "<,>,=?"});
            this.operation.Location = new System.Drawing.Point(213, 71);
            this.operation.Name = "operation";
            this.operation.Size = new System.Drawing.Size(100, 30);
            this.operation.TabIndex = 10;
            this.operation.Text = "+";
            this.operation.SelectedIndexChanged += new System.EventHandler(this.operation_SelectedIndexChanged);
            // 
            // answer
            // 
            this.answer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer.Location = new System.Drawing.Point(60, 176);
            this.answer.Name = "answer";
            this.answer.ReadOnly = true;
            this.answer.Size = new System.Drawing.Size(410, 28);
            this.answer.TabIndex = 11;
            this.answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(57, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Действительная часть";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(317, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Мнимая часть";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 35);
            this.label3.MinimumSize = new System.Drawing.Size(0, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Z1 =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 107);
            this.label4.MinimumSize = new System.Drawing.Size(0, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Z2 =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(229, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ответ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(220, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Операции";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(505, 226);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.operation);
            this.Controls.Add(this.real2);
            this.Controls.Add(this.imagine2);
            this.Controls.Add(this.imagine1);
            this.Controls.Add(this.real1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор комплексных чисел";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox real2;
        private System.Windows.Forms.TextBox imagine2;
        private System.Windows.Forms.TextBox imagine1;
        private System.Windows.Forms.TextBox real1;
        private System.Windows.Forms.ComboBox operation;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

