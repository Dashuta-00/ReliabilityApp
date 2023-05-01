using System;
using System.Windows.Forms;

namespace НадёжностьЭлементов
{
    public partial class Ratio : Form
    {
        float[] ratios = new float[10];
        float lyambda()
        {
            float result = 1;
            foreach (int i in ratios)
            {
                if (i != -1)
                {
                    result *= i;
                }
            }
            return result;
        }
        Label[] labels = new Label[10];
        ComboBox[] comboBoxes = new ComboBox[10];
        public Ratio(float Кпр = -1, float Кстаб = -1, float Кр = -1, float KS1 = -1,
            float Кэ = -1, float Ксл = -1, float KR = -1, float Ккорп = -1,
            float Км = -1, float Ктехн = -1)
        {
            ratios = new float[] { Кпр, Кстаб, Кр, KS1, Кэ, Ксл, KR, Ккорп, Км, Ктехн };
            InitializeComponent();
            labels = new Label[] {labelКпр, labelКстаб, labelКр, labelKS1, labelКэ,
                                  labelКсл, labelKR, labelКкорп, labelКм, labelКтехн};
            comboBoxes = new ComboBox[] { comboBox1, comboBox2, comboBox3, comboBox4, comboBox5,
                                          comboBox6, comboBox7, comboBox8, comboBox9, comboBox10,};

            for (int i = 0; i < 10; i++)
            {
                if (ratios[i] == -1)
                {
                    comboBoxes[i].Enabled = false;
                    labels[i].Enabled = false;
                }
            }
        }
    }
}
