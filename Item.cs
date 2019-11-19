using System;
namespace shopping_baskets
{
    public class Item
    {
        int qty;
        string name;
        bool taxable;
        bool imported;
        float price;

        public double Calcola()
        {
            double ret;
            if (taxable)
            {
                if (imported)
                {

                    ret = price * 1.15;
                }
                else
                {
                    ret = price * 1.10;
                }
            }
            else
            {
                ret = price * 1.05;
            }
            return ret;   
        }

        
    }
}
