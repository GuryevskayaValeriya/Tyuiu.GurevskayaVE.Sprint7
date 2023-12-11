using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Tyuiu.GurevskayaVE.Sprint7.Project.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        static string openFilePath;
        static int rows;
        static int colums;

        //DataService ds = new DataService();
        //метод чтения данных из файла
        private DataTable ReadCSVFile(string pathToCsvFile)
        {
            //создаём таблицу
            DataTable dt = new DataTable();
            //создаём колонки
            DataColumn colIVM;
            colIVM = new DataColumn("ЭВМ", typeof(String));
            DataColumn colName;
            colName = new DataColumn("Фирма", typeof(String));
            DataColumn colProc;
            colProc = new DataColumn("Процессор", typeof(String));
            DataColumn colYAD;
            colYAD = new DataColumn("Количество ядер", typeof(Int32));
            DataColumn colOZ;
            colOZ = new DataColumn("Объем ОЗУ", typeof(Int32));
            DataColumn colDIAG;
            colDIAG = new DataColumn("Диагональ", typeof(Double));
            DataColumn colYear;
            colYear = new DataColumn("Дата выпуска", typeof(Int32));
            //добавляем колонки в таблицу
            dt.Columns.AddRange(new DataColumn[] { colIVM, colName, colProc, colYAD, colOZ, colDIAG, colYear });
            try
            {
                DataRow dr = null;
                string[] ivmValues = null;
                string[] ivm = File.ReadAllLines(pathToCsvFile);
                for (int i = 0; i < ivm.Length; i++)
                {
                    if (!String.IsNullOrEmpty(ivm[i]))
                    {
                        ivmValues = ivm[i].Split(';');
                        //создаём новую строку
                        dr = dt.NewRow();
                        dr["ЭВМ"] = ivmValues[0];
                        dr["Фирма"] = ivmValues[1];
                        dr["Процессор"] = ivmValues[2];
                        dr["Количество ядер"] = int.Parse(ivmValues[3]);
                        dr["Объем ОЗУ"] = int.Parse(ivmValues[4]);
                        dr["Диагональ"] = Double.Parse(ivmValues[5]);
                        dr["Дата выпуска"] = int.Parse(ivmValues[6]);
                        //добавляем строку в таблицу
                        dt.Rows.Add(dr);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        private void buttonOpen_GVE_Click(object sender, EventArgs e)
        {
            dataGridViewIn_GVE.DataSource = ReadCSVFile(@"C:\Users\ВАЛЕРИЯ 2004\source\repos\Tyuiu.GurevskayaVE.Sprint7\Tyuiu.GurevskayaVE.Sprint7.Project.V12\bin\Debug\OutPutEC_Sprint7.csv");
        }

        private void buttonInfo_GVE_Click(object sender, EventArgs e)
        {
            FormAbout formabout = new FormAbout();
            formabout.ShowDialog();
        }
    }
}
