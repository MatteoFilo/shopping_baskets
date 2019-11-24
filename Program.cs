using System;
using System.Collections;

namespace shopping_baskets
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string row;
            ArrayList Rows = new ArrayList();
            Console.WriteLine("Insert your shopping basket:");
            row = "";
            row = Console.ReadLine();
            while (row != string.Empty)
            {
                Item itemrow = ReadString(row);
                Rows.Add(itemrow);
                row = "";
                try
                    {
                    row = Console.ReadLine();
                }
                catch(EntryPointNotFoundException e)
                { }
            }
            float total = 0;
            foreach (Item val in Rows)
                {
                total = total + val.price;
                Console.WriteLine(val.qty + " " + val.name + ": " + val.price);
            }
            Console.WriteLine("Total: " + total);

        }

        private static Item ReadString(string row)
        {

            Item rowItem = new Item();

            int position = row.IndexOf(' ');

            rowItem.qty = Int32.Parse(row.Substring(0, position++));
            row = row.Substring(position);

            int positionNew = row.IndexOf(' ');
            position = 0;

            if ((row.IndexOf("imported") != -1))
            {
                rowItem.imported = true;
                position = positionNew;
                row = row.Substring(position++);
                position = 0;
            }
            else
            {
                rowItem.imported = false;
            }
            if (row.IndexOf("chocolate") != -1 || row.IndexOf("pill") != -1 || row.IndexOf("book") != -1)
            {
                rowItem.taxable = false;
            }
            else
            {
                rowItem.taxable = true;
            }
            positionNew = row.IndexOf(" at ");
            rowItem.name = row.Substring(position, positionNew);
            row = row.Substring(positionNew+3);

            rowItem.price = float.Parse(row.Replace(".",","));


            rowItem.price = (float)rowItem.Calcola();
            return rowItem;
        }
    }
}

