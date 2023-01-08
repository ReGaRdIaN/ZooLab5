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
        DataBase DB = new DataBase();
        public Registration_Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Завантаження форми
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Registration_Form_Load(object sender, EventArgs e)
        {
            ChangePass_textBox.PasswordChar = '*';
        }

        /// <summary>
        /// Кнопка підтвердження регестрації
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Registr_button_Click(object sender, EventArgs e)
        {
            if(UserCheck())
            {
                return;
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
                    MessageBox.Show("Аккаунт успешно создан", "Успех");
                    Authorization_From AuthoForm = new Authorization_From();
                    this.Hide();
                    AuthoForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Аккаунт не создан!", "Ошибка");
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
                MessageBox.Show("Пользователь уже существует!");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
