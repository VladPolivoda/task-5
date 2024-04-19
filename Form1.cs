using System;
using System.Windows.Forms;

namespace KeyApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Прізвище, Ім’я: Полівода Владислав\nГрупа: КН21к-1\nНомер варіанту: 21", "About");
        }
    }
}
