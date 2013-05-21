namespace WesselSoft.Ui
{
    partial class OperacionesAvanzadas
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
            this.GroupBox_Result = new System.Windows.Forms.GroupBox();
            this.RadioBtn_Polar = new System.Windows.Forms.RadioButton();
            this.RadioBtn_Binomica = new System.Windows.Forms.RadioButton();
            this.Btn_DoOperation = new System.Windows.Forms.Button();
            this.ComboBox_Operation = new System.Windows.Forms.ComboBox();
            this.TxtBox_Result = new System.Windows.Forms.TextBox();
            this.TxtBox_Number2 = new System.Windows.Forms.TextBox();
            this.TxtBox_Number1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.GroupBox_Result.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox_Result
            // 
            this.GroupBox_Result.Controls.Add(this.RadioBtn_Polar);
            this.GroupBox_Result.Controls.Add(this.RadioBtn_Binomica);
            this.GroupBox_Result.Location = new System.Drawing.Point(149, 4);
            this.GroupBox_Result.Name = "GroupBox_Result";
            this.GroupBox_Result.Size = new System.Drawing.Size(200, 44);
            this.GroupBox_Result.TabIndex = 7;
            this.GroupBox_Result.TabStop = false;
            this.GroupBox_Result.Text = "Resultado";
            // 
            // RadioBtn_Polar
            // 
            this.RadioBtn_Polar.AutoSize = true;
            this.RadioBtn_Polar.Location = new System.Drawing.Point(129, 21);
            this.RadioBtn_Polar.Name = "RadioBtn_Polar";
            this.RadioBtn_Polar.Size = new System.Drawing.Size(49, 17);
            this.RadioBtn_Polar.TabIndex = 2;
            this.RadioBtn_Polar.Text = "Polar";
            this.RadioBtn_Polar.UseVisualStyleBackColor = true;
            // 
            // RadioBtn_Binomica
            // 
            this.RadioBtn_Binomica.AutoSize = true;
            this.RadioBtn_Binomica.Checked = true;
            this.RadioBtn_Binomica.Location = new System.Drawing.Point(16, 21);
            this.RadioBtn_Binomica.Name = "RadioBtn_Binomica";
            this.RadioBtn_Binomica.Size = new System.Drawing.Size(68, 17);
            this.RadioBtn_Binomica.TabIndex = 1;
            this.RadioBtn_Binomica.TabStop = true;
            this.RadioBtn_Binomica.Text = "Binomica";
            this.RadioBtn_Binomica.UseVisualStyleBackColor = true;
            // 
            // Btn_DoOperation
            // 
            this.Btn_DoOperation.Location = new System.Drawing.Point(311, 71);
            this.Btn_DoOperation.Name = "Btn_DoOperation";
            this.Btn_DoOperation.Size = new System.Drawing.Size(38, 23);
            this.Btn_DoOperation.TabIndex = 11;
            this.Btn_DoOperation.Text = "=";
            this.Btn_DoOperation.UseVisualStyleBackColor = true;
            this.Btn_DoOperation.Click += new System.EventHandler(this.Btn_DoOperation_Click_1);
            // 
            // ComboBox_Operation
            // 
            this.ComboBox_Operation.FormattingEnabled = true;
            this.ComboBox_Operation.Items.AddRange(new object[] {
            "Raiz",
            "Potencia"});
            this.ComboBox_Operation.Location = new System.Drawing.Point(143, 70);
            this.ComboBox_Operation.Name = "ComboBox_Operation";
            this.ComboBox_Operation.Size = new System.Drawing.Size(84, 21);
            this.ComboBox_Operation.TabIndex = 9;
            this.ComboBox_Operation.Text = "Operacion";
            // 
            // TxtBox_Result
            // 
            this.TxtBox_Result.Location = new System.Drawing.Point(366, 71);
            this.TxtBox_Result.Name = "TxtBox_Result";
            this.TxtBox_Result.Size = new System.Drawing.Size(100, 20);
            this.TxtBox_Result.TabIndex = 12;
            // 
            // TxtBox_Number2
            // 
            this.TxtBox_Number2.Location = new System.Drawing.Point(240, 71);
            this.TxtBox_Number2.Name = "TxtBox_Number2";
            this.TxtBox_Number2.Size = new System.Drawing.Size(37, 20);
            this.TxtBox_Number2.TabIndex = 10;
            // 
            // TxtBox_Number1
            // 
            this.TxtBox_Number1.Location = new System.Drawing.Point(27, 71);
            this.TxtBox_Number1.Name = "TxtBox_Number1";
            this.TxtBox_Number1.Size = new System.Drawing.Size(100, 20);
            this.TxtBox_Number1.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(181, 115);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(96, 17);
            this.listBox1.TabIndex = 13;
            // 
            // OperacionesAvanzadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 357);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.GroupBox_Result);
            this.Controls.Add(this.Btn_DoOperation);
            this.Controls.Add(this.ComboBox_Operation);
            this.Controls.Add(this.TxtBox_Result);
            this.Controls.Add(this.TxtBox_Number2);
            this.Controls.Add(this.TxtBox_Number1);
            this.MaximizeBox = false;
            this.Name = "OperacionesAvanzadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OperacionesAvanzadas";
            this.GroupBox_Result.ResumeLayout(false);
            this.GroupBox_Result.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox_Result;
        private System.Windows.Forms.RadioButton RadioBtn_Polar;
        private System.Windows.Forms.RadioButton RadioBtn_Binomica;
        private System.Windows.Forms.Button Btn_DoOperation;
        private System.Windows.Forms.ComboBox ComboBox_Operation;
        private System.Windows.Forms.TextBox TxtBox_Result;
        private System.Windows.Forms.TextBox TxtBox_Number2;
        private System.Windows.Forms.TextBox TxtBox_Number1;
        private System.Windows.Forms.ListBox listBox1;
    }
}