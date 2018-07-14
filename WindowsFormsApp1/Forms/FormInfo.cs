using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Travelling_Salesman
{
    public partial class FormInfo : Form
    {

        public FormInfo(string info)
        {
            InitializeComponent();
            this.labelInfo.Text = info;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
