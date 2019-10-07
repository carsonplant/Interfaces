using System.Collections.Generic;
using burgershack.Interfaces;

namespace burgershack.Models
{
  public class Hotdog : FoodItem, IPurchasable
  {
    public double BasePrice { get; set; }
    public IEnumerable<string> Ingredients { get; set; }


    public Hotdog(string name, int calories, int fat, int protein, int carbohydrates, double price, IEnumerable<string> ingredients) : base(name, calories, fat, protein, carbohydrates)
    {
      BasePrice = price;
      Ingredients = ingredients;
    }



  }
}