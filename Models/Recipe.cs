using System;
using System.ComponentModel.DataAnnotations;

namespace FareEats.Models
{
    public class Recipe
    {
        [Key]
        public int RecipeId {get; set;}

        public string Type {get; set;}

        public string Directions {get; set;}

        public string ImagePath {get; set;}
        
    }
}