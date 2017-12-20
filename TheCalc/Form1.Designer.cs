namespace TheCalc
{
    partial class TheCalc
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnSlash = new System.Windows.Forms.Button();
            this.btnTimes = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnPrClose = new System.Windows.Forms.Button();
            this.btnPrOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.SystemColors.Info;
            this.txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDisplay.Enabled = false;
            this.txtDisplay.Font = new System.Drawing.Font("Courier New", 21.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(1, 2);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(289, 46);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.TabStop = false;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextChanged += new System.EventHandler(this.txtDisplay_TextChanged);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn0.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn0.Location = new System.Drawing.Point(65, 225);
            this.btn0.Margin = new System.Windows.Forms.Padding(0);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(65, 45);
            this.btn0.TabIndex = 1;
            this.btn0.TabStop = false;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.Number);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn1.Location = new System.Drawing.Point(1, 181);
            this.btn1.Margin = new System.Windows.Forms.Padding(0);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(65, 45);
            this.btn1.TabIndex = 2;
            this.btn1.TabStop = false;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.Number);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn2.Location = new System.Drawing.Point(65, 181);
            this.btn2.Margin = new System.Windows.Forms.Padding(0);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(65, 45);
            this.btn2.TabIndex = 3;
            this.btn2.TabStop = false;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.Number);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn3.Location = new System.Drawing.Point(129, 181);
            this.btn3.Margin = new System.Windows.Forms.Padding(0);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(65, 45);
            this.btn3.TabIndex = 4;
            this.btn3.TabStop = false;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.Number);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDot.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDot.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnDot.Location = new System.Drawing.Point(129, 225);
            this.btnDot.Margin = new System.Windows.Forms.Padding(0);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(65, 45);
            this.btnDot.TabIndex = 5;
            this.btnDot.TabStop = false;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.Number);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn4.Location = new System.Drawing.Point(1, 137);
            this.btn4.Margin = new System.Windows.Forms.Padding(0);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(65, 45);
            this.btn4.TabIndex = 6;
            this.btn4.TabStop = false;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.Number);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn5.Location = new System.Drawing.Point(65, 137);
            this.btn5.Margin = new System.Windows.Forms.Padding(0);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(65, 45);
            this.btn5.TabIndex = 7;
            this.btn5.TabStop = false;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.Number);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn6.Location = new System.Drawing.Point(129, 137);
            this.btn6.Margin = new System.Windows.Forms.Padding(0);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(65, 45);
            this.btn6.TabIndex = 8;
            this.btn6.TabStop = false;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.Number);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn9.Location = new System.Drawing.Point(129, 93);
            this.btn9.Margin = new System.Windows.Forms.Padding(0);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(65, 45);
            this.btn9.TabIndex = 11;
            this.btn9.TabStop = false;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.Number);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn8.Location = new System.Drawing.Point(65, 93);
            this.btn8.Margin = new System.Windows.Forms.Padding(0);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(65, 45);
            this.btn8.TabIndex = 10;
            this.btn8.TabStop = false;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.Number);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn7.Location = new System.Drawing.Point(1, 93);
            this.btn7.Margin = new System.Windows.Forms.Padding(0);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(65, 45);
            this.btn7.TabIndex = 9;
            this.btn7.TabStop = false;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.Number);
            // 
            // btnSign
            // 
            this.btnSign.BackColor = System.Drawing.SystemColors.Control;
            this.btnSign.Enabled = false;
            this.btnSign.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSign.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSign.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSign.Location = new System.Drawing.Point(1, 225);
            this.btnSign.Margin = new System.Windows.Forms.Padding(0);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(65, 45);
            this.btnSign.TabIndex = 18;
            this.btnSign.TabStop = false;
            this.btnSign.Text = "±";
            this.btnSign.UseVisualStyleBackColor = false;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FloralWhite;
            this.btnBack.Enabled = false;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnBack.Location = new System.Drawing.Point(264, 2);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(26, 46);
            this.btnBack.TabIndex = 17;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.PeachPuff;
            this.btnClear.Enabled = false;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnClear.Location = new System.Drawing.Point(1, 49);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(65, 45);
            this.btnClear.TabIndex = 16;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.SystemColors.Control;
            this.btnPlus.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnPlus.Location = new System.Drawing.Point(193, 49);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(97, 45);
            this.btnPlus.TabIndex = 19;
            this.btnPlus.TabStop = false;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.Operation);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.SystemColors.Control;
            this.btnMinus.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnMinus.Location = new System.Drawing.Point(193, 93);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(97, 45);
            this.btnMinus.TabIndex = 20;
            this.btnMinus.TabStop = false;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.Operation);
            // 
            // btnSlash
            // 
            this.btnSlash.BackColor = System.Drawing.SystemColors.Control;
            this.btnSlash.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSlash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlash.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlash.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSlash.Location = new System.Drawing.Point(193, 181);
            this.btnSlash.Margin = new System.Windows.Forms.Padding(0);
            this.btnSlash.Name = "btnSlash";
            this.btnSlash.Size = new System.Drawing.Size(97, 45);
            this.btnSlash.TabIndex = 22;
            this.btnSlash.TabStop = false;
            this.btnSlash.Text = "/";
            this.btnSlash.UseVisualStyleBackColor = false;
            this.btnSlash.Click += new System.EventHandler(this.Operation);
            // 
            // btnTimes
            // 
            this.btnTimes.BackColor = System.Drawing.SystemColors.Control;
            this.btnTimes.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnTimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimes.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimes.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnTimes.Location = new System.Drawing.Point(193, 137);
            this.btnTimes.Margin = new System.Windows.Forms.Padding(0);
            this.btnTimes.Name = "btnTimes";
            this.btnTimes.Size = new System.Drawing.Size(97, 45);
            this.btnTimes.TabIndex = 21;
            this.btnTimes.TabStop = false;
            this.btnTimes.Text = "*";
            this.btnTimes.UseVisualStyleBackColor = false;
            this.btnTimes.Click += new System.EventHandler(this.Operation);
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.Color.LightBlue;
            this.btnEquals.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquals.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnEquals.Location = new System.Drawing.Point(193, 225);
            this.btnEquals.Margin = new System.Windows.Forms.Padding(0);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(97, 45);
            this.btnEquals.TabIndex = 23;
            this.btnEquals.TabStop = false;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnPrClose
            // 
            this.btnPrClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrClose.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnPrClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrClose.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrClose.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnPrClose.Location = new System.Drawing.Point(129, 49);
            this.btnPrClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrClose.Name = "btnPrClose";
            this.btnPrClose.Size = new System.Drawing.Size(65, 45);
            this.btnPrClose.TabIndex = 24;
            this.btnPrClose.TabStop = false;
            this.btnPrClose.Text = ")";
            this.btnPrClose.UseVisualStyleBackColor = false;
            this.btnPrClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pr);
            // 
            // btnPrOpen
            // 
            this.btnPrOpen.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrOpen.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnPrOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrOpen.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrOpen.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnPrOpen.Location = new System.Drawing.Point(65, 49);
            this.btnPrOpen.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrOpen.Name = "btnPrOpen";
            this.btnPrOpen.Size = new System.Drawing.Size(65, 45);
            this.btnPrOpen.TabIndex = 25;
            this.btnPrOpen.TabStop = false;
            this.btnPrOpen.Text = "(";
            this.btnPrOpen.UseVisualStyleBackColor = false;
            this.btnPrOpen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pr);
            // 
            // TheCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 271);
            this.Controls.Add(this.btnPrOpen);
            this.Controls.Add(this.btnPrClose);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnSlash);
            this.Controls.Add(this.btnTimes);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.txtDisplay);
            this.Font = new System.Drawing.Font("Courier New", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "TheCalc";
            this.ShowIcon = false;
            this.Text = "TheCalc";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TheCalc_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnSlash;
        private System.Windows.Forms.Button btnTimes;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnPrClose;
        private System.Windows.Forms.Button btnPrOpen;
    }
}

