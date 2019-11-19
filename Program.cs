using System;
using System.Collections;

namespace shopping_baskets
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string row;
            ArrayList valore = new ArrayList();
            Console.WriteLine("Insert your shopping basket:");
            do
            {
                row = Console.ReadLine();
                Item itemRow = ReadString(row);
                valore.Add(itemRow); 
            } while (!String.IsNullOrWhiteSpace(row));

            foreach (Item val in valore)
                {
                Console.WriteLine(val);
            }
            

        }

        private static Item ReadString(string row)
        {

            Item RowItem = new Item();

            String[] elements = System.Text.RegularExpressions.Regex.Split(row, " ");
            foreach (var element in elements)
                if(element)

            return RowItem;
        }
    }
}

