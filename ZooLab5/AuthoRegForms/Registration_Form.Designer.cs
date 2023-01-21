
namespace ZooLab5.AuthoRegForms
{
    partial class Registration_Form
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
            this.Reg_label = new System.Windows.Forms.Label();
            this.ChangeLog_label = new System.Windows.Forms.Label();
            this.ChangePass_label = new System.Windows.Forms.Label();
            this.ChangeLog_textBox = new System.Windows.Forms.TextBox();
            this.ChangePass_textBox = new System.Windows.Forms.TextBox();
            this.Registr_button = new System.Windows.Forms.Button();
            this.AutoReg_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Reg_label
            // 
            this.Reg_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.Reg_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reg_label.Location = new System.Drawing.Point(0, 0);
            this.Reg_label.Name = "Reg_label";
            this.Reg_label.Size = new System.Drawing.Size(366, 51);
            this.Reg_label.TabIndex = 0;
            this.Reg_label.Text = "Реєстрація";
            this.Reg_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChangeLog_label
            // 
            this.ChangeLog_label.AutoSize = true;
            this.ChangeLog_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeLog_label.Location = new System.Drawing.Point(12, 79);
            this.ChangeLog_label.Name = "ChangeLog_label";
            this.ChangeLog_label.Size = new System.Drawing.Size(131, 24);
            this.ChangeLog_label.TabIndex = 1;
            this.ChangeLog_label.Text = "Введіть логін";
            // 
            // ChangePass_label
            // 
            this.ChangePass_label.AutoSize = true;
            this.ChangePass_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangePass_label.Location = new System.Drawing.Point(12, 119);
            this.ChangePass_label.Name = "ChangePass_label";
            this.ChangePass_label.Size = new System.Drawing.Size(150, 24);
            this.ChangePass_label.TabIndex = 2;
            this.ChangePass_label.Text = "Введіть пароль";
            // 
            // ChangeLog_textBox
            // 
            this.ChangeLog_textBox.Location = new System.Drawing.Point(168, 83);
            this.ChangeLog_textBox.Name = "ChangeLog_textBox";
            this.ChangeLog_textBox.Size = new System.Drawing.Size(154, 20);
            this.ChangeLog_textBox.TabIndex = 3;
            // 
            // ChangePass_textBox
            // 
            this.ChangePass_textBox.Location = new System.Drawing.Point(168, 124);
            this.ChangePass_textBox.Name = "ChangePass_textBox";
            this.ChangePass_textBox.Size = new System.Drawing.Size(154, 20);
            this.ChangePass_textBox.TabIndex = 4;
            // 
            // Registr_button
            // 
            this.Registr_button.Location = new System.Drawing.Point(134, 163);
            this.Registr_button.Name = "Registr_button";
            this.Registr_button.Size = new System.Drawing.Size(115, 23);
            this.Registr_button.TabIndex = 5;
            this.Registr_button.Text = "Зареєструватися";
            this.Registr_button.UseVisualStyleBackColor = true;
            this.Registr_button.Click += new System.EventHandler(this.Registr_button_Click);
            // 
            // AutoReg_Label
            // 
            this.AutoReg_Label.AutoSize = true;
            this.AutoReg_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutoReg_Label.ForeColor = System.Drawing.Color.DimGray;
            this.AutoReg_Label.Location = new System.Drawing.Point(145, 189);
            this.AutoReg_Label.Name = "AutoReg_Label";
            this.AutoReg_Label.Size = new System.Drawing.Size(89, 13);
            this.AutoReg_Label.TabIndex = 7;
            this.AutoReg_Label.Text = "Авторизуватися";
            this.AutoReg_Label.Click += new System.EventHandler(this.AutoReg_Label_Click);
            // 
            // Registration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 498);
            this.Controls.Add(this.AutoReg_Label);
            this.Controls.Add(this.Registr_button);
            this.Controls.Add(this.ChangePass_textBox);
            this.Controls.Add(this.ChangeLog_textBox);
            this.Controls.Add(this.ChangePass_label);
            this.Controls.Add(this.ChangeLog_label);
            this.Controls.Add(this.Reg_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Registration_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registration_Form_FormClosed);
            this.Load += new System.EventHandler(this.Registration_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Reg_label;
        private System.Windows.Forms.Label ChangeLog_label;
        private System.Windows.Forms.Label ChangePass_label;
        private System.Windows.Forms.TextBox ChangeLog_textBox;
        private System.Windows.Forms.TextBox ChangePass_textBox;
        private System.Windows.Forms.Button Registr_button;
        private System.Windows.Forms.Label AutoReg_Label;
    }
}