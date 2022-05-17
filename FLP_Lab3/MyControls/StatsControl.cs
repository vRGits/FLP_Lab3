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
    public partial class StatsControl : UserControl
    {
        Consumption _consumption;
        public StatsControl(Consumption consumption)
        {
            InitializeComponent();
            _consumption = consumption;
            StatsControl_Load();
        }
        public Consumption GetCons() => _consumption;
        private void Update_Click(object sender, EventArgs e)
        {
            UpdateConsumption updateConsumption = new UpdateConsumption(_consumption);
            updateConsumption.Show();
        }


        private void StatsControl_Load()
        {
            label1.Text = _consumption.Product.Name;
            label2.Text = _consumption.Product.Calories.ToString();
            label3.Text = _consumption.Product.Proteins.ToString();
            label4.Text = _consumption.Product.Fats.ToString();
            label5.Text = _consumption.Product.Carbohydrates.ToString();
            label6.Text = _consumption.Portion.ToString();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DeleteConsumption deleteConsumption = new DeleteConsumption(_consumption);
            deleteConsumption.Show();
        }

        private void StatsControl_Load(object sender, EventArgs e)
        {

        }
    }
}
