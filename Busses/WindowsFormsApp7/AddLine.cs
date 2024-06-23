using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class AddLine : Form
    {
        public Lines line {  get; set; }
        public AddLine()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            line = new Lines((int)nudHour.Value, (int)nudMinute.Value, (int)nudPrice.Value, tbDestination.Text);
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tbDestination_Validating(object sender, CancelEventArgs e)
        {
            if(tbDestination.Text.Length == 0)
            {
                errorProvider1.SetError(tbDestination, "Полето за дестинација не смее да биде празно!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbDestination, null);
                e.Cancel= false;
            }
        }
    }
}
