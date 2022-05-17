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
    public partial class StatsForm : Form
    {
        private IEnumerable<Consumption> consumption;
        private List<StatsControl> controls;
        public StatsForm()
        {
            InitializeComponent();
            controls = new List<StatsControl>();
        }

        private void StatsForm_Load(object sender, EventArgs e)
        {
            ShowConsumptions(DateTime.Now.Date);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.Date.AddDays(-1);
            ShowConsumptions(dateTimePicker1.Value);
        }
        private void ShowConsumptions(DateTime date)
        {
            double cal=0;
            double prot=0, fats=0, carb=0;
            consumption = CompositionRoot.ConsumptionRepository.GetByDate(date).OrderBy(t => t.Time);
            List<Consumption> test = consumption.ToList();
            flowLayoutPanel1.Controls.Clear();
            if (consumption.Count() == 0)
            {
                flowLayoutPanel1.Controls.Add(new Label() { Text = "Список за этот день пуст", Width = 200 });
                return;
            }
            string[] time = { "any time", "breakfest", "lunch", "dinner" };
            int i = -1;
            foreach (var item in consumption)
            {
                if (i < (int)item.Time)
                {
                    i = (int)item.Time;
                    Label lbl = new Label();
                    lbl.Text = time[i];
                    flowLayoutPanel1.Controls.Add(lbl);
   
                }
                StatsControl control = new StatsControl(item);
                cal += item.Product.Calories*item.Portion/100;
                prot += item.Product.Proteins * item.Portion / 100;
                fats += item.Product.Fats * item.Portion / 100;
                carb += item.Product.Carbohydrates * item.Portion / 100;
                controls.Add(control);
                flowLayoutPanel1.Controls.Add(control);
            }
            label1.Text = $"Итог дня: Калории {cal} Белки {prot}г. Жиры {fats}г. Углеводы {carb}г. ";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.Date.AddDays(1);
            ShowConsumptions(dateTimePicker1.Value);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ShowConsumptions(dateTimePicker1.Value.Date);
        }
    }
}
