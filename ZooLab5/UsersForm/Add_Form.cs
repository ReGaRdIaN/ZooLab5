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

namespace ZooLab5
{
    public partial class Add_Form : Form
    {
        DataBase DB = new DataBase();
        public Add_Form()
        {
            InitializeComponent();
        }
        private void Add_Form_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Зберегти додані дані
        /// </summary>
        private void Save()
        {
            DB.openConnection();
            var name = AddName_textBox.Text;
            var family = AddFamily_textBox.Text;
            var lifeplace = AddLifePlace_textBox.Text;
            int longlife;


            if (int.TryParse(AddLongLife_textBox.Text, out longlife))
            {
                if (name == string.Empty || family == string.Empty || lifeplace == string.Empty || longlife == 0)
                {
                    MessageBox.Show("Усі поля мають бути заповнені!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string AddQuery = $"INSERT INTO Look (Name, Family, LifePlace, LongLife)" +
                                      $"VALUES" +
                                      $"('{name}', '{family}', '{lifeplace}', '{longlife}')";

                    SqlCommand command = new SqlCommand(AddQuery, DB.getConnection());
                    command.ExecuteNonQuery();

                    MessageBox.Show("Запис доданий", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddName_textBox.Text = "";
                    AddFamily_textBox.Text = "";
                    AddLifePlace_textBox.Text = "";
                    AddLongLife_textBox.Text = "";
                }             
            }
            else
            {
                MessageBox.Show("Значення LongLife повинно бути цілим!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            DB.closeConnection();
        }
        
        private void SaveAdd_button_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}
