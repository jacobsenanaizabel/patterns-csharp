using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.FactoryDemo;
using DesignPatterns.StrategyDemo;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            /*STRATEGY PATTERN 
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
            */

            DocumentFactory[] documents = new DocumentFactory[2];

            documents[0] = new Report();
            documents[1] = new Report();

            foreach (DocumentFactory document in  documents)
            {
                Console.WriteLine("\n "+ document.GetType().Name + " -- ");

                foreach (Page page in document.Pages)
                {
                    Console.WriteLine(" "+ page.GetType().Name);
                }
            }
            
            Console.ReadKey();
        }
    }
}
