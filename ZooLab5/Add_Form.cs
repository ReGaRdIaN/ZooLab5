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

        private void SaveAdd_button_Click(object sender, EventArgs e)
        {
            DB.openConnection();
            var name = AddName_textBox.Text;
            var family = AddFamily_textBox.Text;
            var lifeplace = AddLifePlace_textBox.Text;
            int longlife;

            
            if(int.TryParse(AddLongLife_textBox.Text, out longlife))
            {
                string AddQuery = $"INSERT INTO Look (Name, Family, LifePlace, LongLife)" +
                                                $"VALUES" +
                                                $"('{name}', '{family}', '{lifeplace}', '{longlife}')";

                SqlCommand command = new SqlCommand(AddQuery, DB.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись добавлена", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddName_textBox.Text = "";
                AddFamily_textBox.Text = "";
                AddLifePlace_textBox.Text = "";
                AddLongLife_textBox.Text = "";
            }
            else
            {
                MessageBox.Show("Значение LongLife должно быть целочисленным!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            DB.closeConnection();
        }

        private void Add_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
