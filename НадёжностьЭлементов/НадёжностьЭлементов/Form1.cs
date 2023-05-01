using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace НадёжностьЭлементов
{
    public partial class Form1 : Form
    {
        public Form1(List<MainTitle.selectedItems> elements)
        {
            InitializeComponent();
            comboBox1.Items.Clear();
            foreach (MainTitle.selectedItems item in elements)
                this.elements.Add(item.element);
            foreach (string el in this.elements)
                comboBox1.Items.Add(el);
        }

        List<string> elements = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Резисторы")
            {
                if (checkBox1.Checked)
                {
                    File.WriteAllBytes(@"\Справочник резисторов", Properties.Resources.Справочник_резисторов);
                    System.Diagnostics.Process.Start(@"\Справочник резисторов");
                }
                new ElementsForm("Резисторы").Show();
            }
            if (comboBox1.Text == "Конденсаторы")
            {
                if (checkBox1.Checked)
                {
                    File.WriteAllBytes(@"\Справочник конденсаторов", Properties.Resources.Справочник_конденсаторов);
                    System.Diagnostics.Process.Start(@"\Справочник конденсаторов");
                }
                new ElementsForm("Конденсаторы").Show();
            }
        }
    }
}


