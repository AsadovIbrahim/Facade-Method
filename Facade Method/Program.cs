namespace Facade_Method
{
    public class Program
    {
        static void Main(string[] args)
        {
            Theatre theatre = new Theatre();
            theatre.WatchMovie("Guardians Galaxy");
            theatre.EndMovie();
        }
    }
}