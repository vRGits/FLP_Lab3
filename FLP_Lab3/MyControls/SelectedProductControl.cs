using Core.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLP_Lab3.MyControls
{
    public partial class SelectedProductControl : UserControl
    {
        public SelectedProductControl(ProductControl control)
        {
            InitializeComponent();
            productControl1.Product = control.Product;
        }

        public Product GetProduct() => productControl1.Product;

        public int GetPortion()
        {
            try
            {
                return Convert.ToInt32(textBox1.Text);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void SelectedProductControl_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SelectedControls.DeleteSelectedProductControl(this);
            this.Dispose();
        }

        private void productControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
