using System.Collections.Generic;
using burgershack.Interfaces;
using burgershack.Models;

namespace Interfaces.Models
{
  public class Fries : FoodItem, IPurchasable, ISize
  {

    public string FryCut { get; set; }
    public double BasePrice { get; set; }
    public double SizeMultiplier { get; set; }



    public double GetPrice(Size size)
    {
      return BasePrice + (SizeMultiplier * (int)size);
    }



    public Fries(string name, int calories, int fat, int protien, int carbohydrates, string cut, double price) : base(name, calories, fat, protien, carbohydrates)
    {
      FryCut = cut;
      BasePrice = price;

    }


  }
}