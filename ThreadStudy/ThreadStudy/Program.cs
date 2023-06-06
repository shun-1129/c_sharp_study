namespace ThreadStudy
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var tc = new thread_class();

            for (int i = 0; i < 10; i++)
            {
                var t = new Thread(new ParameterizedThreadStart(SampleProc));
                t.Start(tc);
            }
        }

        public static void SampleProc(object obj)
        {
            var tc = (thread_class)obj;
            Console.WriteLine(tc.Sum());
        }
    }

    public class thread_class
    {
        private int count;

        public int Sum()
        {
            count = 0;

            for (int i = 0; i < 10; i++)
            {
                count++;
            }

            return count;
        }
    }
}