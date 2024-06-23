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
    public partial class AddBus : Form
    {
        public Bus Bus {  get; set; }
        public AddBus()
        {
            InitializeComponent();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            Bus = new Bus(tbRegistration.Text, tbName.Text);
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if(tbName.Text.Length == 0)
            {
                errorProvider1.SetError(tbName, "Името не смее да биде со 0 карактери");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbName, null);
                e.Cancel = false;
            }
        }

        private void tbRegistration_Validating(object sender, CancelEventArgs e)
        {
            if(tbRegistration.Text.Length != 4)
            {
                errorProvider1.SetError(tbRegistration, "Регистрацијата мора да биде 4 цифри");
                e.Cancel= true;
            }
            else
            {
                string sh = tbRegistration.Text;
                foreach(char c in sh)
                {
                    if (!Char.IsDigit(c))
                    {
                        errorProvider1.SetError(tbRegistration, "Регистрацијата мора да содржи само цифри");
                        e.Cancel = true;
                        return;
                    }
                }
                errorProvider1.SetError(tbRegistration, null);
                e.Cancel = false;
            }
        }
    }
}
