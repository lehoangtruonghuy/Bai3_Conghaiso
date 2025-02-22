using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3_Conghaiso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            double So1, So2, ketqua;
            So1 = Convert.ToDouble(txtso1.Text);
            So2 = Convert.ToDouble(txtso2.Text);
            ketqua = So1 + So2;
            txtkq.Text = ketqua.ToString();


        }
    }
}