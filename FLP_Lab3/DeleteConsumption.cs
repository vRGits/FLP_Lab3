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
    public partial class DeleteConsumption : Form
    {
        Consumption _consumption;
        public DeleteConsumption(Consumption consumption)
        {
            InitializeComponent();
            _consumption = consumption;
        }

        private void DeleteConsumption_Load(object sender, EventArgs e)
        {
            label1.Text = $"Вы уверены, что хотите удалить из истории: " +
                $"{_consumption.Product.Name}\n{_consumption.Date}\n{_consumption.Time.ToString()}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CompositionRoot.ConsumptionRepository.Delete(_consumption);
            this.Close();
            MessageBox.Show("Успешно удалено");
        }
    }
}
