using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YHW0323CMSFormApp
{
    public partial class WorkerForm : Form
    {
        public WorkerForm()
        {
            InitializeComponent();
        }

        private void exitbtu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WorkerForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“_c_DataSet.tblWorker”中。您可以根据需要移动或移除它。
            this.tblWorkerTableAdapter.Fill(this._c_DataSet.tblWorker);

        }

        private void editbtu_Click(object sender, EventArgs e)
        {
            this._c_DataSet.tblWorker.Clear();
            

        }

        private void tblWorkerBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void sqlConnection1_InfoMessage(object sender, System.Data.SqlClient.SqlInfoMessageEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void savebtu_Click(object sender, EventArgs e)
        {
            
            
            MessageBox.Show("The worker table is update");
        }
    }
}
