//Bussiness Logic

using System;
namespace Bakery.Models
{
    public class Bread
    {
        // public int Loaves { get; set; }

       public int Loaves { get; set; }

    public Bread() { }

    public Bread(int numOfLoaves)
    {
        Loaves = numOfLoaves;
    }

    public int BreadCost()
    {
        int costOfBread = 0;
        if (Loaves >= 3)
        {
            int numberOfMultiples = Loaves / 3;
            int remainder = Loaves % 3;
            costOfBread = (numberOfMultiples * 10) + (remainder * 5);
        }
        else
        {
            costOfBread = Loaves * 5;
        }
        return costOfBread;
    }
}
}