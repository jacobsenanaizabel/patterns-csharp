using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.StrategyDemo;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ListingContext listingContext = new ListingContext();

            listingContext.AddStudent("Exemplo 1 ");
            listingContext.AddStudent("Exemplo 2");
            listingContext.AddStudent("Exemplo 3");

            listingContext.setSortStrategy(new MergeSortConcrete());
            listingContext.Sort();

            listingContext.setSortStrategy(new ShellShortConcrete());
            listingContext.Sort();

            listingContext.setSortStrategy(new QuickSortConcrete());
            listingContext.Sort();

            Console.ReadKey();
        }
    }
}
