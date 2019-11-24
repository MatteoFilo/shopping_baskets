﻿using System;
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
            double ret = qty * price;
            if (taxable)
            {
                if (imported)
                {

                    ret = qty * price * 1.15;
                }
                else
                {
                    ret = qty * price * 1.10;
                }
            }
            else
            {
                if (imported)
                {

                    ret = qty * price * 1.05;
                }
            }
            ret = Math.Round(ret,2);
            return ret;   
        }

        
    }
}
