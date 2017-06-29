using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace DesignPatterns.StrategyDemo
{
    public interface ISortStrategy
    {
        void Sort(List<string> list);
    }
}