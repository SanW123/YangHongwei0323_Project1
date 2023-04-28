using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YHW0323CMSFormApp
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void jobDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JobDetailsForm5 job = new JobDetailsForm5();
            job.ShowDialog();
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void workerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkerForm workerform = new WorkerForm();
            workerform.ShowDialog();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm cus = new CustomerForm();
            cus.ShowDialog();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportsForm rep = new ReportsForm();
            rep.ShowDialog();
        }
    }
}
