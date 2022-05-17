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
    public partial class ProductControl : UserControl
    {
        private Product? _product;

        public Product? Product
        {
            get 
            {
                return _product; 
            }
            set 
            { 
                _product = value;
                if(_product is null)
                {// for test
                    _product = new Product();
                    _product.Name = "some string";
                    _product.Proteins = 1;
                    _product.Carbohydrates = 1;
                    _product.Calories = 1;
                    _product.Fats = 1;
                }
                UpdateStat();
            }
        }

        public ProductControl()
        {
            InitializeComponent();
        }

        public void UpdateStat()
        {
            ProductName.Text = _product.Name;
            ProductCalories.Text = _product.Calories.ToString();
            ProductProteins.Text = _product.Proteins.ToString();
            ProductFats.Text = _product.Fats.ToString();
            ProductCarbohydrates.Text = _product.Carbohydrates.ToString();  
        }

        private void ProductControl_MouseClick(object sender, MouseEventArgs e)
        {
            SelectControl(sender, e);
        }

        private void SelectControl(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                SelectedControls.AddControl(this);
            }
            if(e.Button == MouseButtons.Right)
            {
                SelectedControls.RemoveControl(this);
            }
        }

        private void ProductLabels_MouseClick(object sender, MouseEventArgs e)
        {
            SelectControl(sender, e);
        }

        private void ProductName_Click(object sender, EventArgs e)
        {

        }
    }
}
