using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace НадёжностьЭлементов
{
    public partial class TheFirstPresentationForm : Form
    {
        public TheFirstPresentationForm()
        {
            InitializeComponent();
        }

        private void DataBaseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DataBaseView().Show();
        }

        private void ReliabilityButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainTitle().Show();
        }
    }
}
