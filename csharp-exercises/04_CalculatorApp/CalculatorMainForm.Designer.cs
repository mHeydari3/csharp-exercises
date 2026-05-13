namespace csharp_exercises._04_CalculatorApp
{
    partial class CalculatorMainForm
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
            this.txtNumber1 = new System.Windows.Forms.NumericUpDown();
            this.lblHint1 = new System.Windows.Forms.Label();
            this.lblHint2 = new System.Windows.Forms.Label();
            this.txtNumber2 = new System.Windows.Forms.NumericUpDown();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMultiple = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(71, 27);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(270, 21);
            this.txtNumber1.TabIndex = 0;
            // 
            // lblHint1
            // 
            this.lblHint1.AutoSize = true;
            this.lblHint1.Location = new System.Drawing.Point(362, 29);
            this.lblHint1.Name = "lblHint1";
            this.lblHint1.Size = new System.Drawing.Size(50, 13);
            this.lblHint1.TabIndex = 1;
            this.lblHint1.Text = "عدد اول :";
            // 
            // lblHint2
            // 
            this.lblHint2.AutoSize = true;
            this.lblHint2.Location = new System.Drawing.Point(362, 56);
            this.lblHint2.Name = "lblHint2";
            this.lblHint2.Size = new System.Drawing.Size(52, 13);
            this.lblHint2.TabIndex = 3;
            this.lblHint2.Text = "عدد دوم :";
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(71, 54);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(270, 21);
            this.txtNumber2.TabIndex = 2;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(83, 93);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(57, 34);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(146, 93);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(57, 34);
            this.btnMinus.TabIndex = 5;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnMultiple
            // 
            this.btnMultiple.Location = new System.Drawing.Point(209, 93);
            this.btnMultiple.Name = "btnMultiple";
            this.btnMultiple.Size = new System.Drawing.Size(57, 34);
            this.btnMultiple.TabIndex = 6;
            this.btnMultiple.Text = "*";
            this.btnMultiple.UseVisualStyleBackColor = true;
            this.btnMultiple.Click += new System.EventHandler(this.btnMultiple_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(272, 93);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(57, 34);
            this.btnDivide.TabIndex = 7;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // CalculatorMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 152);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiple);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.lblHint2);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.lblHint1);
            this.Controls.Add(this.txtNumber1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CalculatorMainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ماشین حساب من";
            this.Load += new System.EventHandler(this.CalculatorMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtNumber1;
        private System.Windows.Forms.Label lblHint1;
        private System.Windows.Forms.Label lblHint2;
        private System.Windows.Forms.NumericUpDown txtNumber2;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMultiple;
        private System.Windows.Forms.Button btnDivide;
    }
}