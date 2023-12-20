using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.GurevskayaVE.Sprint7.Project.V12
{
    public partial class FormBrowser : Form
    {
        public FormBrowser()
        {
            InitializeComponent();
        }
        private void radioButtonApple_GVE_CheckedChanged(object sender, EventArgs e)
        {
            string url = "https://ru.wikipedia.org/wiki/Apple"; 
            webBrowser_GVE.Navigate(url);
        }

        private void radioButtonHUAWEI_GVE_CheckedChanged(object sender, EventArgs e)
        {
            string url = "https://ru.wikipedia.org/wiki/Huawei";
            webBrowser_GVE.Navigate(url);
        }

        private void radioButtonIrbis_GVE_CheckedChanged(object sender, EventArgs e)
        {
            string url = "https://www.irbis-digital.ru/about"; 
            webBrowser_GVE.Navigate(url);
        }

        private void radioButtonLenovo_GVE_CheckedChanged(object sender, EventArgs e)
        {
            string url = "https://ru.wikipedia.org/wiki/Lenovo"; 
            webBrowser_GVE.Navigate(url);
        }

        private void radioButtonAsus_GVE_CheckedChanged(object sender, EventArgs e)
        {
            string url = "https://ru.wikipedia.org/wiki/Asus"; 
            webBrowser_GVE.Navigate(url);
        }

        private void radioButtonHonor_GVE_CheckedChanged(object sender, EventArgs e)
        {
            string url = "https://ru.wikipedia.org/wiki/Honor_(%D0%B1%D1%80%D0%B5%D0%BD%D0%B4)"; 
            webBrowser_GVE.Navigate(url);
        }

        private void radioButtonMSI_GVE_CheckedChanged(object sender, EventArgs e)
        {
            string url = "https://ru.wikipedia.org/wiki/Micro-Star_International"; 
            webBrowser_GVE.Navigate(url);
        }
    }
}
