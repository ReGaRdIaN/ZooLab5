
namespace ZooLab5.UsersForm
{
    partial class Main_Form_Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form_Users));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Save_button = new System.Windows.Forms.Button();
            this.Change_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.New_button = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Family_textBox = new System.Windows.Forms.TextBox();
            this.ID_textBox = new System.Windows.Forms.TextBox();
            this.LifePlace_textBox = new System.Windows.Forms.TextBox();
            this.LongLife_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Find_textBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.Renew_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(885, 618);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.Find_textBox);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.Clear_Button);
            this.tabPage1.Controls.Add(this.Renew_Button);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(877, 592);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Виды";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.Save_button);
            this.panel2.Controls.Add(this.Change_button);
            this.panel2.Controls.Add(this.Delete_button);
            this.panel2.Controls.Add(this.New_button);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(442, 370);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(134, 195);
            this.panel2.TabIndex = 8;
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(24, 162);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(75, 23);
            this.Save_button.TabIndex = 9;
            this.Save_button.Text = "Зберігти";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Change_button
            // 
            this.Change_button.Location = new System.Drawing.Point(24, 132);
            this.Change_button.Name = "Change_button";
            this.Change_button.Size = new System.Drawing.Size(75, 23);
            this.Change_button.TabIndex = 8;
            this.Change_button.Text = "Змінити";
            this.Change_button.UseVisualStyleBackColor = true;
            this.Change_button.Click += new System.EventHandler(this.Change_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(24, 99);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(75, 23);
            this.Delete_button.TabIndex = 7;
            this.Delete_button.Text = "Видалити";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // New_button
            // 
            this.New_button.Location = new System.Drawing.Point(24, 51);
            this.New_button.Name = "New_button";
            this.New_button.Size = new System.Drawing.Size(75, 38);
            this.New_button.TabIndex = 6;
            this.New_button.Text = "Новий запис";
            this.New_button.UseVisualStyleBackColor = true;
            this.New_button.Click += new System.EventHandler(this.New_button_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(18, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 31);
            this.label8.TabIndex = 9;
            this.label8.Text = "Меню";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Name_textBox);
            this.panel1.Controls.Add(this.Family_textBox);
            this.panel1.Controls.Add(this.ID_textBox);
            this.panel1.Controls.Add(this.LifePlace_textBox);
            this.panel1.Controls.Add(this.LongLife_textBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(20, 370);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 195);
            this.panel1.TabIndex = 1;
            this.panel1.TabStop = true;
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(170, 73);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(174, 20);
            this.Name_textBox.TabIndex = 2;
            // 
            // Family_textBox
            // 
            this.Family_textBox.Location = new System.Drawing.Point(170, 106);
            this.Family_textBox.Name = "Family_textBox";
            this.Family_textBox.Size = new System.Drawing.Size(174, 20);
            this.Family_textBox.TabIndex = 3;
            // 
            // ID_textBox
            // 
            this.ID_textBox.Location = new System.Drawing.Point(170, 38);
            this.ID_textBox.Name = "ID_textBox";
            this.ID_textBox.Size = new System.Drawing.Size(174, 20);
            this.ID_textBox.TabIndex = 1;
            // 
            // LifePlace_textBox
            // 
            this.LifePlace_textBox.Location = new System.Drawing.Point(170, 138);
            this.LifePlace_textBox.Name = "LifePlace_textBox";
            this.LifePlace_textBox.Size = new System.Drawing.Size(174, 20);
            this.LifePlace_textBox.TabIndex = 4;
            // 
            // LongLife_textBox
            // 
            this.LongLife_textBox.Location = new System.Drawing.Point(170, 168);
            this.LongLife_textBox.Name = "LongLife_textBox";
            this.LongLife_textBox.Size = new System.Drawing.Size(174, 20);
            this.LongLife_textBox.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(83, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "LongLife";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(83, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "LifePlace";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(83, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Family";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(83, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(83, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Запись:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(862, 282);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Find_textBox
            // 
            this.Find_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Find_textBox.Location = new System.Drawing.Point(715, 14);
            this.Find_textBox.Name = "Find_textBox";
            this.Find_textBox.Size = new System.Drawing.Size(155, 29);
            this.Find_textBox.TabIndex = 4;
            this.Find_textBox.TabStop = false;
            this.Find_textBox.TextChanged += new System.EventHandler(this.Find_textBox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(667, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 37);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Clear_Button
            // 
            this.Clear_Button.BackColor = System.Drawing.Color.DarkGray;
            this.Clear_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Clear_Button.BackgroundImage")));
            this.Clear_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Clear_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_Button.ForeColor = System.Drawing.Color.DarkGray;
            this.Clear_Button.Location = new System.Drawing.Point(571, 10);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(42, 37);
            this.Clear_Button.TabIndex = 2;
            this.Clear_Button.TabStop = false;
            this.Clear_Button.UseVisualStyleBackColor = false;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // Renew_Button
            // 
            this.Renew_Button.BackColor = System.Drawing.Color.DarkGray;
            this.Renew_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Renew_Button.BackgroundImage")));
            this.Renew_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Renew_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Renew_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Renew_Button.ForeColor = System.Drawing.Color.DarkGray;
            this.Renew_Button.Location = new System.Drawing.Point(619, 10);
            this.Renew_Button.Name = "Renew_Button";
            this.Renew_Button.Size = new System.Drawing.Size(42, 37);
            this.Renew_Button.TabIndex = 3;
            this.Renew_Button.TabStop = false;
            this.Renew_Button.UseVisualStyleBackColor = false;
            this.Renew_Button.Click += new System.EventHandler(this.Renew_Button_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(877, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Таблица виды";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(877, 592);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Вальеры";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Main_Form_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 650);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main_Form_Users";
            this.Text = "Main_Form_Users";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_Form_Users_FormClosed);
            this.Load += new System.EventHandler(this.Main_Form_Users_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.Button Renew_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Find_textBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Change_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button New_button;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.TextBox Family_textBox;
        private System.Windows.Forms.TextBox ID_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox LifePlace_textBox;
        private System.Windows.Forms.TextBox LongLife_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}