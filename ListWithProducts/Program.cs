using System.Collections;

namespace ListWithProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList products = new ArrayList();
            products.Add("papers");
            products.Add("tomatoes");
            products.Add("eggplants");
            ArrayList prices = new ArrayList();
            prices.Add(2.20);
            prices.Add(1.50);
            prices.Add(3.40);
            ArrayList qty = new ArrayList();
            qty.Add(5);
            qty.Add(2);
            qty.Add(1);

        }
    }
}