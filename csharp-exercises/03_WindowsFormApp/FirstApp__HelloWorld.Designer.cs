namespace csharp_exercises
{
    partial class FirstApp__HelloWorld
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
            this.btnSayHello = new System.Windows.Forms.Button();
            this.lblHint = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSayHello
            // 
            this.btnSayHello.Location = new System.Drawing.Point(108, 254);
            this.btnSayHello.Name = "btnSayHello";
            this.btnSayHello.Size = new System.Drawing.Size(75, 23);
            this.btnSayHello.TabIndex = 0;
            this.btnSayHello.Text = "Click Here";
            this.btnSayHello.UseVisualStyleBackColor = true;
            this.btnSayHello.Click += new System.EventHandler(this.btnSayHello_Click);
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Location = new System.Drawing.Point(49, 213);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(111, 13);
            this.lblHint.TabIndex = 1;
            this.lblHint.Text = "Enter your name here:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(166, 210);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(201, 20);
            this.txtInput.TabIndex = 2;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(332, 264);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 3;
            // 
            // FirstApp__HelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.btnSayHello);
            this.Name = "FirstApp__HelloWorld";
            this.Text = "FirstApp  Hello World";
            this.Load += new System.EventHandler(this.FirstApp__HelloWorld_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSayHello;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblResult;
    }
}