
namespace ZooLab5
{
    partial class Authorization_From
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
            this.LabelAuthorization = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.UserLogin_TextBox = new System.Windows.Forms.TextBox();
            this.UserPass_textBox = new System.Windows.Forms.TextBox();
            this.Authorization_Button = new System.Windows.Forms.Button();
            this.NotReg_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelAuthorization
            // 
            this.LabelAuthorization.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelAuthorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAuthorization.Location = new System.Drawing.Point(0, 0);
            this.LabelAuthorization.Name = "LabelAuthorization";
            this.LabelAuthorization.Size = new System.Drawing.Size(362, 31);
            this.LabelAuthorization.TabIndex = 0;
            this.LabelAuthorization.Text = "Авторизація";
            this.LabelAuthorization.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.Location = new System.Drawing.Point(13, 59);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(57, 24);
            this.LoginLabel.TabIndex = 1;
            this.LoginLabel.Text = "Логін";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassLabel.Location = new System.Drawing.Point(13, 103);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(76, 24);
            this.PassLabel.TabIndex = 2;
            this.PassLabel.Text = "Пароль";
            // 
            // UserLogin_TextBox
            // 
            this.UserLogin_TextBox.Location = new System.Drawing.Point(107, 64);
            this.UserLogin_TextBox.Name = "UserLogin_TextBox";
            this.UserLogin_TextBox.Size = new System.Drawing.Size(160, 20);
            this.UserLogin_TextBox.TabIndex = 3;
            // 
            // UserPass_textBox
            // 
            this.UserPass_textBox.Location = new System.Drawing.Point(107, 108);
            this.UserPass_textBox.Name = "UserPass_textBox";
            this.UserPass_textBox.PasswordChar = '*';
            this.UserPass_textBox.Size = new System.Drawing.Size(160, 20);
            this.UserPass_textBox.TabIndex = 4;
            // 
            // Authorization_Button
            // 
            this.Authorization_Button.Location = new System.Drawing.Point(133, 150);
            this.Authorization_Button.Name = "Authorization_Button";
            this.Authorization_Button.Size = new System.Drawing.Size(105, 23);
            this.Authorization_Button.TabIndex = 5;
            this.Authorization_Button.Text = "Авторирзуватися";
            this.Authorization_Button.UseVisualStyleBackColor = true;
            this.Authorization_Button.Click += new System.EventHandler(this.Authorization_Button_Click);
            // 
            // NotReg_Label
            // 
            this.NotReg_Label.AutoSize = true;
            this.NotReg_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotReg_Label.ForeColor = System.Drawing.Color.DimGray;
            this.NotReg_Label.Location = new System.Drawing.Point(138, 176);
            this.NotReg_Label.Name = "NotReg_Label";
            this.NotReg_Label.Size = new System.Drawing.Size(95, 13);
            this.NotReg_Label.TabIndex = 6;
            this.NotReg_Label.Text = "Зареєструватися";
            this.NotReg_Label.Click += new System.EventHandler(this.NotReg_Label_Click);
            this.NotReg_Label.MouseLeave += new System.EventHandler(this.NotReg_Label_MouseLeave_1);
            this.NotReg_Label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NotReg_Label_MouseMove_1);
            // 
            // Authorization_From
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 494);
            this.Controls.Add(this.NotReg_Label);
            this.Controls.Add(this.Authorization_Button);
            this.Controls.Add(this.UserPass_textBox);
            this.Controls.Add(this.UserLogin_TextBox);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.LabelAuthorization);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Authorization_From";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Authorization_From_FormClosed);
            this.Load += new System.EventHandler(this.Authorization_From_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelAuthorization;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.TextBox UserLogin_TextBox;
        private System.Windows.Forms.TextBox UserPass_textBox;
        private System.Windows.Forms.Button Authorization_Button;
        private System.Windows.Forms.Label NotReg_Label;
    }
}

