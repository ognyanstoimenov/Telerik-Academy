namespace FastAndFurious.ConsoleApplication
{
    public class Startup
    {
        public static void Main()
        {
            var engine = new FastAndFurious.ConsoleApplication.Engine.Engine();
            engine.Start();
        }
    }
}
