namespace WesselSoft.Ui
{
    partial class CalculoTransferencia
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
            this.TxtBox_Zeros = new System.Windows.Forms.TextBox();
            this.TxtBox_Poles = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBox_ComplexNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Calculate = new System.Windows.Forms.Button();
            this.TxtBox_Result = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtBox_Constant = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtBox_Zeros
            // 
            this.TxtBox_Zeros.Location = new System.Drawing.Point(89, 61);
            this.TxtBox_Zeros.Multiline = true;
            this.TxtBox_Zeros.Name = "TxtBox_Zeros";
            this.TxtBox_Zeros.Size = new System.Drawing.Size(183, 51);
            this.TxtBox_Zeros.TabIndex = 0;
            // 
            // TxtBox_Poles
            // 
            this.TxtBox_Poles.Location = new System.Drawing.Point(89, 135);
            this.TxtBox_Poles.Multiline = true;
            this.TxtBox_Poles.Name = "TxtBox_Poles";
            this.TxtBox_Poles.Size = new System.Drawing.Size(183, 58);
            this.TxtBox_Poles.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ceros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingrese los ceros y polos uno debajo del otro";
            // 
            // TxtBox_ComplexNumber
            // 
            this.TxtBox_ComplexNumber.Location = new System.Drawing.Point(172, 208);
            this.TxtBox_ComplexNumber.Name = "TxtBox_ComplexNumber";
            this.TxtBox_ComplexNumber.Size = new System.Drawing.Size(100, 20);
            this.TxtBox_ComplexNumber.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Polos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Numero Complejo a evaluar";
            // 
            // Btn_Calculate
            // 
            this.Btn_Calculate.Location = new System.Drawing.Point(99, 263);
            this.Btn_Calculate.Name = "Btn_Calculate";
            this.Btn_Calculate.Size = new System.Drawing.Size(75, 23);
            this.Btn_Calculate.TabIndex = 9;
            this.Btn_Calculate.Text = "Calcular";
            this.Btn_Calculate.UseVisualStyleBackColor = true;
            this.Btn_Calculate.Click += new System.EventHandler(this.Btn_Calculate_Click);
            // 
            // TxtBox_Result
            // 
            this.TxtBox_Result.Location = new System.Drawing.Point(89, 310);
            this.TxtBox_Result.Name = "TxtBox_Result";
            this.TxtBox_Result.Size = new System.Drawing.Size(100, 20);
            this.TxtBox_Result.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Constante";
            // 
            // TxtBox_Constant
            // 
            this.TxtBox_Constant.Location = new System.Drawing.Point(172, 234);
            this.TxtBox_Constant.Name = "TxtBox_Constant";
            this.TxtBox_Constant.Size = new System.Drawing.Size(100, 20);
            this.TxtBox_Constant.TabIndex = 11;
            // 
            // CalculoTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 358);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtBox_Constant);
            this.Controls.Add(this.TxtBox_Result);
            this.Controls.Add(this.Btn_Calculate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBox_ComplexNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBox_Poles);
            this.Controls.Add(this.TxtBox_Zeros);
            this.MaximizeBox = false;
            this.Name = "CalculoTransferencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalculoTransferencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBox_Zeros;
        private System.Windows.Forms.TextBox TxtBox_Poles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBox_ComplexNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_Calculate;
        private System.Windows.Forms.TextBox TxtBox_Result;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtBox_Constant;
    }
}