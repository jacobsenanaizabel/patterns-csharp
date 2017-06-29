using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyDemo
{
    public class ListingContext
    {
        //mantem a referencia que pode ser uma Interface ou classe abstrata 
        private ISortStrategy _sortStrategy;
        private List<String> _list = new List<string>();


        public void setSortStrategy(ISortStrategy sortStrategy)
        {
           this. _sortStrategy = sortStrategy;
        }

        public void AddStudent(string name)
        {
            _list.Add(name);
        }

        public void Sort()
        {
            _sortStrategy.Sort(_list);

            foreach (string name in _list)
            {
                Console.WriteLine(" " + name);
            }

            Console.WriteLine();
        }

    }
}
