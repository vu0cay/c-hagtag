using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class BookSales : Form
    {
        private clsBookSale mBookSale;
        public BookSales()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                clsBookSale mBookSale = new clsStudentBookSale(txtTitle.Text, Convert.ToInt32(txtQuantity.Text),
                                                        Convert.ToDecimal(txtPrice.Text), checkDiscount.Checked, checkStudent.Checked);
                
                txtExtended.Text = mBookSale.ExtendedPrice().ToString();
                txtDiscount.Text = mBookSale.DiscountAmout().ToString();
                txtNetDue.Text = mBookSale.NetDue().ToString();
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in quantity or price. " + ex.Message);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtExtended_TextChanged(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTitle.Text = null;
            txtQuantity.Text = null;
            txtPrice.Text = null;
            txtExtended.Text = null;

        }

        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = "Sales total: " + clsBookSale.SalesTotal.ToString() +
                         "\nSales count: " + clsBookSale.SalesCount.ToString();
            MessageBox.Show(str, "Sales description", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
