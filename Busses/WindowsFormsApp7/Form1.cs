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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddBus_Click(object sender, EventArgs e)
        {
            AddBus addBus = new AddBus();
            if(addBus.ShowDialog() == DialogResult.OK )
            {
                lbBusses.Items.Add(addBus.Bus);
            }
        }

        private void btnDeleteBus_Click(object sender, EventArgs e)
        {
            if(lbBusses.SelectedIndex == -1)
            {
                return;
            }
            DialogResult dg = MessageBox.Show("Дали сте сигурни?", "Избриши", MessageBoxButtons.OKCancel);
             if(dg == DialogResult.OK)
             {
                int index = lbBusses.SelectedIndex;
                lbBusses.Items.RemoveAt(index);
             }
        }

        private void btnAddLine_Click(object sender, EventArgs e)
        {
            if (lbBusses.SelectedIndex != -1)
            {
                AddLine addLine = new AddLine();
                if (addLine.ShowDialog() == DialogResult.OK)
                {
                    Bus selectedBus = lbBusses.Items[lbBusses.SelectedIndex] as Bus;
                    selectedBus.Lines.Add(addLine.line);
                    loadLines();
                }
            }
        }

        public void loadLines()
        {
            lbLines.Items.Clear();
            tbAverage.Clear();
            tbMostExpensive.Clear();
            Bus bus = lbBusses.SelectedItem as Bus;
            if (bus != null && bus.Lines.Count > 0)
            {
                Lines maxPrice = bus.Lines[0];
                float totalPrice = 0;
                foreach (Lines line in bus.Lines)
                {
                    lbLines.Items.Add(line);
                    if (line.Price > maxPrice.Price)
                    {
                        maxPrice = line;
                    }
                    totalPrice += line.Price;
                }
                tbAverage.Text = string.Format("{0:#.0}", totalPrice / lbLines.Items.Count);
                tbMostExpensive.Text = maxPrice.ToString();
            }
        }

        private void lbBusses_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadLines();
        }

        private void lbBusses_SelectedValueChanged(object sender, EventArgs e)
        {
            loadLines();
        }
    }
}
