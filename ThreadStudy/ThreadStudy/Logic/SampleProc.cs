namespace ThreadStudy.Logic
{
    public static class SampleProc
    {
        public static void SampleProcess(object obj)
        {
            var tc = (ThreadClass)obj;
            Console.WriteLine(tc.Sum());
        }
    }
}
