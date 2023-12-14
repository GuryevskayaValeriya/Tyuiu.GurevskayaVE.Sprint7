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
using Tyuiu.GurevskayaVE.Sprint7.Project.V12.Lib;

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
            colOZ = new DataColumn("Объем ОЗУ (ГБ)", typeof(Int32));
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
                        dr["Объем ОЗУ (ГБ)"] = int.Parse(ivmValues[4]);
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
            dataGridViewIn_GVE.DataSource = ReadCSVFile(@"C:\Users\ВАЛЕРИЯ 2004\source\repos\Tyuiu.GurevskayaVE.Sprint7\Tyuiu.GurevskayaVE.Sprint7.Project.V12\bin\Debug\InPutEC_Sprint7.csv");
        }

        private void buttonInfo_GVE_Click(object sender, EventArgs e)
        {
            FormAbout formabout = new FormAbout();
            formabout.ShowDialog();
        }

        private void textBoxFind_GVE_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (dataGridViewIn_GVE.DataSource as DataTable).DefaultView.RowFilter = $"ЭВМ LIKE '%{textBoxFind_GVE.Text}%'";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonStat_GVE_Click(object sender, EventArgs e)
        {
            FormStat formstat = new FormStat();
            formstat.ShowDialog();
        }

        private void buttonSortAlp_GVE_Click(object sender, EventArgs e)
        {
            this.dataGridViewIn_GVE.Sort(this.dataGridViewIn_GVE.Columns["ЭВМ"], ListSortDirection.Ascending);
        }

        private void buttonSortData_GVE_Click(object sender, EventArgs e)
        {
            this.dataGridViewIn_GVE.Sort(this.dataGridViewIn_GVE.Columns["Дата выпуска"], ListSortDirection.Ascending);
        }

        private void buttonSave_GVE_Click(object sender, EventArgs e)
        {
            saveFileDialog_GVE.FileName = "OutPutIVM.csv";
            saveFileDialog_GVE.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_GVE.ShowDialog();

            string path = saveFileDialog_GVE.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewIn_GVE.RowCount;
            int columns = dataGridViewIn_GVE.ColumnCount;

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewIn_GVE.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewIn_GVE.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }

            DialogResult dialogres = MessageBox.Show("Файл " + path + " сохранен успешно!\nОткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogres == DialogResult.Yes)
            {
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }
        }

        private void buttonFirma_GVE_Click(object sender, EventArgs e)
        {
            FormFirma formfirma = new FormFirma();
            formfirma.ShowDialog();
        }
    }
}
