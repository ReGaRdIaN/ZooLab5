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
        int selectedRow;

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
            Clear();
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
            Clear();
        }


        /// <summary>
        /// Оновлення переглядаймої таблиці.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Renew()
        {
            if (tabControl1.SelectedIndex == 0)
            {
                RefreshDataGridUsers(dataGridView1);
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                RefreshDataGridLook(dataGridView2);
            }
        }
        private void UsersRenew_Button_Click(object sender, EventArgs e)
        {
            Renew();
        }
        private void LookRenew_button_Click(object sender, EventArgs e)
        {
            Renew();
        }


        /// <summary>
        /// Вивід даних обраної строки у форму таблиці Users
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                
                ID_textBox.Text = row.Cells[0].Value.ToString();
                Login_textBox.Text = row.Cells[1].Value.ToString();
                Pass_textBox.Text = row.Cells[2].Value.ToString();
            }
        }
        /// <summary>
        /// Вивід даних обраної строки у форму таблиці Look
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[selectedRow];

                LookId_textBox.Text = row.Cells[0].Value.ToString();
                LookName_textBox.Text = row.Cells[1].Value.ToString();
                LookFamily_textBox.Text = row.Cells[2].Value.ToString();
                LookLifePlace_textBox.Text = row.Cells[3].Value.ToString();
                LookLongLife_textBox.Text = row.Cells[4].Value.ToString();
            }
        }


        /// <summary>
        /// Відмінити вибірку обраних даних табилці Users
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clear()
        {
            if(tabControl1.SelectedIndex == 0)
            {
                ID_textBox.Text = string.Empty;
                Login_textBox.Text = string.Empty;
                Pass_textBox.Text = string.Empty;
                dataGridView1.CurrentCell = null;
            }
            else if(tabControl1.SelectedIndex == 1)
            {
                LookId_textBox.Text = string.Empty;
                LookName_textBox.Text = string.Empty;
                LookFamily_textBox.Text = string.Empty;
                LookLifePlace_textBox.Text = string.Empty;
                LookLongLife_textBox.Text = string.Empty;
                dataGridView2.CurrentCell = null;
            }
        }
        private void Clear_Button_Click(object sender, EventArgs e)
        {
            Clear();
        }
        /// <summary>
        /// Відмінити вибірку обраних даних табилці Look
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LookClear_button_Click(object sender, EventArgs e)
        {
            Clear();
        }


        /// <summary>
        /// Пошук потрібних строк
        /// </summary>
        /// <param name="dgw"></param>
        private void Find(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string findString;

            if (tabControl1.SelectedIndex == 0)
            {
                findString = $"SELECT * FROM Users " +
                             $"WHERE CONCAT (UserId, UserPass, UserLogin) " +
                             $"LIKE '%" + UsersFind_textBox.Text + "%'";
            }
            else
            {
                findString = $"SELECT * FROM Look " +
                             $"WHERE CONCAT (LookId, Name, Family, LifePlace, LongLife) " +
                             $"LIKE '%" + LookFind_textBox.Text + "%'";
            }

            SqlCommand command = new SqlCommand(findString, DB.getConnection());
            DB.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            if (tabControl1.SelectedIndex == 0)
            {
                while (reader.Read())
                {
                    ReadSingleRowsUsers(dgw, reader);
                }
                reader.Close();
            }
            else
            {
                while (reader.Read())
                {
                    ReadSingleRowsLook(dgw, reader);
                }
                reader.Close();
            }
        }
        private void UsersFind_textBox_TextChanged(object sender, EventArgs e)
        {
            Find(dataGridView1);
        }
        private void LookFind_textBox_TextChanged(object sender, EventArgs e)
        {
            Find(dataGridView2);
        }


        /// <summary>
        /// Видалення даних
        /// </summary>
        private void DeleteRow()
        {
            int index;
            if (tabControl1.SelectedIndex == 0)
            {
                index = dataGridView1.CurrentCell.RowIndex;

                dataGridView1.Rows[index].Visible = false;

                if (dataGridView1.Rows[index].Cells[0].Value.ToString() != string.Empty)
                {
                    dataGridView1.Rows[index].Cells[3].Value = RowState.Deleted;
                    return;
                }
            }
            else
            {
                index = dataGridView2.CurrentCell.RowIndex;

                dataGridView2.Rows[index].Visible = false;

                if(dataGridView2.Rows[index].Cells[0].Value.ToString() != string.Empty)
                {
                    dataGridView2.Rows[index].Cells[5].Value = RowState.Deleted;
                    return;
                }
            }
        }
        private void UsersDelete_button_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }
        private void LookDelete_button_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }

        
        /// <summary>
        /// Збереження змін
        /// </summary>
        private new void Update()
        {
            DB.openConnection();

            if(tabControl1.SelectedIndex == 0)
            {
                for (int UsersIndex = 0; UsersIndex < dataGridView1.Rows.Count; UsersIndex++)
                {
                    var UsersRowState = (RowState)dataGridView1.Rows[UsersIndex].Cells[3].Value;

                    if(UsersRowState == RowState.Existed)
                    {
                        continue;
                    }
                    if(UsersRowState == RowState.Deleted)
                    {
                        var id = Convert.ToInt32(dataGridView1.Rows[UsersIndex].Cells[0].Value);

                        var deleteQuery = $"DELETE FROM Users " +
                                          $"WHERE UserId = {id}";

                        SqlCommand command = new SqlCommand(deleteQuery, DB.getConnection());
                        command.ExecuteNonQuery();
                    }
                    if(UsersRowState == RowState.Modified)
                    {
                        var id = Convert.ToInt32(dataGridView1.Rows[UsersIndex].Cells[0].Value);
                        var password = dataGridView1.Rows[UsersIndex].Cells[1].Value.ToString();
                        var login = dataGridView1.Rows[UsersIndex].Cells[2].Value.ToString();

                        var modifiedQuery = $"UPDATE Users " +
                                            $"SET UserPass = '{password}', UserLogin = '{login}'" +
                                            $"WHERE UserId = {id}";
                        SqlCommand command = new SqlCommand(modifiedQuery, DB.getConnection());
                        command.ExecuteNonQuery();
                    }
                }
            }
            else if(tabControl1.SelectedIndex == 1)
            {
                for (int LookIndex = 0; LookIndex < dataGridView2.Rows.Count; LookIndex++)
                {
                    var LookRowState = (RowState)dataGridView2.Rows[LookIndex].Cells[5].Value;

                    if(LookRowState == RowState.Existed)
                    {
                        continue;
                    }
                    if(LookRowState == RowState.Deleted)
                    {
                        var id = Convert.ToInt32(dataGridView2.Rows[LookIndex].Cells[5].Value);

                        var deleteQuery = $"DELETE FROM Look " +
                                          $"WHERE LookId = {id}";

                        SqlCommand command = new SqlCommand(deleteQuery, DB.getConnection());
                        command.ExecuteNonQuery();
                    }
                    if(LookRowState == RowState.Modified)
                    {
                        var id = Convert.ToInt32(dataGridView2.Rows[LookIndex].Cells[0].Value);
                        var name = dataGridView2.Rows[LookIndex].Cells[1].Value.ToString();
                        var family = dataGridView2.Rows[LookIndex].Cells[2].Value.ToString();
                        var lifeplace = dataGridView2.Rows[LookIndex].Cells[3].Value.ToString();
                        var longlife = dataGridView2.Rows[LookIndex].Cells[4].Value.ToString();

                        var modifiedQuery = $"UPDATE Look " +
                                            $"SET Name = '{name}', Family = '{family}', LifePlace = '{lifeplace}', LongLife = '{longlife}'" +
                                            $"WHERE LookId = {id}";

                        SqlCommand command = new SqlCommand(modifiedQuery, DB.getConnection());
                        command.ExecuteNonQuery();
                    }
                }
            }
            DB.closeConnection();
            Clear();
        }
        private void UsersSave_button_Click(object sender, EventArgs e)
        {
            Update();
            
        }
        private void LookSave_button_Click(object sender, EventArgs e)
        {
            Update();
        }
        


        private void Change()
        {
            int index;
            if (tabControl1.SelectedIndex == 0)
            {
                var id = ID_textBox.Text;
                var login = Login_textBox.Text;
                var password = Pass_textBox.Text;

                index = dataGridView1.CurrentCell.RowIndex;

                if (dataGridView1.Rows[index].Cells[0].Value.ToString() != string.Empty)
                {
                    dataGridView1.Rows[index].SetValues(id, login, password);
                    dataGridView1.Rows[index].Cells[3].Value = RowState.Modified;
                }
            }
            else if(tabControl1.SelectedIndex == 1)
            {
                var id = LookId_textBox.Text;
                var name = LookName_textBox.Text;
                var family = LookFamily_textBox.Text;
                var lifeplace = LookLifePlace_textBox.Text;
                int longlife;

                index = dataGridView2.CurrentCell.RowIndex;

                if (dataGridView2.Rows[index].Cells[0].Value.ToString() != string.Empty)
                {
                    if(int.TryParse(LookLongLife_textBox.Text, out longlife))
                    {
                        dataGridView2.Rows[index].SetValues(id, name, family, lifeplace, longlife);
                        dataGridView2.Rows[index].Cells[5].Value = RowState.Modified;
                    }
                    else
                    {
                        MessageBox.Show("Тривалість життя повинна мати числовий формат!");
                    }
                }
            }
        }
        private void UsersChange_button_Click(object sender, EventArgs e)
        {
            Change();
        }
        private void LookChange_button_Click(object sender, EventArgs e)
        {
            Change();
        }

        
    }
}
