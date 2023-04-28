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
    public partial class JobDetailsForm : Form
    {
        public JobDetailsForm()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textCarNo.Text.Length < 6)
            {
                MessageBox.Show("Please Specify a Valid car Number!");
                textCarNo.Focus();
                return;
            }
            try
            {
                if (Convert.ToInt32(textWorkerId.Text) < 1)
                {
                    MessageBox.Show("Please Specify a Valid worker Id!");
                    textWorkerId.Focus();
                    return;
                }

                if (Convert.ToDateTime(dateTimePicker1.Value) > DateTime.Today)
                {
                    MessageBox.Show("Please Specify Vaild Date! ");
                    dateTimePicker1.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textCarNo_Leave(object sender, EventArgs e)
        {
            if ((textCarNo.Text == "") || (textCarNo.Text == null))
            {
                MessageBox.Show("Please Specify a Valid Car Number!");
                textCarNo.Focus();
            }
        }
    }
}
