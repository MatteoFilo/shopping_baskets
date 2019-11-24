using System;
namespace shopping_baskets
{
    public class Item
    {
        public int qty;
        public string name;
        public bool taxable;
        public bool imported;
        public float price;

        public double Calcola()
        {
            double ret = System.Math.Round(qty * price, 2, MidpointRounding.AwayFromZero);
            if (taxable)
            {
                if (imported)
                {

                    ret = ret * 1.15;
                }
                else
                {
                    ret = ret * 1.10;
                }
            }
            else
            {
                if (imported)
                {

                    ret = ret * 1.05;
                }
            }
            ret = System.Math.Round(ret, 2, MidpointRounding.AwayFromZero);
            return ret;   
        }

        
    }
}
