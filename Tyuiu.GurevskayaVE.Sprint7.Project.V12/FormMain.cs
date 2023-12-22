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

        DataService ds = new DataService();

        //метод чтения данных из файла
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
            dataGridViewIn_GVE.Rows.Clear();
            dataGridViewIn_GVE.Columns.Clear();

            // добавляем столбцы в DataGridView
            for (int i = 0; i < dataArray.GetLength(1); i++)
            {
                dataGridViewIn_GVE.Columns.Add("", dataArray[0, i]);
            }

            // добавляем строки с данными из CSV файла
            for (int i = 1; i < dataArray.GetLength(0); i++)
            {
                List<string> rowData = new List<string>();
                for (int j = 0; j < dataArray.GetLength(1); j++)
                {
                    rowData.Add(dataArray[i, j]);
                }
                dataGridViewIn_GVE.Rows.Add(rowData.ToArray());
            }
        }
        private void buttonOpen_GVE_Click(object sender, EventArgs e)
        {
            // получаем путь к файлу с помощью окна
            OpenFileDialog openFileDialog_GVE = new OpenFileDialog();
            openFileDialog_GVE.Filter = "csv Files|*.csv"; // фильтр для отображения только csv файлов
            if (openFileDialog_GVE.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog_GVE.FileName;

                // загружаем данные в DataGridView с помощью метода LoadDataIntoDataGridView
                LoadDataIntoDataGridView(filePath);
            }
            buttonSortData_GVE.Enabled = true;
            buttonSave_GVE.Enabled = true;
            buttonStat_GVE.Enabled = true;
            buttonSortAlp_GVE.Enabled = true;
        }

        private void buttonInfo_GVE_Click(object sender, EventArgs e)
        {
            FormAbout formabout = new FormAbout();
            formabout.ShowDialog();
        }
        

        //поиск по таблице
        private void textBoxFind_GVE_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textBoxFind_GVE.Text.ToLower(); //регистронезависимость

            foreach (DataGridViewRow row in dataGridViewIn_GVE.Rows)
            {
                if (row.IsNewRow) continue; // проверка добавленных строк

                bool found = false;

                for (int j = 0; j < dataGridViewIn_GVE.Columns.Count; j++)
                {
                    if (row.Cells[j].Value != null && row.Cells[j].Value.ToString().ToLower().Contains(searchValue))
                    {
                        found = true;
                        break;
                    }
                }

                row.Visible = found; // видимость\невидимость строк
            }
        }

        private void buttonStat_GVE_Click(object sender, EventArgs e)
        {
            FormStat formstat = new FormStat();
            formstat.ShowDialog();
        }

        private void buttonSortAlp_GVE_Click(object sender, EventArgs e)
        {
            dataGridViewIn_GVE.Sort(dataGridViewIn_GVE.Columns[0], ListSortDirection.Ascending); //сортировка названий
        }

        private void buttonSortData_GVE_Click(object sender, EventArgs e)
        {
            dataGridViewIn_GVE.Sort(dataGridViewIn_GVE.Columns[6], ListSortDirection.Ascending); //сортировка по году
        }
        private void buttonInfo_GVE_MouseEnter(object sender, EventArgs e)
        {
            toolTip_GVE.ToolTipTitle = "Справка";
        }
        private void buttonOpen_GVE_MouseEnter(object sender, EventArgs e)
        {
            toolTip_GVE.ToolTipTitle = "Открыть файл";
        }

        //сохранение файла
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

            string str = "Название;Фирма;Процессор;Количество ядер;Объем ОЗУ (ГБ);Диагональ;Дата выпуска\n";
            for (int i = 0; i < rows-1; i++)
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

            if (dialogres == DialogResult.Yes) //открытие файла
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
