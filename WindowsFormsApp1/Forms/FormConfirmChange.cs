using GA_Travelling_Salesman.Travelling_Salesman;
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
    public partial class FormConfirmChange : Form
    {
        Action onSave;
        Action onCancel;

        public FormConfirmChange(Action onSave, Action onCancel = null )
        {
            InitializeComponent();
            this.onSave = onSave;
            this.onCancel = onCancel;
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            onSave?.Invoke();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            onCancel?.Invoke();
            this.Close();
        }
    }
}
