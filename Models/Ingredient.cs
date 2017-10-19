using System;
using System.ComponentModel.DataAnnotations;

namespace FareEats.Models
{
    public class Ingredient
    {
        [Key]
        public int IngredientId {get; set;}

        public string Name {get; set;}

        public int Quantity {get; set;}
    }
}