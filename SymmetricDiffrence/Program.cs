using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymmetricDiffrence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> ints = new List<List<int>>();
            ints.Add(new List<int> { 1,2,5});
            ints.Add(new List<int> { 2,3,5});
            ints.Add(new List<int> { 3,4,5 });

            calcSymettry(ints).ForEach(x=>Console.WriteLine(x));
            Console.ReadKey();

        }

        public static List<int> calcSymettry(List<List<int>> ints )
        {
            int numberOfSets = ints.Count;
            List<int> finalSet = new List<int>();
            for (int i = 0; i < numberOfSets-1; i++)
            {
                int setlength = ints[i].Count;
                List<int> firstSet = new List<int>();
                List<int> secondSet = new List<int>();
                if (i == 0)
                    firstSet.AddRange(ints[i]);
                else
                    firstSet.AddRange(finalSet);
                secondSet.AddRange(ints[i + 1]);
                finalSet.Clear();
                
                foreach (int item in firstSet)
                { 
                if(!secondSet.Contains(item)&&!finalSet.Contains(item))
                        finalSet.Add(item);             
                
                
                }
                foreach (int item in secondSet)
                {
                    if (!firstSet.Contains(item) && !finalSet.Contains(item))
                        finalSet.Add(item);


                }



            }
            finalSet.Sort();
            return finalSet;



        }
    }
}
