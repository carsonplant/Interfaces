using burgershack.Interfaces;

namespace burgershack.Models
{
  public class drink : IConsumable, ISize
  {
    public int Calories { get; set; }
    public int Fat { get; set; }
    public int Protien { get; set; }
    public int Carbohydrates { get; set; }
    public double SizeMultiplier { get; set; }
    public double BasePrice { get; set; }

    public double GetPrice(Size size)
    {
      return BasePrice + (SizeMultiplier * (int)size);
    }
  }
}