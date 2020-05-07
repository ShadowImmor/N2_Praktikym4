namespace Задание_2_г
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
            this.Flabel = new System.Windows.Forms.Label();
            this.Diflabel = new System.Windows.Forms.Label();
            this.Nlabel = new System.Windows.Forms.Label();
            this.F = new System.Windows.Forms.NumericUpDown();
            this.Dif = new System.Windows.Forms.NumericUpDown();
            this.N = new System.Windows.Forms.NumericUpDown();
            this.ReaslNlabel = new System.Windows.Forms.Label();
            this.ReslSumlabel = new System.Windows.Forms.Label();
            this.ReslN = new System.Windows.Forms.TextBox();
            this.ReslSum = new System.Windows.Forms.TextBox();
            this.Rasbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.F)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N)).BeginInit();
            this.SuspendLayout();
            // 
            // Flabel
            // 
            this.Flabel.AutoSize = true;
            this.Flabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Flabel.Location = new System.Drawing.Point(26, 13);
            this.Flabel.Name = "Flabel";
            this.Flabel.Size = new System.Drawing.Size(501, 28);
            this.Flabel.TabIndex = 0;
            this.Flabel.Text = "Первый член арифметической прогрессии";
            // 
            // Diflabel
            // 
            this.Diflabel.AutoSize = true;
            this.Diflabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Diflabel.Location = new System.Drawing.Point(26, 61);
            this.Diflabel.Name = "Diflabel";
            this.Diflabel.Size = new System.Drawing.Size(450, 28);
            this.Diflabel.TabIndex = 1;
            this.Diflabel.Text = "Разность арифметической прогрессии";
            // 
            // Nlabel
            // 
            this.Nlabel.AutoSize = true;
            this.Nlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nlabel.Location = new System.Drawing.Point(26, 112);
            this.Nlabel.Name = "Nlabel";
            this.Nlabel.Size = new System.Drawing.Size(670, 28);
            this.Nlabel.TabIndex = 2;
            this.Nlabel.Text = "Порядковый номер члена арифметической прогрессии, n";
            // 
            // F
            // 
            this.F.DecimalPlaces = 5;
            this.F.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.F.Location = new System.Drawing.Point(727, 12);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(120, 36);
            this.F.TabIndex = 3;
            // 
            // Dif
            // 
            this.Dif.DecimalPlaces = 5;
            this.Dif.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dif.Location = new System.Drawing.Point(727, 59);
            this.Dif.Name = "Dif";
            this.Dif.Size = new System.Drawing.Size(120, 36);
            this.Dif.TabIndex = 4;
            // 
            // N
            // 
            this.N.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.N.Location = new System.Drawing.Point(727, 110);
            this.N.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(120, 36);
            this.N.TabIndex = 5;
            this.N.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ReaslNlabel
            // 
            this.ReaslNlabel.AutoSize = true;
            this.ReaslNlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReaslNlabel.Location = new System.Drawing.Point(26, 247);
            this.ReaslNlabel.Name = "ReaslNlabel";
            this.ReaslNlabel.Size = new System.Drawing.Size(396, 28);
            this.ReaslNlabel.TabIndex = 6;
            this.ReaslNlabel.Text = "Значение этого члена прогрессии";
            // 
            // ReslSumlabel
            // 
            this.ReslSumlabel.AutoSize = true;
            this.ReslSumlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReslSumlabel.Location = new System.Drawing.Point(26, 301);
            this.ReslSumlabel.Name = "ReslSumlabel";
            this.ReslSumlabel.Size = new System.Drawing.Size(419, 28);
            this.ReslSumlabel.TabIndex = 7;
            this.ReslSumlabel.Text = "Сумма первых n членов прогрессии";
            // 
            // ReslN
            // 
            this.ReslN.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReslN.Location = new System.Drawing.Point(727, 244);
            this.ReslN.Name = "ReslN";
            this.ReslN.ReadOnly = true;
            this.ReslN.Size = new System.Drawing.Size(120, 36);
            this.ReslN.TabIndex = 8;
            // 
            // ReslSum
            // 
            this.ReslSum.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReslSum.Location = new System.Drawing.Point(727, 298);
            this.ReslSum.Name = "ReslSum";
            this.ReslSum.ReadOnly = true;
            this.ReslSum.Size = new System.Drawing.Size(120, 36);
            this.ReslSum.TabIndex = 9;
            // 
            // Rasbutton
            // 
            this.Rasbutton.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rasbutton.Location = new System.Drawing.Point(346, 166);
            this.Rasbutton.Name = "Rasbutton";
            this.Rasbutton.Size = new System.Drawing.Size(181, 50);
            this.Rasbutton.TabIndex = 10;
            this.Rasbutton.Text = "Рассчитать";
            this.Rasbutton.UseVisualStyleBackColor = true;
            this.Rasbutton.Click += new System.EventHandler(this.Rasbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 366);
            this.Controls.Add(this.Rasbutton);
            this.Controls.Add(this.ReslSum);
            this.Controls.Add(this.ReslN);
            this.Controls.Add(this.ReslSumlabel);
            this.Controls.Add(this.ReaslNlabel);
            this.Controls.Add(this.N);
            this.Controls.Add(this.Dif);
            this.Controls.Add(this.F);
            this.Controls.Add(this.Nlabel);
            this.Controls.Add(this.Diflabel);
            this.Controls.Add(this.Flabel);
            this.Name = "Form1";
            this.Text = "Задание 2";
            ((System.ComponentModel.ISupportInitialize)(this.F)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Flabel;
        private System.Windows.Forms.Label Diflabel;
        private System.Windows.Forms.Label Nlabel;
        private System.Windows.Forms.NumericUpDown F;
        private System.Windows.Forms.NumericUpDown Dif;
        private System.Windows.Forms.NumericUpDown N;
        private System.Windows.Forms.Label ReaslNlabel;
        private System.Windows.Forms.Label ReslSumlabel;
        private System.Windows.Forms.TextBox ReslN;
        private System.Windows.Forms.TextBox ReslSum;
        private System.Windows.Forms.Button Rasbutton;
    }
}

