using Core.Model;
using Core.Repository;
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
    public partial class DeleteForm : Form
    {
        private readonly IProductRepository _repository;
        private Product _product;

        public DeleteForm(Product product)
        {
            InitializeComponent();
            _product = product;
            _repository = CompositionRoot.ProductRepository;
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            label1.Text = $"Вы уверены, что хотите удалить \n{_product.Name}\nКалорийность : {_product.Calories}\n" +
                $"Белки : {_product.Proteins}\nЖиры : {_product.Fats}\n Углеводы : {_product.Carbohydrates}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _repository.Delete(_product);
            label1.Text = "Успешно удалено";
            button1.Enabled = false;
            button2.Enabled = false;
        }
    }
}
