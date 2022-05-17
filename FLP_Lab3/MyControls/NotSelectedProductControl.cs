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
    public partial class NotSelectedProductControl : UserControl, IProductControl
    {
        public NotSelectedProductControl()
        {
            InitializeComponent();
            
        }
        public Product GetProduct()
        {
            return productControl1.Product;
        }
        public NotSelectedProductControl(Product product)
        {
            InitializeComponent();
            productControl1.Product = product;
        }

        private void productControl1_Load(object sender, EventArgs e)
        {
            
        }

        private void Update_Click(object sender, EventArgs e)
        {
            ProductForm form = new ProductForm();
            form.SetProduct(GetProduct());
            form.ShowDialog();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DeleteForm form = new DeleteForm(GetProduct());
            form.ShowDialog(this);
        }

        private void productControl1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
