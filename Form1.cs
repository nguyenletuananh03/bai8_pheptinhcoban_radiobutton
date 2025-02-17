using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai8_pheptinhcoban_radiobutton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            double so1 = double.Parse(txtso1.Text);
            double so2 = double.Parse(txtso2.Text);
            if (rdbcong.Checked )
            {
                txtKQ.Text =(so1 + so2).ToString();
            }
            if (rdbtru.Checked)
            {
                txtKQ.Text = (so1 - so2).ToString();
            }
            if (rdbnhan.Checked)
            {
                txtKQ.Text = (so1 * so2).ToString();
            }
            if (rdbchia.Checked)
            {
                if (so2 == 0)
                {
                    txtKQ.Text = "lỗi chia 0";
                }
                else
                {
                    txtKQ.Text =(so1 / so2).ToString();
                }

            }
        }
    }
}
