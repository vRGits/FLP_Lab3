using Core.Repository;
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

namespace FLP_Lab3
{
    public partial class ProductForm : Form
    {
        private readonly IProductRepository _repository;
        private Product? _product;
        
        public ProductForm()
        {
            InitializeComponent();
            _repository = CompositionRoot.ProductRepository;
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            
        }
        public void SetProduct(Product? product = null)
        {
            if (product != null)
            {
                _product = product;
                tbName.Text = _product.Name;
                Calories.Text = _product.Calories.ToString();
                Proteins.Text = _product.Proteins.ToString();
                Fats.Text = _product.Fats.ToString();
                Carbohydrates.Text = _product.Carbohydrates.ToString();
            }
            else
            {
                _product = new Product();
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(_product == null) _product = new Product();
                _product.Name = tbName.Text;
                _product.Calories = Convert.ToInt32(Calories.Text);
                _product.Proteins = Convert.ToDouble(Proteins.Text);
                _product.Fats = Convert.ToDouble(Fats.Text);
                _product.Carbohydrates = Convert.ToDouble(Carbohydrates.Text);

            }
            catch (Exception ex)
            {
                lblMessage.Text = "Строка имела неверный формат";
                return;
            }
            
            if (_product.Id==0 && _repository.GetByName(_product.Name) != null)
            {
                lblMessage.Text = "Такой продукт уже есть в базе";
                return;
            }
            if (_product.Id == 0)
            {
                _repository.Add(_product);

                lblMessage.Text = "Успешно добавлено";
                return;
            }
            
            _repository.Update(_product);
            lblMessage.Text = "Успешно изменено";

        }
    }
}
