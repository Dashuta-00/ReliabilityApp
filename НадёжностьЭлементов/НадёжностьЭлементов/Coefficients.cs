using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace НадёжностьЭлементов
{
    public partial class Coefficients : Form
    {
        string pathtocd = Environment.CurrentDirectory + "\\texts";
        private List<Form> listOfRes;
        public List<string> types = new List<string>();
        private List<double> failureRate = new List<double>();

        public Coefficients(List<Form> lrf)
        {
            listOfRes = lrf;
            InitializeComponent();
            Countings();
            Show();
        }
        public void Countings()
        {
            foreach (ResistorForm resForm in listOfRes)
            {
                groupName = resForm.ComboBox_resistorsView.Text;
                subGroupName = resForm.comboBox2.Text;
                type = resForm.comboBox3.Text;
                str_KR = resForm.comboBox4.Text;
                str_Km = resForm.comboBox7.Text;
                str_Kstab = resForm.comboBox5.Text;
                numbersOfResistors = Convert.ToInt32(resForm.comboBox6.Text);
                failureRate.Add(GetResult());
                types.Add(type);
            }
        }
        private string groupName;
        private string subGroupName;
        private string type;
        private double result { get; set; }
        private const float Кэ = 1.7f;
        private float Кпр = 1f;
        private double Кр = 1, Км = 1;
        private int temperature;
        private int electricLoad;
        private double lyambdaB = 1;
        private double KR = 1, KS1 = 1;
        private double Кстаб = 1;
        private int numbersOfResistors = 1;
        private string str_KR, str_Km, str_Kstab;

        private void Show()
        {
            label2.Visible = true;
            comboBox2.Visible = true;
            label2.Location = new System.Drawing.Point(32, 40);
            comboBox2.Location = new System.Drawing.Point(200, 40);
            label3.Visible = true;
            comboBox3.Visible = true;
            label3.Location = new System.Drawing.Point(32, 100);
            comboBox3.Location = new System.Drawing.Point(200, 100);
        }
        private void GetKp()
        {
            StreamReader reader = new StreamReader(pathtocd + @"\Коэффициент режима резисторов.txt");
            string[] tempMas = null;
            while (true)
            {
                if (groupName == reader.ReadLine())
                {
                    if (reader.ReadLine().Contains(subGroupName))
                    {
                        int sch = this.temperature;
                        while (sch >= 0)
                        {
                            reader.ReadLine();
                            sch--;
                        }
                        tempMas = reader.ReadLine().Split(',');
                        break;
                    }
                }
            }
            this.Кр = Convert.ToDouble(tempMas[electricLoad]);
        }
        private void GetLyambdaB()
        {
            StreamWriter filew = new StreamWriter(pathtocd + @"\ЛямбдаШтрихБ.txt");
            filew.Write(Properties.Resources.ЛямбдаШтрихБ);
            filew.Close();
            StreamReader reader = new StreamReader(pathtocd + @"\ЛямбдаШтрихБ.txt");
            while (true)
            {
            metka: if (groupName == reader.ReadLine())
                {
                metka2: if (subGroupName == reader.ReadLine())
                    {
                    metka3: if (reader.ReadLine().Contains(type))
                        {
                            this.lyambdaB = Convert.ToDouble(reader.ReadLine()) / 1000000;
                            break;
                        }
                        else goto metka3;
                    }
                    else goto metka2;
                }
                else goto metka;
            }
            reader.Close();
        }

        private double GetResult()
        {
            MakeKm();
            MakeKR();
            MakeKstab();
            GetLyambdaB();
            if (subGroupName == "Металлодиэлектрические (кроме прецизионных)" || subGroupName == "Металлодиэлектрические прецизионные")
                return result = lyambdaB * Кпр * Кр * Кэ * KR * Км * Кстаб * numbersOfResistors;
            else if (subGroupName == "Металлизированные" || subGroupName == "Композиционные пленочные" || subGroupName == "Композиционные объемные" ||
                subGroupName == "Нагрузочные" || subGroupName == "Прецизионные" || subGroupName == "Особостабильные" || subGroupName == "Металлофольговые")
                return result = lyambdaB * Кпр * Кр * Кэ * KR * numbersOfResistors;
            else if (groupName == "Резисторы переменные непроволочные")
                return result = lyambdaB * Кпр * Кр * Кэ * KR * KS1 * numbersOfResistors;
            else return result;
        }

        private void MakeKstab()
        {
            if (subGroupName == "Металлодиэлектрические резисторы (кроме прецизионных)")
            {
                if (str_Kstab == "0.5")
                    Кстаб = 2;
                else if (str_Kstab == "1,2,5,10 и более")
                    Кстаб = 1;
            }
            else if (subGroupName == "Металлодиэлектрические прецизионные")
            {
                if (str_Kstab == "0.05")
                    Кстаб = 5;
                else if (str_Kstab == "0.1")
                    Кстаб = 2.5;
                else if (str_Kstab == "0.25")
                    Кстаб = 1;
                else if (str_Kstab == "0.5")
                    Кстаб = 0.1;
                else if (str_Kstab == "1,2,5,10")
                    Кстаб = 0.05;
            }
        }

        private void MakeKR()
        {
            if (groupName == "Резисторы постоянные непроволочные")
            {
                if (subGroupName.Contains("Металлодиэлектрические") || subGroupName.Contains("Металлизированные"))
                {
                    if (str_KR == "<1 кОм")
                        KR = 1.0;
                    else if (str_KR == "[1; 100)кОм")
                        KR = 0.7;
                    else if (str_KR == "[0.1; 1]МОм")
                        KR = 2.0;
                    else if (str_KR == "≥1 МОм")
                        KR = 0.6;
                }
                else if (subGroupName.Contains("Композиционные пленочные"))
                {
                    if (str_KR == "≤10 МОм")
                        KR = 0.6;
                    else if (str_KR == ">10 МОм")
                        KR = 1.6;
                }
                else if (subGroupName.Contains("Композиционные объемные"))
                {
                    if (str_KR == "≤150 Ом")
                        KR = 0.9;
                    else if (str_KR == "(0.15; 10]кОм")
                        KR = 1.5;
                    else if (str_KR == "(0.01; 1]МОм")
                        KR = 0.7;
                }
            }
            else if (groupName == "Резисторы постоянные проволочные и металлофольговые")
                if (subGroupName == "Нагрузочные")
                {
                    if (str_KR == "≤1 кОм")
                        KR = 1.3;
                    else if (str_KR == "(1;10]кОм")
                        KR = 0.8;
                    else if (str_KR == "(10;100]кОм")
                        KR = 1.5;
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double b = 0;
            foreach (double a in failureRate)
                b += a;
            Result result = new Result(b, types, ref failureRate);
            result.Show();
            Close();
        }

        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            StreamWriter filew = new StreamWriter(pathtocd + @"\Коэффициент режима резисторов.txt");
            filew.Write(Properties.Resources.Коэффициент_режима_резисторов);
            filew.Close();
            StreamReader reader = new StreamReader(pathtocd + @"\Коэффициент режима резисторов.txt");
            this.temperature = (Convert.ToInt32(comboBox3.SelectedItem.ToString()) - 25) / 5;
            int temp = this.temperature;
            string[] diapazon = null;
            bool exit = false;
            while (!exit)
            {
                if (reader.ReadLine() == groupName)
                {
                    while (true)
                    {
                        if (reader.ReadLine().Contains(subGroupName))
                            while (temp >= 0)
                            {
                                diapazon = reader.ReadLine().Split(';');
                                temp--;
                            }
                        if (temp < 0)
                        {
                            exit = true; break;
                        }
                    }
                }
            }
            this.Кр = Convert.ToDouble(diapazon[electricLoad]);
            reader.Close();
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox7.Text == "≤ 0.8")
                KS1 = 1.0;
            else if (comboBox7.Text == "(0.8; 0.9]")
                KS1 = 1.05;
            else if (comboBox7.Text == "(0.9; 1.0]")
                KS1 = 1.2;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.electricLoad = Convert.ToInt32(Convert.ToDouble(comboBox2.SelectedItem.ToString()) * 10 - 1);
        }

        private void MakeKm()
        {
            if (str_Km == "0.062÷0.5")
                Км = 0.7;
            else if (str_Km == "1÷2")
                Км = 1.5;
            else if (str_Km == "5÷10")
                Км = 4.5;
        }
    }
}
