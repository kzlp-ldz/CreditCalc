namespace CreditCalc
{
    partial class Calc
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_LoanAmount = new System.Windows.Forms.TextBox();
            this.tb_LoanTerm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_TotalPayout = new System.Windows.Forms.TextBox();
            this.tb_InterestAmount = new System.Windows.Forms.TextBox();
            this.tb_EffectiveRate = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сумма займа";
            // 
            // tb_LoanAmount
            // 
            this.tb_LoanAmount.Location = new System.Drawing.Point(129, 32);
            this.tb_LoanAmount.Name = "tb_LoanAmount";
            this.tb_LoanAmount.Size = new System.Drawing.Size(100, 20);
            this.tb_LoanAmount.TabIndex = 1;
            // 
            // tb_LoanTerm
            // 
            this.tb_LoanTerm.Location = new System.Drawing.Point(129, 75);
            this.tb_LoanTerm.Name = "tb_LoanTerm";
            this.tb_LoanTerm.Size = new System.Drawing.Size(100, 20);
            this.tb_LoanTerm.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Срок займа (дней)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Общая сумма выплаты";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(447, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Сумма процентов";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Эффективная ставка";
            // 
            // tb_TotalPayout
            // 
            this.tb_TotalPayout.Location = new System.Drawing.Point(590, 32);
            this.tb_TotalPayout.Name = "tb_TotalPayout";
            this.tb_TotalPayout.Size = new System.Drawing.Size(100, 20);
            this.tb_TotalPayout.TabIndex = 7;
            this.tb_TotalPayout.Visible = false;
            // 
            // tb_InterestAmount
            // 
            this.tb_InterestAmount.Location = new System.Drawing.Point(590, 75);
            this.tb_InterestAmount.Name = "tb_InterestAmount";
            this.tb_InterestAmount.Size = new System.Drawing.Size(100, 20);
            this.tb_InterestAmount.TabIndex = 8;
            this.tb_InterestAmount.Visible = false;
            // 
            // tb_EffectiveRate
            // 
            this.tb_EffectiveRate.Location = new System.Drawing.Point(590, 114);
            this.tb_EffectiveRate.Name = "tb_EffectiveRate";
            this.tb_EffectiveRate.Size = new System.Drawing.Size(100, 20);
            this.tb_EffectiveRate.TabIndex = 9;
            this.tb_EffectiveRate.Visible = false;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(26, 127);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(203, 23);
            this.btn_start.TabIndex = 10;
            this.btn_start.Text = "Вывести ";
            this.btn_start.UseVisualStyleBackColor = true;
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.tb_EffectiveRate);
            this.Controls.Add(this.tb_InterestAmount);
            this.Controls.Add(this.tb_TotalPayout);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_LoanTerm);
            this.Controls.Add(this.tb_LoanAmount);
            this.Controls.Add(this.label1);
            this.Name = "Calc";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_LoanAmount;
        private System.Windows.Forms.TextBox tb_LoanTerm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_TotalPayout;
        private System.Windows.Forms.TextBox tb_InterestAmount;
        private System.Windows.Forms.TextBox tb_EffectiveRate;
        private System.Windows.Forms.Button btn_start;
    }
}

