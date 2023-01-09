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

        private void Main_Form_Admin_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        /// <summary>
        /// Створення стовбців таблиці
        /// </summary>
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Password", "Password");
            dataGridView1.Columns.Add("Login", "Login");
            dataGridView1.Columns.Add("IsNew", string.Empty);
        }

        /// <summary>
        /// Надання типів даних для полів.
        /// </summary>
        /// <param name="dgw"></param>
        /// <param name="record"></param>
        private void ReadSingleRows(DataGridView dgw, IDataReader record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), RowState.ModifiedNew);
        }

        /// <summary>
        /// Зчитування даних з бази даних.
        /// </summary>
        /// <param name="dgw"></param>
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"SELECT * FROM Users";
            SqlCommand command = new SqlCommand(queryString, DB.getConnection());

            DB.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                ReadSingleRows(dgw, reader);
            }
            reader.Close();
            DB.closeConnection();
        }

        private void Main_Form_Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
