using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadStudy.Logic
{
    public class ThreadClass
    {
        private int count;

        public int Sum()
        {
            count = 0;

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(10);
                count++;
            }

            return count;
        }
    }
}
