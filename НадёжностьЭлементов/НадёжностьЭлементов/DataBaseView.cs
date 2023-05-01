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
using System.Data.OleDb;

namespace НадёжностьЭлементов
{
    public partial class DataBaseView : Form
    {
        string choice = "";
        public DataBaseView()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            choice = "show";
            new DB(choice).Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            choice = "edit";
            new DB(choice).Show();
        }
    }
}
