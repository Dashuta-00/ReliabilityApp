using Microsoft.Data.Sqlite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace НадёжностьЭлементов
{
    public class Resistors
    {
        string pathtocd = Environment.CurrentDirectory + "\\texts";
        public Group resistor;
        public subGroup resist;
        public string type;
        public void ResistorsGroup(ComboBox text)
        {
            resistor.groupName = text.Text;
            SearchGroups(resistor.groupName, out resistor.subGroups, false);
        }
        public void ResistorsSubGroups(ComboBox text)
        {
            resist.subGroupName = text.Text;
            SearchGroups(resist.subGroupName, out resist.type, true);
        }

        public struct subGroup
        {
            public string subGroupName;
            public string[] type;
        }
        public struct Group
        {
            public string groupName;
            public string[] subGroups;
        }
        public void SearchGroups(string nameRes, out string[] Groups, bool flag)
        {
            //resistorsTableBindingSource.ResistorsTableDataTable[0][0];
            string line;
            string[] temp = null;
            StreamWriter filew = new StreamWriter(pathtocd + @"\Наименование группы.txt");
            filew.Write(Properties.Resources.Наименование_группы);
            StreamWriter filew_2 = new StreamWriter(pathtocd + @"\Типы изделий по подгруппам.txt");
            filew_2.Write(Properties.Resources.Типы_изделий_по_подгруппам1);
            filew.Close(); filew_2.Close();
            string path = flag ? pathtocd + @"\Типы изделий по подгруппам.txt" : pathtocd + @"\Наименование группы.txt";
            StreamReader st = new StreamReader(path);
        line: line = st.ReadLine();
            if (line == nameRes)
                line = st.ReadLine();
            else goto line;
            temp = line.Split(',');
            Groups = temp;
            st.Close();
        }
        public List<string> DBReading()
        {
            //SqliteCommand command = new SqliteCommand();
            //command.ExecuteReader()
            //resistorsTableBindingSource resistorsTable = new resistorsTableBindingSource();
            string sqlExpression = "SELECT * FROM ResistorsTable";
            List<string> temp = new List<string>();
            int i = 1;
            using (var connection = new SqliteConnection(@"Data Source=D:\Надежность\Проект\НадёжностьЭлементов\НадёжностьЭлементов\Database.mdf"))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand(sqlExpression, connection);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())   // построчно считываем данные
                        {
                            temp.Append(reader.GetValue(i++));
                        }
                    }
                }
            }
            return temp;
        }
    }
}

