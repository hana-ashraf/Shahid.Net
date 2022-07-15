using Crystal_Report_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace crystal_report2
{
    public partial class Form_Crystal_2 : Form
    {
        CrystalReport2 cr;
        public Form_Crystal_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = cr;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cr = new CrystalReport2();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 n = new Form1();
            n.ShowDialog();
        }
    }
}
