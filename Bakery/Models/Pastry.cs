//Bussiness Logic

using System;
namespace Bakery.Models
{
    public class Pastry
    {


       public int Pastrys { get; set; }
    public Pastry() { }

    public Pastry(int numOfPastrys)
    {
        Pastrys = numOfPastrys;
    }

    public int PastryCost()
    {
        int costOfPastry = 0;
        if (Pastrys >= 3)
        {
            int numberOfMultiples = Pastrys / 4;
            int remainder = Pastrys % 4;
            costOfPastry = (numberOfMultiples * 6) + (remainder * 2);
        }
        else
        {
            costOfPastry = Pastrys * 2;
        }
        return costOfPastry;
    }
}
}