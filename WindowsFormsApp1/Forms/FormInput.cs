using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormInput : Form
    {
        Action<int> onSave;

        public FormInput(string message, int defaultNumPoints, Action<int> onSave, int minValue = 0, int maxValue = 100000)
        {
            InitializeComponent();
            this.onSave = onSave;
            this.labelMessage.Text = message;
            this.numericUpDownInput.Value = defaultNumPoints;
            this.numericUpDownInput.Minimum = minValue;
            this.numericUpDownInput.Maximum = maxValue;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            onSave((int)numericUpDownInput.Value);
            this.Close();
        }
        
    }
}
