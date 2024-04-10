using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airports
{
    public partial class AddAirport : Form
    {
        public Airport airport { get; set; }
        public AddAirport()
        {
            InitializeComponent();
        }

        private void AddAirport_Load(object sender, EventArgs e)
        {

        }

        private void tbCity_Validating(object sender, CancelEventArgs e)
        {
            if (tbCity.Text == "")
            {
                errorProvider1.SetError(tbCity, "Полето за град не смее да биде празно!");
            }
            else
            {
                errorProvider1.SetError(tbCity, null); // dokolku poleto ne e prazno
            }

        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text == "")
            {
                errorProvider1.SetError(tbName, "Полето за град не смее да биде празно!");
            }
            else
            {
                errorProvider1.SetError(tbName, null); // dokolku poleto ne e prazno
            }
        }

        private void tbCode_Validating(object sender, CancelEventArgs e)
        {
            if(tbCode.Text.Length == 3)
            {
                bool allUpperLetter = true;
                foreach(char c in tbCode.Text)
                {
                    if (Char.IsLower(c) || Char.IsLower(c))
                    {
                        allUpperLetter = false;
                        break;
                    }
                }
                if (allUpperLetter)
                {
                    errorProvider1.SetError(tbCode, null);
                }else
                {
                    errorProvider1.SetError(tbCode, "Сите карактери мора да се со големи букви!");
                }
            }
            else
            {
                errorProvider1.SetError(tbCode, "Кодот мора да биде точно три карактери!");
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.airport = new Airport(tbCode.Text, tbName.Text, tbCity.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
