using System;
using System.ComponentModel.DataAnnotations;

namespace FareEats.Models
{
    public class IngredientsUsed
    {
        [Key]
        public int IngredientsUsedId {get; set;}

        public int RecipeId {get; set;}

        public int IngredientId {get; set;}
    }
}