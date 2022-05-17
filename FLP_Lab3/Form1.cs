using Core.Model;
using FLP_Lab3.MyControls;
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
    public partial class Form1 : Form
    {
        private List<NotSelectedProductControl> _productControls;
        private List<SelectedProductControl> _selectedProducts;
        public Form1()
        {
            _productControls = new List<NotSelectedProductControl>();
            _selectedProducts = new List<SelectedProductControl>();
            SelectedControls.MyAction = DeleteSelectedControl;
            InitializeComponent();
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            var form = new ProductForm();
            form.ShowDialog();
        }

        private void ReadBd_Click(object sender, EventArgs e)
        {
            var products = CompositionRoot.ProductRepository.GetAll().OrderBy(p=>p.Name);
            if (products.Count() == 0)
            {
                MessageBox.Show("DB is empty");
                return;
            }
            foreach (var product in products)
            {
                NotSelectedProductControl control = new NotSelectedProductControl(product);
                _productControls.Add(control);
                flowLayoutPanelList.Controls.Add(control);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanelList.Controls.Clear();
            foreach (var control in _productControls)
            {
                if (control.GetProduct().Name.ToLower().StartsWith(textBox1.Text.ToLower()))
                {
                    flowLayoutPanelList.Controls.Add(control);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            foreach (var selected in SelectedControls.GetAll())
            {
                SelectedProductControl control = new SelectedProductControl(selected);
                _selectedProducts.Add(control);
                flowLayoutPanelSelected.Controls.Add(control);
            }
            SelectedControls.Clear();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Ошибка: Время не выбрано", "Error");
                return;
            }
            if(_selectedProducts.Count == 0)
            {
                MessageBox.Show("Ошибка: Продукты не выбраны", "Error");
                return;
            }
            List<Consumption> consumptions = new List<Consumption>();

            foreach (var item in _selectedProducts)
            {
                Consumption consumption = new Consumption();
                consumption.Date = dateTimePicker1.Value.Date;
                consumption.Time = (Time)comboBox1.SelectedIndex;
                consumption.Portion = item.GetPortion();
                consumption.Product = item.GetProduct();
                consumption.ProductId = consumption.Product.Id;
                consumptions.Add(consumption);

            }
            CompositionRoot.ConsumptionRepository.AddRange(consumptions);
            _selectedProducts.Clear();
            flowLayoutPanelSelected.Controls.Clear();
            MessageBox.Show("Успешно добавлено", "Message");
        }

        public void DeleteSelectedControl(SelectedProductControl control)
        {
            _selectedProducts.Remove(control);
            flowLayoutPanelSelected.Controls.Remove(control);
        }

        private void Stats_Click(object sender, EventArgs e)
        {
            StatsForm statsForm = new StatsForm();
            statsForm.Show();
            
        }
    }
}
