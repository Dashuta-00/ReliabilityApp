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
    public partial class CapacitorForm : Form
    {
        List<Form> capacitorsForms;
        ListBox refToLB;

        public CapacitorForm(ref List<Form> lcf, ref ListBox lb)
        {
            capacitorsForms = lcf;
            refToLB = lb;
            capacitorsForms.Add(this);
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Capacitors capacitors = new Capacitors();
            capacitors.Group.group = comboBox1.Text;
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            string[] range = capacitors.Group.subGroup.ToArray();
            comboBox2.Items.AddRange(range);
            comboBox3.Items.Clear();
            comboBox3.Text = "";
            //Text = Невозможно вычислить выражение, поскольку код текущего метода оптимизирован.
        }
    }
}
