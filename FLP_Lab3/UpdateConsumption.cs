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
    public partial class UpdateConsumption : Form
    {
        Consumption _consumption;
        public UpdateConsumption(Consumption consumption)
        {
            InitializeComponent();
            _consumption = consumption;
        }

        private void UpdateConsumption_Load(object sender, EventArgs e)
        {
            label1.Text = _consumption.Product.Name;
            textBox1.Text = _consumption.Portion.ToString();
            dateTimePicker1.Value = _consumption.Date;
            comboBox1.SelectedItem = (int)_consumption.Time;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Выберете время");
            }
            try
            {
                _consumption.Portion = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка при вводе порции");
            }
            
            _consumption.Date = dateTimePicker1.Value.Date;
            _consumption.Time = (Time)comboBox1.SelectedItem;
            CompositionRoot.ConsumptionRepository.Update(_consumption);
        }
    }
}
