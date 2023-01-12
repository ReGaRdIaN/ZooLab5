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

namespace ZooLab5
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class Main_Form_Admin : Form
    {
        DataBase DB = new DataBase();
        public Main_Form_Admin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Видалення процесів закритої форми.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Form_Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        /// <summary>
        /// Параметри завантаження форми
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Form_Admin_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGridUsers(dataGridView1);
            RefreshDataGridLook(dataGridView2);
        }

        /// <summary>
        /// Створення стовбців таблиці
        /// </summary>
        private void CreateColumns()
        {
            //Стовпці для таблиці users
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Password", "Password");
            dataGridView1.Columns.Add("Login", "Login");
            dataGridView1.Columns.Add("IsNew", string.Empty);

            //Стовпці для таблиці look
            dataGridView2.Columns.Add("Id", "Id");
            dataGridView2.Columns.Add("Name", "Name");
            dataGridView2.Columns.Add("Family", "Family");
            dataGridView2.Columns.Add("LifePlace", "LifePlace");
            dataGridView2.Columns.Add("LongLife", "LongLife");
            dataGridView2.Columns.Add("IsNew", string.Empty);
        }

        /// <summary>
        /// Надання типів даних для полів таблиці Users.
        /// </summary>
        /// <param name="dgw"></param>
        /// <param name="record"></param>
        private void ReadSingleRowsUsers(DataGridView dgw, IDataReader record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), RowState.ModifiedNew);
        }

        /// <summary>
        /// Надання типів даних для полів таблиці Look.
        /// </summary>
        /// <param name="dgw"></param>
        /// <param name="record"></param>
        private void ReadSingleRowsLook(DataGridView dgw, IDataReader record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetInt32(4), RowState.ModifiedNew);
        }

        /// <summary>
        /// Зчитування даних з бази даних для таблиці Users.
        /// </summary>
        /// <param name="dgw"></param>
        private void RefreshDataGridUsers(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryStringUsers = $"SELECT * FROM Users";
            SqlCommand UserCommand = new SqlCommand(queryStringUsers, DB.getConnection());

            DB.openConnection();

            SqlDataReader UserReader = UserCommand.ExecuteReader();
           
            while(UserReader.Read())
            {
                ReadSingleRowsUsers(dgw, UserReader);
            }

            UserReader.Close();
            DB.closeConnection();
        }

        /// <summary>
        /// Зчитування даних з бази даних для таблиці Look.
        /// </summary>
        /// <param name="dgw"></param>
        private void RefreshDataGridLook(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string quertStringLook = $"SELECT * FROM Look";
            SqlCommand LookCommand = new SqlCommand(quertStringLook, DB.getConnection());

            DB.openConnection();

            SqlDataReader LookReader = LookCommand.ExecuteReader();

            while (LookReader.Read())
            {
                ReadSingleRowsLook(dgw, LookReader);
            }

            LookReader.Close();
            DB.closeConnection();
        }

        /// <summary>
        /// Оновлення переглядаймої таблиці.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Renew_Button_Click(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 0)
            {
                RefreshDataGridUsers(dataGridView1);
            }
            else
            {
                RefreshDataGridLook(dataGridView2);
            }
        }

    }
}
