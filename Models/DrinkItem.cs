using System;
using System.ComponentModel.DataAnnotations;
namespace CavuCafe.Models
{
    public class DrinkItem
    {
        [Key]
        public int DrinkItemId { get; set;}
        public string Name { get; set;}
        public double Price { get; set;}
        public string Description { get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;
    }
}