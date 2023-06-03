using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreadStudy.Logic;

namespace ThreadStudy
{
    public class Worker
    {
        public Worker()
        {
        }

        public void Executor()
        {
            Console.WriteLine("multiple thread study start");

            var tc = new ThreadClass();

            for (int i = 0; i < 10; i++)
            {
                SampleProc.SampleProcess(tc);
            }
        }
    }
}
