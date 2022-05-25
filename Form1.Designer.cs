
namespace par_impar
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_numbr = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "2. Elaborar um sistema onde o usuário digita um número\r\n e o sistema informa se o" +
    " número é par ou ímpar.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Par ou Impar:";
            // 
            // txt_numbr
            // 
            this.txt_numbr.Location = new System.Drawing.Point(90, 112);
            this.txt_numbr.Name = "txt_numbr";
            this.txt_numbr.Size = new System.Drawing.Size(100, 20);
            this.txt_numbr.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "Checar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_result
            // 
            this.lb_result.AutoSize = true;
            this.lb_result.Location = new System.Drawing.Point(51, 172);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(73, 13);
            this.lb_result.TabIndex = 4;
            this.lb_result.Text = "RESULTADO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 223);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_numbr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_numbr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_result;
    }
}

