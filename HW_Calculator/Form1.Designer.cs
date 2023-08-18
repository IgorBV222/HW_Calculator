namespace HW_Calculator
{
    partial class Form_calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_calculator));
            this.label_input = new System.Windows.Forms.Label();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.btn_percent = new System.Windows.Forms.Button();
            this.btn_exponentiation = new System.Windows.Forms.Button();
            this.btn_equals = new System.Windows.Forms.Button();
            this.btn_plus_minus = new System.Windows.Forms.Button();
            this.btn_comma = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_erase = new System.Windows.Forms.Button();
            this.label_output = new System.Windows.Forms.Label();
            this.but_save_res = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label_input
            // 
            this.label_input.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_input.ForeColor = System.Drawing.Color.White;
            this.label_input.Location = new System.Drawing.Point(12, 43);
            this.label_input.Name = "label_input";
            this.label_input.Size = new System.Drawing.Size(400, 32);
            this.label_input.TabIndex = 0;
            this.label_input.Text = "0";
            this.label_input.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.Gray;
            this.btn_1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_1.Location = new System.Drawing.Point(12, 214);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(95, 35);
            this.btn_1.TabIndex = 2;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.BtnNumb_Click);
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.Color.Gray;
            this.btn_0.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_0.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_0.Location = new System.Drawing.Point(113, 255);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(95, 35);
            this.btn_0.TabIndex = 2;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = false;
            this.btn_0.Click += new System.EventHandler(this.BtnNumb_Click);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.Gray;
            this.btn_2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_2.Location = new System.Drawing.Point(113, 214);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(95, 35);
            this.btn_2.TabIndex = 2;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.BtnNumb_Click);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.Gray;
            this.btn_3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_3.Location = new System.Drawing.Point(214, 214);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(95, 35);
            this.btn_3.TabIndex = 2;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.BtnNumb_Click);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.Color.Gray;
            this.btn_4.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_4.Location = new System.Drawing.Point(12, 173);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(95, 35);
            this.btn_4.TabIndex = 2;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.BtnNumb_Click);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.Color.Gray;
            this.btn_5.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_5.Location = new System.Drawing.Point(113, 173);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(95, 35);
            this.btn_5.TabIndex = 2;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.BtnNumb_Click);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.Color.Gray;
            this.btn_6.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_6.Location = new System.Drawing.Point(214, 173);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(95, 35);
            this.btn_6.TabIndex = 2;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.BtnNumb_Click);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.Color.Gray;
            this.btn_7.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_7.Location = new System.Drawing.Point(12, 132);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(95, 35);
            this.btn_7.TabIndex = 2;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.BtnNumb_Click);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.Color.Gray;
            this.btn_8.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_8.Location = new System.Drawing.Point(113, 132);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(95, 35);
            this.btn_8.TabIndex = 2;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.BtnNumb_Click);
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.Color.Gray;
            this.btn_9.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_9.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_9.Location = new System.Drawing.Point(214, 132);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(95, 35);
            this.btn_9.TabIndex = 2;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.BtnNumb_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_plus.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_plus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_plus.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_plus.Location = new System.Drawing.Point(317, 255);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(95, 35);
            this.btn_plus.TabIndex = 2;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = false;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_minus.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_minus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_minus.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_minus.Location = new System.Drawing.Point(317, 214);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(95, 35);
            this.btn_minus.TabIndex = 2;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = false;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_divide
            // 
            this.btn_divide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_divide.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_divide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_divide.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_divide.Location = new System.Drawing.Point(317, 173);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(95, 35);
            this.btn_divide.TabIndex = 2;
            this.btn_divide.Text = "÷";
            this.btn_divide.UseVisualStyleBackColor = false;
            this.btn_divide.Click += new System.EventHandler(this.btn_divide_Click);
            // 
            // btn_multiply
            // 
            this.btn_multiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_multiply.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_multiply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_multiply.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_multiply.Location = new System.Drawing.Point(317, 132);
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.Size = new System.Drawing.Size(95, 35);
            this.btn_multiply.TabIndex = 2;
            this.btn_multiply.Text = "x";
            this.btn_multiply.UseVisualStyleBackColor = false;
            this.btn_multiply.Click += new System.EventHandler(this.btn_multiply_Click);
            // 
            // btn_percent
            // 
            this.btn_percent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_percent.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_percent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_percent.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_percent.Location = new System.Drawing.Point(317, 91);
            this.btn_percent.Name = "btn_percent";
            this.btn_percent.Size = new System.Drawing.Size(95, 35);
            this.btn_percent.TabIndex = 2;
            this.btn_percent.Text = "%";
            this.btn_percent.UseVisualStyleBackColor = false;
            this.btn_percent.Click += new System.EventHandler(this.btn_percent_Click);
            // 
            // btn_exponentiation
            // 
            this.btn_exponentiation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_exponentiation.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_exponentiation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exponentiation.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_exponentiation.Location = new System.Drawing.Point(214, 91);
            this.btn_exponentiation.Name = "btn_exponentiation";
            this.btn_exponentiation.Size = new System.Drawing.Size(95, 35);
            this.btn_exponentiation.TabIndex = 2;
            this.btn_exponentiation.Text = "x^y";
            this.btn_exponentiation.UseVisualStyleBackColor = false;
            this.btn_exponentiation.Click += new System.EventHandler(this.btn_exponentiation_Click);
            // 
            // btn_equals
            // 
            this.btn_equals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_equals.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_equals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_equals.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_equals.Location = new System.Drawing.Point(12, 296);
            this.btn_equals.Name = "btn_equals";
            this.btn_equals.Size = new System.Drawing.Size(400, 35);
            this.btn_equals.TabIndex = 2;
            this.btn_equals.Text = "=";
            this.btn_equals.UseVisualStyleBackColor = false;
            this.btn_equals.Click += new System.EventHandler(this.btn_equals_Click);
            // 
            // btn_plus_minus
            // 
            this.btn_plus_minus.BackColor = System.Drawing.Color.Gray;
            this.btn_plus_minus.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_plus_minus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_plus_minus.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_plus_minus.Location = new System.Drawing.Point(12, 255);
            this.btn_plus_minus.Name = "btn_plus_minus";
            this.btn_plus_minus.Size = new System.Drawing.Size(95, 35);
            this.btn_plus_minus.TabIndex = 2;
            this.btn_plus_minus.Text = "+/-";
            this.btn_plus_minus.UseVisualStyleBackColor = false;
            this.btn_plus_minus.Click += new System.EventHandler(this.btn_plus_minus_Click);
            // 
            // btn_comma
            // 
            this.btn_comma.BackColor = System.Drawing.Color.Gray;
            this.btn_comma.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_comma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_comma.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_comma.Location = new System.Drawing.Point(216, 255);
            this.btn_comma.Name = "btn_comma";
            this.btn_comma.Size = new System.Drawing.Size(95, 35);
            this.btn_comma.TabIndex = 2;
            this.btn_comma.Text = ",";
            this.btn_comma.UseVisualStyleBackColor = false;
            this.btn_comma.Click += new System.EventHandler(this.btn_comma_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Red;
            this.btn_clear.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clear.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_clear.Location = new System.Drawing.Point(12, 91);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(95, 35);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "С";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_erase
            // 
            this.btn_erase.BackColor = System.Drawing.Color.Red;
            this.btn_erase.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_erase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_erase.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_erase.Location = new System.Drawing.Point(113, 91);
            this.btn_erase.Name = "btn_erase";
            this.btn_erase.Size = new System.Drawing.Size(95, 35);
            this.btn_erase.TabIndex = 2;
            this.btn_erase.Text = "<—";
            this.btn_erase.UseVisualStyleBackColor = false;
            this.btn_erase.Click += new System.EventHandler(this.btn_erase_Click);
            // 
            // label_output
            // 
            this.label_output.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_output.ForeColor = System.Drawing.Color.LightGray;
            this.label_output.Location = new System.Drawing.Point(12, 9);
            this.label_output.Name = "label_output";
            this.label_output.Size = new System.Drawing.Size(400, 32);
            this.label_output.TabIndex = 0;
            this.label_output.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // but_save_res
            // 
            this.but_save_res.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.but_save_res.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.but_save_res.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_save_res.ForeColor = System.Drawing.Color.Black;
            this.but_save_res.Location = new System.Drawing.Point(466, 296);
            this.but_save_res.Name = "but_save_res";
            this.but_save_res.Size = new System.Drawing.Size(155, 35);
            this.but_save_res.TabIndex = 3;
            this.but_save_res.Text = "Сохранить результат";
            this.but_save_res.UseVisualStyleBackColor = false;
            this.but_save_res.Click += new System.EventHandler(this.but_save_res_Click);
            // 
            // Form_calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.but_save_res);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_percent);
            this.Controls.Add(this.btn_erase);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_multiply);
            this.Controls.Add(this.btn_equals);
            this.Controls.Add(this.btn_exponentiation);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_comma);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_plus_minus);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.label_output);
            this.Controls.Add(this.label_input);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_input;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btn_multiply;
        private System.Windows.Forms.Button btn_percent;
        private System.Windows.Forms.Button btn_exponentiation;
        private System.Windows.Forms.Button btn_equals;
        private System.Windows.Forms.Button btn_plus_minus;
        private System.Windows.Forms.Button btn_comma;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_erase;
        private System.Windows.Forms.Label label_output;
        private System.Windows.Forms.Button but_save_res;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

