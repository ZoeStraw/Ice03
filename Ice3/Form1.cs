using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ice3
{
    public partial class frmIce3 : Form
    {
        public frmIce3()
        {
            InitializeComponent();
        }

        private void frmIce3_Load(object sender, EventArgs e)
        {
            txtOutput.Text = "Ice3 Version 1.0";
        }
    }
}
