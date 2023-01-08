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

namespace ZooLab5.UsersForm
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class Main_Form_Users : Form
    {
        DataBase DB = new DataBase();
        int selectedRow;
        public Main_Form_Users()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Закриття всіх процесів пов'язаних з цим проектом
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Form_Users_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void Main_Form_Users_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        /// <summary>
        /// Створення Таблиці
        /// </summary>
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Family", "Family");
            dataGridView1.Columns.Add("LifePlace", "LifePlace");
            dataGridView1.Columns.Add("LongLife", "LongLife");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        /// <summary>
        /// Надання типів даних для полів
        /// </summary>
        /// <param name="dgw"></param>
        /// <param name="record"></param>
        private void ReadSingleRows(DataGridView dgw, IDataReader record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetInt32(4), RowState.ModifiedNew);
        }

        /// <summary>
        /// Зчитування даних з бази даних та вивід їх у DataGridView
        /// </summary>
        /// <param name="dgw"></param>
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"SELECT * FROM Look";

            SqlCommand command = new SqlCommand(queryString, DB.getConnection());

            DB.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRows(dgw, reader);
            }
            reader.Close();
        }

        /// <summary>
        /// Вивід даних обраної строки у форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                ID_textBox.Text = row.Cells[0].Value.ToString();
                Name_textBox.Text = row.Cells[1].Value.ToString();
                Family_textBox.Text = row.Cells[2].Value.ToString();
                LifePlace_textBox.Text = row.Cells[3].Value.ToString();
                LongLife_textBox.Text = row.Cells[4].Value.ToString();
            }
        }

        /// <summary>
        /// Оновлення виведених даних визовом простого виведення даних у DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Renew_Button_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        /// <summary>
        /// Додавання нових записів
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void New_button_Click(object sender, EventArgs e)
        {
            Add_Form addform = new Add_Form();
            addform.Show();
        }

        /// <summary>
        /// Пошук потрібних нам строк
        /// </summary>
        /// <param name="dgw"></param>
        private void Find(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string findString = $"SELECT * FROM Look WHERE CONCAT (LookId, Name, Family, LifePlace, LongLife) LIKE '%" + Find_textBox.Text + "%'";

            SqlCommand command = new SqlCommand(findString, DB.getConnection());
            DB.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRows(dgw, reader);
            }
            reader.Close();
        }
        private void Find_textBox_TextChanged(object sender, EventArgs e)
        {
            Find(dataGridView1);
        }

        /// <summary>
        /// Видалення стовпця
        /// </summary>
        private void DeleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
                return;
            }
        }

        /// <summary>
        /// Видалення 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Delete_button_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }

        /// <summary>
        /// Редагування даних 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = ID_textBox.Text;
            var name = Name_textBox.Text;
            var family = Family_textBox.Text;
            var lifeplace = LifePlace_textBox.Text;
            int longlife;

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(LongLife_textBox.Text, out longlife))
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(id, name, family, lifeplace, longlife);
                    dataGridView1.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Тривалість життя повинна мати числовий формат!");
                }
            }

        }
        private void Change_button_Click(object sender, EventArgs e)
        {
            Change();
        }

        /// <summary>
        /// Збереження
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private new void Update()
        {
            DB.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[5].Value;

                if (rowState == RowState.Existed)
                {
                    continue;
                }
                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuary = $"DELETE FROM Look WHERE LookId = {id}";

                    var command = new SqlCommand(deleteQuary, DB.getConnection());
                    command.ExecuteNonQuery();
                }
                if(rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var name = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var family = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var lifeplace = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var longlife = dataGridView1.Rows[index].Cells[4].Value.ToString();

                    var chaneQuary = $"UPDATE Look SET Name = '{name}', Family = '{family}', LifePlace = '{lifeplace}', LongLife = '{longlife}' WHERE LookId = '{id}'";
                    var command = new SqlCommand(chaneQuary, DB.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            DB.closeConnection();
        }
        private void Save_button_Click(object sender, EventArgs e)
        {
            Update();
        }
    }
}
