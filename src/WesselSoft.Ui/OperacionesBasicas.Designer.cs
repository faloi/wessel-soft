namespace WesselSoft.Ui
{
    partial class OperacionesBasicas
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
            this.TxtBox_Number1 = new System.Windows.Forms.TextBox();
            this.TxtBox_Number2 = new System.Windows.Forms.TextBox();
            this.TxtBox_Result = new System.Windows.Forms.TextBox();
            this.ComboBox_Operation = new System.Windows.Forms.ComboBox();
            this.Btn_DoOperation = new System.Windows.Forms.Button();
            this.GroupBox_Result = new System.Windows.Forms.GroupBox();
            this.RadioBtn_Polar = new System.Windows.Forms.RadioButton();
            this.RadioBtn_Binomica = new System.Windows.Forms.RadioButton();
            this.GroupBox_Result.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtBox_Number1
            // 
            this.TxtBox_Number1.Location = new System.Drawing.Point(12, 82);
            this.TxtBox_Number1.Name = "TxtBox_Number1";
            this.TxtBox_Number1.Size = new System.Drawing.Size(100, 20);
            this.TxtBox_Number1.TabIndex = 2;
            // 
            // TxtBox_Number2
            // 
            this.TxtBox_Number2.Location = new System.Drawing.Point(181, 82);
            this.TxtBox_Number2.Name = "TxtBox_Number2";
            this.TxtBox_Number2.Size = new System.Drawing.Size(100, 20);
            this.TxtBox_Number2.TabIndex = 4;
            // 
            // TxtBox_Result
            // 
            this.TxtBox_Result.Location = new System.Drawing.Point(351, 82);
            this.TxtBox_Result.Name = "TxtBox_Result";
            this.TxtBox_Result.ReadOnly = true;
            this.TxtBox_Result.Size = new System.Drawing.Size(100, 20);
            this.TxtBox_Result.TabIndex = 6;
            // 
            // ComboBox_Operation
            // 
            this.ComboBox_Operation.FormattingEnabled = true;
            this.ComboBox_Operation.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.ComboBox_Operation.Location = new System.Drawing.Point(127, 82);
            this.ComboBox_Operation.Name = "ComboBox_Operation";
            this.ComboBox_Operation.Size = new System.Drawing.Size(38, 21);
            this.ComboBox_Operation.TabIndex = 3;
            this.ComboBox_Operation.Text = "Op";
            // 
            // Btn_DoOperation
            // 
            this.Btn_DoOperation.Location = new System.Drawing.Point(296, 82);
            this.Btn_DoOperation.Name = "Btn_DoOperation";
            this.Btn_DoOperation.Size = new System.Drawing.Size(38, 23);
            this.Btn_DoOperation.TabIndex = 5;
            this.Btn_DoOperation.Text = "=";
            this.Btn_DoOperation.UseVisualStyleBackColor = true;
            this.Btn_DoOperation.Click += new System.EventHandler(this.Btn_DoOperation_Click);
            // 
            // GroupBox_Result
            // 
            this.GroupBox_Result.Controls.Add(this.RadioBtn_Polar);
            this.GroupBox_Result.Controls.Add(this.RadioBtn_Binomica);
            this.GroupBox_Result.Location = new System.Drawing.Point(134, 15);
            this.GroupBox_Result.Name = "GroupBox_Result";
            this.GroupBox_Result.Size = new System.Drawing.Size(200, 44);
            this.GroupBox_Result.TabIndex = 1;
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
            // OperacionesBasicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 148);
            this.Controls.Add(this.GroupBox_Result);
            this.Controls.Add(this.Btn_DoOperation);
            this.Controls.Add(this.ComboBox_Operation);
            this.Controls.Add(this.TxtBox_Result);
            this.Controls.Add(this.TxtBox_Number2);
            this.Controls.Add(this.TxtBox_Number1);
            this.MinimizeBox = false;
            this.Name = "OperacionesBasicas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OperacionesBasicas";
            this.GroupBox_Result.ResumeLayout(false);
            this.GroupBox_Result.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBox_Number1;
        private System.Windows.Forms.TextBox TxtBox_Number2;
        private System.Windows.Forms.TextBox TxtBox_Result;
        private System.Windows.Forms.ComboBox ComboBox_Operation;
        private System.Windows.Forms.Button Btn_DoOperation;
        private System.Windows.Forms.GroupBox GroupBox_Result;
        private System.Windows.Forms.RadioButton RadioBtn_Polar;
        private System.Windows.Forms.RadioButton RadioBtn_Binomica;

    }
}