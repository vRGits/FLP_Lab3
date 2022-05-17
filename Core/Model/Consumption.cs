using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    public class Consumption
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int ProductId { get; set; }

        [ForeignKey("ProductId")]

        public Product Product { get; set; }

        public double Portion { get; set; }

        public DateTime Date { get; set; }

        public Time Time { get; set; }
    }

    public enum Time
    {
        anyTime = 0,
        morning = 1,
        day = 2,
        evening = 3
    }
}
