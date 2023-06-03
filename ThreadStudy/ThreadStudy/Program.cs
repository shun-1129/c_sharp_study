namespace ThreadStudy
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Worker worker = new Worker();
            worker.Executor();
        }
    }
}