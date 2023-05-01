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
using System.Configuration;
using Microsoft.Data.Sqlite;
using System.ComponentModel;
using System.IO;

namespace НадёжностьЭлементов
{
    public partial class DB : Form
    {
        private const string sql = "SELECT * FROM CapacitorsTable";
        private const string connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Надежность\\Проект\\НадёжностьЭлементов\\НадёжностьЭлементов\\Database.mdf;Integrated Security=True;";
        private string choice;
        public DB(string choice)
        {
            InitializeComponent();
            this.choice = choice;
            ElementsSetting();
        }
        
        private void ElementsSetting()
        {
            ElementsComboBox.Items.Add("Резисторы");
            ElementsComboBox.Items.Add("Конденсаторы");

        }
        private void DB_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "resistorsTableBindingSource.ResistorsTable". При необходимости она может быть перемещена или удалена.
            this.resistorsTableTableAdapter.Fill(this.resistorsTableBindingSource.ResistorsTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseSet1.CapacitorsTable". При необходимости она может быть перемещена или удалена.
            this.capacitorsTableTableAdapter.Fill(this.databaseSet1.CapacitorsTable);
            GridBind();
        }

        private void GridBind()
        {
            string connString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connString))
            {
                con.Open();
            }

            if (choice == "edit")
            {
                DBdataGridView.ReadOnly = false;
                this.Text = "Редактирование базы данных";
                deleteButton.Visible = true;
                ButtonSaveChanges.Visible = true;
            }
        }

        private void ElementsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ElementsComboBox.Text == "Резисторы")
                DBdataGridView.DataSource = resistorsTableBindingSource1;
            if (ElementsComboBox.Text == "Конденсаторы")
                DBdataGridView.DataSource = capacitorsTableBindingSource;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (this.DBdataGridView.SelectedCells.Count > 0)
            {
                var result = MessageBox.Show("Вы действительно хотите удалить эту строку?", "Предупреждение", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int deletedCell = DBdataGridView.SelectedCells[0].RowIndex;
                    DBdataGridView.Rows.RemoveAt(deletedCell);
                }
            }
            else
                MessageBox.Show("Выберите строку для удаления");
        }

        private void ButtonSaveChanges_Click(object sender, EventArgs e)
        {
            //cmd = new SqlCommand();
            //con = new SqlConnection(connection);
            //con.Open();
            //cmd.Connection = con;
            //cmd.CommandText = "UPDATE" + (DataTable)DBdataGridView.DataSource + "";
            //cmd.ExecuteNonQuery();
            //con.Close();
            MessageBox.Show("Изменения сохранены!");
            //GetList();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TheFirstPresentationForm().Show();
        }
    }
}

