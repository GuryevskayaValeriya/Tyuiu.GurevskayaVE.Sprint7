using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.GurevskayaVE.Sprint7.Project.V12.Lib;


namespace Tyuiu.GurevskayaVE.Sprint7.Project.V12
{
    public partial class FormStat : Form
    {
        //метод чтения файла
        public static string[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;
            string[,] arrayValues = new string[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = line_r[c];
                }
            }

            return arrayValues;
        }

        private void LoadDataIntoDataGridView(string filePath)
        {
            // загружаем данные из файла с помощью метода LoadFromFileData
            string[,] dataArray = LoadFromFileData(filePath);

            // очищаем DataGridView перед загрузкой новых данных
            dataGridViewInStat_GVE.Rows.Clear();
            dataGridViewInStat_GVE.Columns.Clear();

            // добавляем столбцы в DataGridView
            for (int i = 0; i < dataArray.GetLength(1); i++)
            {
                dataGridViewInStat_GVE.Columns.Add("", dataArray[0, i]);
            }

            // добавляем строки с данными из CSV файла
            for (int i = 1; i < dataArray.GetLength(0); i++)
            {
                List<string> rowData = new List<string>();
                for (int j = 0; j < dataArray.GetLength(1); j++)
                {
                    rowData.Add(dataArray[i, j]);
                }
                dataGridViewInStat_GVE.Rows.Add(rowData.ToArray());
            }
        }

        string filePath = $@"{Directory.GetCurrentDirectory()}\InPutEC_Sprint7.csv"; 

        public FormStat()
        {
            InitializeComponent();
            LoadDataIntoDataGridView(filePath);
        }


        DataService ds = new DataService();
        private void buttonSredOZU_GVE_Click(object sender, EventArgs e)
        {
            string[,] dataArray = LoadFromFileData(filePath);
            textBoxSredOZU_GVE.Text = Convert.ToString(ds.SredOZU(dataArray));
        }

        private void buttonDiag_GVE_Click(object sender, EventArgs e)
        {
            chartDiag_GVE.Series[0].Points.Clear();
           
            foreach (DataGridViewRow row in dataGridViewInStat_GVE.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null) // проверяем что ячейки не пустые
                {
                    string xValue = row.Cells[0].Value.ToString(); // название эвм
                    double yValue = Convert.ToDouble(row.Cells[5].Value); // его диагональ

                    chartDiag_GVE.Series["Series1"].Points.AddXY(xValue, yValue); // добавляем 
                }
            }
            
        }

        private void buttonBigYadra_GVE_Click(object sender, EventArgs e)
        {
            string[,] dataArray = LoadFromFileData(filePath);
            textBoxYadra_GVE.Text = Convert.ToString(ds.MaxYadra(dataArray));
        }
    }
}
