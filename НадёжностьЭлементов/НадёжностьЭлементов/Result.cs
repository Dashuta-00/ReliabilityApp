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
    public partial class Result : Form
    {
        int coordY = 50, coordX = 50;
        List<double> failureRates = new List<double>();
        public Result(double intensity, List<string> types, ref List<double> failureRates)
        {
            InitializeComponent();
            this.failureRates = failureRates;
            label3.Text = Math.Round(intensity, 8).ToString();
            foreach (string type in types)
            {
                CreateLabel(type);
                //createDel();
                coordY += 15;
            }

        }
        private void CreateLabel(string typeName)
        {
            Label label = new Label();
            label.Location = new Point(coordX, coordY);
            label.AutoSize = true;
            label.Text = typeName;
            Controls.Add(label);
        }
    
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            coordX = 120; coordY = 50;
            foreach (double fail in failureRates)
                CreateLabel(Math.Round(fail, 8).ToString());
        }
    }
}
