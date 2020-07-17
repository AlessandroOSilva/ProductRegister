using ProductRegister.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRegister.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        [MinLength(10)]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        [MinLength(10)]
        public string Type { get; set; }
        [Required]
        public double Price { get; set; }

        public Product(string name, string type, double price)
        {
            Name = name;
            Type = type;
            Price = price;
        }
    }
}
