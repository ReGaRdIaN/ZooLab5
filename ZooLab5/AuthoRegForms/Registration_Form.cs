using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ZooLab5.AuthoRegForms
{
    public partial class Registration_Form : Form
    {
        Authorization_From AuthoForm = new Authorization_From();
        DataBase DB = new DataBase();
        public Registration_Form()
        {
            InitializeComponent();
        }
        private void Registration_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        /// <summary>
        /// Завантаження форми
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Registration_Form_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Кнопка підтвердження реєстрації
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Registr_button_Click(object sender, EventArgs e)
        {
            if(UserCheck())
            {
                return;
            }
            else if(ChangeLog_textBox.Text == string.Empty || ChangePass_textBox.Text == string.Empty)
            {
                MessageBox.Show("Усі поля повинні бути заповнені!", "Помилка!");         
            }
            else
            {
                var loginUser = ChangeLog_textBox.Text;
                var passUser = ChangePass_textBox.Text;

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();

                string querystring = $"INSERT INTO Users(UserPass, UserLogin) " +
                                     $"VALUES" +
                                     $"('{passUser}', '{loginUser}')";

                SqlCommand command = new SqlCommand(querystring, DB.getConnection());
                DB.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Акаунт успішно створений", "Успіх");
                    this.Hide();
                    AuthoForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Акаунт не створений!", "Помилка");
                }
            }
        }

        /// <summary>
        /// Перевірка наявності такого ж самого юзера
        /// </summary>
        /// <returns></returns>
        private Boolean UserCheck()
        {
            var loginUser = ChangeLog_textBox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"SELECT UserLogin FROM Users WHERE UserLogin = '{loginUser}'";

            SqlCommand command = new SqlCommand(querystring, DB.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                MessageBox.Show("Такий користувач вже імнує!");
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Повернення на форму авторизації.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AutoReg_Label_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthoForm.ShowDialog();
        }

        /// <summary>
        /// Зімна кольору переходу між формами реєстрації та авторизації.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AutoReg_Label_MouseMove(object sender, MouseEventArgs e)
        {
            AutoReg_Label.ForeColor = Color.Black;
        }
        private void AutoReg_Label_MouseLeave(object sender, EventArgs e)
        {
            AutoReg_Label.ForeColor = Color.DimGray;
        }


        /// <summary>
        /// Відображання/скриття паролю
        /// </summary>
        private void ShowOrHide()
        {
            if (ChangePass_textBox.UseSystemPasswordChar == true)
            {
                ChangePass_textBox.UseSystemPasswordChar = false;
                Hide_button.Visible = true;
                Show_button.Visible = false;
            }
            else
            {
                ChangePass_textBox.UseSystemPasswordChar = true;
                Hide_button.Visible = false;
                Show_button.Visible = true;
            }
        }
        private void Hide_button_Click(object sender, EventArgs e)
        {
            ShowOrHide();
        }
        private void Show_button_Click(object sender, EventArgs e)
        {
            ShowOrHide();
        }
    }
}
