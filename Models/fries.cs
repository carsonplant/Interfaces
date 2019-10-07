using System.Collections.Generic;
using burgershack.Interfaces;
using burgershack.Models;

namespace Interfaces.Models
{
  public class Fries : FoodItem, IConsumable, ISize
  {
    public string FryCut { get; set; }
    public double SizeMultiplier { get; set; }
    public Fries(string name, int calories, int fat, int protien, int carbohydrates) : base(name, calories, fat, protien, carbohydrates)
    {
    }


    public double GetPrice(Size s)
    {
      throw new System.NotImplementedException();
    }
  }
}