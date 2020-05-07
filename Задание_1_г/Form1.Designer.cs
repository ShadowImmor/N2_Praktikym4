namespace Задание_1_г
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
            this.Nlabel = new System.Windows.Forms.Label();
            this.Reslabel = new System.Windows.Forms.Label();
            this.N = new System.Windows.Forms.NumericUpDown();
            this.Res = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.N)).BeginInit();
            this.SuspendLayout();
            // 
            // Nlabel
            // 
            this.Nlabel.AutoSize = true;
            this.Nlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nlabel.Location = new System.Drawing.Point(12, 18);
            this.Nlabel.Name = "Nlabel";
            this.Nlabel.Size = new System.Drawing.Size(542, 28);
            this.Nlabel.TabIndex = 0;
            this.Nlabel.Text = "Порядковый номер члена последовательнотси";
            // 
            // Reslabel
            // 
            this.Reslabel.AutoSize = true;
            this.Reslabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reslabel.Location = new System.Drawing.Point(12, 71);
            this.Reslabel.Name = "Reslabel";
            this.Reslabel.Size = new System.Drawing.Size(495, 28);
            this.Reslabel.TabIndex = 1;
            this.Reslabel.Text = "Значение этого члена последовательности";
            // 
            // N
            // 
            this.N.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.N.Location = new System.Drawing.Point(591, 16);
            this.N.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(120, 36);
            this.N.TabIndex = 2;
            this.N.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.N.ValueChanged += new System.EventHandler(this.N_ValueChanged);
            // 
            // Res
            // 
            this.Res.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Res.Location = new System.Drawing.Point(591, 68);
            this.Res.Name = "Res";
            this.Res.ReadOnly = true;
            this.Res.Size = new System.Drawing.Size(120, 36);
            this.Res.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 130);
            this.Controls.Add(this.Res);
            this.Controls.Add(this.N);
            this.Controls.Add(this.Reslabel);
            this.Controls.Add(this.Nlabel);
            this.Name = "Form1";
            this.Text = "Задание 1";
            ((System.ComponentModel.ISupportInitialize)(this.N)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nlabel;
        private System.Windows.Forms.Label Reslabel;
        private System.Windows.Forms.NumericUpDown N;
        private System.Windows.Forms.TextBox Res;
    }
}

