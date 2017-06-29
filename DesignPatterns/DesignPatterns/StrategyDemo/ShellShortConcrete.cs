using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyDemo
{
    class ShellShortConcrete : ISortStrategy
    {
        public void Sort(List<string> list)
        {
            Console.WriteLine("ShellShort choose!");
        }
    }
}
