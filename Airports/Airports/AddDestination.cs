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
    public partial class AddDestination : Form
    {
        public Destination createdDestination;
        public AddDestination()
        {
            InitializeComponent();
        }

        private void AddDestination_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            createdDestination = new Destination(tbName.Text, (int)nudDistance.Value, (int)nudPrice.Value);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }
    }
}
