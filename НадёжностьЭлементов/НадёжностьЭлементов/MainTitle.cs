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
    public partial class MainTitle : Form
    {
        const int ELEMENT_NUMBER = 17;
        public struct Boxes
        {
            public CheckBox checkBox;
            public TextBox elementNumber;
            public TextBox typeNumber;
        }
        List<Boxes> boxes = new List<Boxes>();

        public MainTitle()
        {
            Directory.CreateDirectory(Environment.CurrentDirectory + "\\texts");
            CreationForm();
            InitializeComponent();
        }
        string[] elements = new string[ELEMENT_NUMBER]
        {
            "Интегральные микросхемы", "Полупроводниковые приборы", "Оптоэлектронные полупроводниковые приборы",
            "Изделия квантовой электроники", "Генераторные, модуляторные и регулирующие лампы","Трубки электроннолучевые приемные и преобразовательные",
            "Знакосинтезирующие индикаторы","Приборы фотоэлектронные", "Приборы фотоэлектрические", "Приборы пьезоэлектрические и фильтры электромеханические",
            "Резисторы", "Конденсаторы", "Трансформаторы", "Дроссели", "Линии задержки", "Лампы накачки", "Источники высокоинтенсивного оптического излучения"
        };
        public struct selectedItems
        {
            public int elementsCount;
            public int typeCount;
            public string element;

            public selectedItems(string elCount, string tyCount, string el)
            {
                elementsCount = Convert.ToInt32(elCount);
                typeCount = Convert.ToInt32(tyCount);
                element = el;
            }
        }
        List<selectedItems> selectedItemsList = new List<selectedItems>();
        List<CheckBox> checkBoxesList = new List<CheckBox>();
        private void CreationForm()
        {
            Label intr = new Label();
            intr.Text = "Отметьте необходимые элементы галочкой";
            intr.AutoSize = true;
            intr.Font = new Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            intr.Location = new Point(35, 10);
            Controls.Add(intr);
            int coordY = 45;
            Label typeCount = new Label();
            typeCount.Text = "Общее число\nэлементов";
            typeCount.Location = new Point(555, 0);
            typeCount.AutoSize = true;
            Controls.Add(typeCount);
            Label subTypeCount = new Label();
            subTypeCount.Text = "Число типов";
            subTypeCount.Location = new Point(665, 10);
            subTypeCount.AutoSize = true;
            Controls.Add(subTypeCount);

            for (int i = 0; i < elements.Length; ++i)
            {
                Boxes temp = new Boxes();
                Label label = new Label();
                label.Location = new Point(35, coordY);
                CheckBox checkBox = new CheckBox();
                checkBox.Width = 20;
                checkBox.Location = new Point(555, coordY);
                TextBox textBox1 = new TextBox();
                textBox1.Location = new Point(585, coordY);
                TextBox textBox2 = new TextBox();
                textBox2.Location = new Point(675, coordY);
                coordY += 40;
                label.AutoSize = true;
                textBox1.Width = 50;
                textBox2.Width = 50;
                label.Text = elements[i];
                checkBoxesList.Add(checkBox);
                temp.checkBox = checkBox;
                temp.elementNumber = textBox1;
                temp.typeNumber = textBox2;
                boxes.Add(temp);
                Controls.Add(label);
                Controls.Add(checkBox);
                Controls.Add(textBox1);
                Controls.Add(textBox2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int testing = 0;
            foreach (CheckBox box in checkBoxesList)
                if (!box.Checked)
                    testing++;
            if (testing == ELEMENT_NUMBER)
                MessageBox.Show("Заполните хотя бы одно поле!", "Ошибка!");
            if (IsCorrect())
            {
                for (int i = 0; i < elements.Length; ++i)
                    if (Controls[(i + 1) * 4 + 1].Text != "" && Controls[(i + 1) * 4 + 2].Text != "")
                        selectedItemsList.Add(new selectedItems(Controls[(i + 1) * 4 + 1].Text, Controls[(i + 1) * 4 + 2].Text, elements[i]));
                //for (int i = 0; i < elements.Length; ++i)
                //{
                //    if (checkBoxesList[i].Checked)
                //    {
                //        if (Controls[(i + 1) * 4 + 1].Text == "" || Controls[(i + 1) * 4 + 2].Text == "")
                //        {
                //            MessageBox.Show("Заполните отмеченные поля!", "Ошибка!");
                //            this.Hide();
                //            CreationForm();
                //        }

                //        else
                //        {
                //            IsCorrect();
                //            selectedItemsList.Add(new selectedItems(Controls[(i + 1) * 4 + 1].Text, Controls[(i + 1) * 4 + 2].Text, elements[i]));
                //        }
                //    }
                //}
                this.Hide();
                Form1 form1 = new Form1(selectedItemsList);
                form1.Show();
            }

        }
        private bool IsCorrect()
        {
            bool correct = false;
            foreach (Boxes box in boxes)
            {
                if (box.checkBox.Checked == true)
                {
                    try
                    {
                        Convert.ToInt32(box.elementNumber.Text);
                        Convert.ToInt32(box.typeNumber.Text);
                        correct = true;
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Введите в поля 'Число элементов' и 'Число типов' численное значение!");
                        box.elementNumber.Text = "";
                        box.typeNumber.Text = "";
                    }
                }
            }
            return correct;
        }
    }
}
