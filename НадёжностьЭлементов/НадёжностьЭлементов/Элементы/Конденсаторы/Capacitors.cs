using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace НадёжностьЭлементов
{
    public class Capacitors
    {
        string pathtocd = Environment.CurrentDirectory + "\\texts";
        public Group_Subgroup Group;
        public Subgroup_Type SubGroup;
        public string type;

        public struct Group_Subgroup
        {
            public string group;
            public List<string> subGroup;
        }
        public struct Subgroup_Type
        {
            public string subGroup;
            public List<string> type;
        }
        public Capacitors()
        {
        }
        public void Search(string nameRes, out List<string> Groups, bool flag)
        {
            string line;
            List<string> temp = new List<string>();
            StreamWriter filew = new StreamWriter(pathtocd + @"\Гр_Подгр_конденсаторов.txt");
            filew.Write(Properties.Resources.Гр_Подгр_конденсаторов);
            StreamWriter filew_2 = new StreamWriter(pathtocd + @"\Подгр_Типы_конденсаторов.txt");
            filew_2.Write(Properties.Resources.Подрг_Типы_конденсаторов);
            filew.Close(); filew_2.Close();
            string path = flag ? pathtocd + @"\Гр_Подгр_конденсаторов.txt" : pathtocd + @"\Подгр_Типы_конденсаторов.txt";
            StreamReader st = new StreamReader(path);
        line: line = st.ReadLine();
            if (line == nameRes)
                line = st.ReadLine();
            else goto line;
            temp.AddRange(line.Split(','));
            Groups = temp;
            st.Close();
        }

       
    }
}
