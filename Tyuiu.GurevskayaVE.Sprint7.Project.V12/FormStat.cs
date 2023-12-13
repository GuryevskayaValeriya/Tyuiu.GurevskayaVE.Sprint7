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
using Tyuiu.GurevskayaVE.Sprint7.Project.V12;


namespace Tyuiu.GurevskayaVE.Sprint7.Project.V12
{
    public partial class FormStat : Form
    {
        public FormStat()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonSredOZU_GVE_Click(object sender, EventArgs e)
        {
            textBoxSredOZU_GVE.Text = "11,3 гб";
        }

        private void buttonDiag_GVE_Click(object sender, EventArgs e)
        {
            chartDiag_GVE.Series[0].Points.Clear();
            this.chartDiag_GVE.Series["Series1"].Points.AddXY("Apple MacBook Air 13 M1", 13.3);
            this.chartDiag_GVE.Series["Series1"].Points.AddXY("Lenovo IdeaPad Gaming 3", 16);
            this.chartDiag_GVE.Series["Series1"].Points.AddXY("Thunderobot 911 Air X", 15.6);
            this.chartDiag_GVE.Series["Series1"].Points.AddXY("ASUS M1502IA", 15.6);
            this.chartDiag_GVE.Series["Series1"].Points.AddXY("HONOR MagicBook X 16", 16);
            this.chartDiag_GVE.Series["Series1"].Points.AddXY("Irbis NB265", 14.1);
            this.chartDiag_GVE.Series["Series1"].Points.AddXY("Apple MacBook Pro 14", 14.2);
            this.chartDiag_GVE.Series["Series1"].Points.AddXY("HUAWEI Matebook D 15 i5", 15.6);
            this.chartDiag_GVE.Series["Series1"].Points.AddXY("MSI Katana GF76", 17.3);
        }
    }
}
