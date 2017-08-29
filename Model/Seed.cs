using System.Linq;

namespace e190.Model
{
    public static class Seed
    {
        public static void Init(PieContext context)
        {
            if (!context.Pies.Any())
            {
               context.Pies.Add(new Pie { Filling = "Apple", IsSweet = true });
               context.Pies.Add(new Pie { Filling = "Custard", IsSweet = true });
               context.Pies.Add(new Pie { Filling = "Fish", IsSweet = false });
               context.Pies.Add(new Pie { Filling = "Steak & Kidney", IsSweet = false });
               context.SaveChanges();
            }
        }
    }
}