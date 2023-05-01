using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace НадёжностьЭлементов
{
    public partial class ResistorForm : Form
    {
        List<Form> resistorForms;
        ListBox listBox;
        string pathtocd = Environment.CurrentDirectory + "\\texts";
        private bool isCreate = false;
        public ResistorForm(ref List<Form> refToList, ref ListBox refToLB)
        {
            resistorForms = refToList;
            listBox = refToLB;
            InitializeComponent();
            MakeUnEnable();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Resistors res = new Resistors();
            ComboBox_resistorsView.Items.AddRange(res.DBReading().ToArray());
            res.ResistorsGroup(ComboBox_resistorsView);
            comboBox2.Items.Clear();
            comboBox2.Text = null;
            comboBox2.Items.AddRange(res.resistor.subGroups);
            comboBox3.Items.Clear();
            comboBox3.Text = null;
            MakeUnEnable();
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            MakeUnEnable();
            Resistors res = new Resistors();
            res.resistor.groupName = ComboBox_resistorsView.Text;
            res.ResistorsSubGroups(comboBox2);
            comboBox3.Items.Clear();
            comboBox3.Text = null;
            comboBox3.Items.AddRange(res.resist.type);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Resistors res = new Resistors();
            res.resistor.groupName = ComboBox_resistorsView.Text;
            res.resist.subGroupName = comboBox2.Text;
            res.type = comboBox3.Text;
            SetKR();
            MakeEnable();
            if (comboBox2.SelectedItem.ToString().Contains("Металлодиэлектрические"))
                Allowance();
        }
        private void SetKR()
        {
            comboBox4.Items.Clear();
            StreamWriter filew = new StreamWriter(pathtocd + @"\KR.txt");
            filew.Write(Properties.Resources.KR);
            filew.Close();
            StreamReader reader = new StreamReader(pathtocd + @"\KR.txt");

            string[] diapazon = null;
            while (true)
            {
            metka0: if (ComboBox_resistorsView.Text == reader.ReadLine())
                {
                metka1: if (reader.ReadLine().Contains(comboBox2.Text))
                    {
                        diapazon = reader.ReadLine().Split(',');
                        break;
                    }
                    else goto metka1;
                }
                else goto metka0;
            }
            reader.Close();
            comboBox4.Items.AddRange(diapazon);
        }

        private void Allowance()
        {
            comboBox5.Items.Clear();
            StreamWriter filew = new StreamWriter(pathtocd + @"\Допуск.txt");
            filew.Write(Properties.Resources.Допуск);
            filew.Close();
            StreamReader reader = new StreamReader(pathtocd + @"\Допуск.txt");
            string[] diapazon = null;
            while (true)
            {
                if (reader.ReadLine().Contains(comboBox2.Text))
                {
                    diapazon = reader.ReadLine().Split(';');
                    comboBox5.Items.AddRange(diapazon);
                    break;
                }
            }
            reader.Close();
        }

        private void MakeEnable()
        {
            if (comboBox2.SelectedItem.ToString().Contains("Металлодиэлектрические"))
            {
                label5.Enabled = true;
                comboBox5.Enabled = true;
                label7.Enabled = true;
                comboBox7.Enabled = true;
            }
            label4.Enabled = true;
            comboBox4.Enabled = true;
            label6.Enabled = true;
            comboBox6.Enabled = true;
        }
        private void MakeUnEnable()
        {
            comboBox4.Text = null;
            comboBox5.Text = null;
            comboBox6.Text = null;
            comboBox7.Text = null;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
            comboBox6.Enabled = false;
            comboBox7.Enabled = false;
            label4.Enabled = false;
            label5.Enabled = false;
            label6.Enabled = false;
            label7.Enabled = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            foreach (Control cb in Controls)
            {
                if (cb is ComboBox)
                    if (cb.Enabled && (cb.Text == "" || cb.Text == null))
                    {
                        MessageBox.Show("Все параметры должны быть введены!", "Ошибка");
                        return;
                    }
            }
            if (!isCreate)
            {
                resistorForms.Add(this);
                listBox.Items.Add(comboBox3.Text);
                isCreate = true;
            }
            else
            {
                listBox.Items[listBox.SelectedIndex] = comboBox3.Text;
            }
            Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ResistorForm_VisibleChanged(object sender, EventArgs e)
        {
            if (isCreate)
            {
                buttonBack.Hide();
                buttonBack.Enabled = false;
                buttonAdd.Text = "Изменить";
            }
        }
    }
}

