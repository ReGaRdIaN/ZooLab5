using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooLab5.AuthoRegForms;
using ZooLab5.UsersForm;

namespace ZooLab5
{

    public partial class Authorization_From : Form
    {
        DataBase DB = new DataBase();
        public Authorization_From()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Функція завантаження форми
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Authorization_From_Load(object sender, EventArgs e)
        {
            
        }
        
        /// <summary>
        /// Елемент "реєстрації"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotReg_Label_Click(object sender, EventArgs e)
        {
            Registration_Form RegFrom = new Registration_Form();
            RegFrom.Show();
            this.Hide();
        }

        /// <summary>
        /// Зімна кольору переходу між формами реєстрації та авторизації
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotReg_Label_MouseMove_1(object sender, MouseEventArgs e)
        {
            NotReg_Label.ForeColor = Color.Black;
        }
        private void NotReg_Label_MouseLeave_1(object sender, EventArgs e)
        {
            NotReg_Label.ForeColor = Color.DimGray;
        }

        /// <summary>
        /// Кнопка авторизації
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Authorization_Button_Click(object sender, EventArgs e)
        {
            var loginUser = UserLogin_TextBox.Text;
            var passUser = UserPass_textBox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"SELECT UserId, UserPass, UserLogin FROM Users WHERE UserLogin = '{loginUser}' AND UserPass = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, DB.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Ви успішно зайшли!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (loginUser == "Admin" && passUser == "Admin" || loginUser == "admin" && passUser == "admin")
                {
                    Main_Form_Admin MainFormAdmin = new Main_Form_Admin();
                    this.Hide();
                    MainFormAdmin.ShowDialog();
                }
                else
                {
                    Main_Form_Users MainFormUsers = new Main_Form_Users();
                    this.Hide();
                    MainFormUsers.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Такого акаунту не існує", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Видалення усії процесів після закриття рішення
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Authorization_From_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }



        /// <summary>
        /// Відображання/скриття паролю
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowOrHide()
        {
            if (UserPass_textBox.UseSystemPasswordChar == true)
            {
                UserPass_textBox.UseSystemPasswordChar = false;
                Hide_button.Visible = true;
                Show_button.Visible = false;
            }
            else
            {
                UserPass_textBox.UseSystemPasswordChar = true;
                Hide_button.Visible = false;
                Show_button.Visible = true;
            }
        }
        private void Show_button_Click(object sender, EventArgs e)
        {
            ShowOrHide();
        }
        private void Hide_button_Click(object sender, EventArgs e)
        {
            ShowOrHide();
        }
    }
}
