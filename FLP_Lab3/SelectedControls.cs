using FLP_Lab3.MyControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLP_Lab3
{
    public static class SelectedControls
    {
        private static List<ProductControl> myVar = new List<ProductControl>();
        public static Action<SelectedProductControl> MyAction { get; set; }

        public static void AddControl(ProductControl control)
        {
            control.BackColor = Color.FromArgb(192, 255, 192);
            myVar.Add(control);
        }
        public static void RemoveControl(ProductControl control)
        {
            control.BackColor = SystemColors.Control;
            myVar.Remove(control);
        }

        public static IEnumerable<ProductControl> GetAll()
        {
            return myVar;
        }

        public static void Clear()
        {
            //use ForEach
            foreach (var item in myVar)
            {
                item.BackColor = SystemColors.Control;
            }
            myVar.Clear();
        }

        public static void DeleteSelectedProductControl(SelectedProductControl control)
        {
            MyAction.Invoke(control);
        }
    }
}
