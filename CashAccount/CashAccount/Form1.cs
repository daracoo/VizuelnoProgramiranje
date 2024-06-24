using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashAccount
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            NewProduct newProduct = new NewProduct();
            if(newProduct.ShowDialog() == DialogResult.OK)
            {
                foreach(object obj in lbProducts.Items)
                {
                    Product product = (Product)obj;
                    if(product.Code == newProduct.product.Code)
                    {
                        MessageBox.Show("Продуктот веќе постои!");
                        return;
                    }
                }
                lbProducts.Items.Add(newProduct.product);
         
            }
        }

        private void btnAddReceipt_Click(object sender, EventArgs e)
        {
            Product selected = lbProducts.SelectedItem as Product;
            Item item = new Item(selected, (int)nudQuantity.Value);
            lbReceipt.Items.Add(item);
            calculateTotal();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if(lbReceipt.SelectedIndex != -1)
            {
                int selectedIndex = lbReceipt.SelectedIndex;
                DialogResult dg = MessageBox.Show("Izbrisi stavka", "Izbrisi", MessageBoxButtons.OKCancel);
                if(dg == DialogResult.OK)
                {
                    lbReceipt.Items.RemoveAt(selectedIndex);
                    calculateTotal();
                }
            }
        }

        private void calculateTotal()
        {
            float total = 0;
            foreach(object obj in lbReceipt.Items)
            {
                Item item = (Item)obj;
                total += item.Price();
            }
            tbTotal.Text = string.Format("{0}", total);
            tbToPay.Text = string.Format("{0:0.00}", total * (float)(1 + nudTax.Value / 100));
        }

        private void lbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }
    }
}
