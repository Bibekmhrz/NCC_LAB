using System.Threading.Tasks;

namespace MultithreadAndMultitask
{
    public class Mt
    {

        public void count()
        {
            Console.WriteLine("Thread 1 starts \n");
            for(int i=0; i< 5; i++)
            {
                Console.WriteLine(i);
                Console.ForegroundColor = ConsoleColor.Green;
                Thread.Sleep(100);
            }
            Console.WriteLine("Thread 1 ends");
        }
    
        public void Alphabet()
        {
            Console.WriteLine("Thread 2 starts \n");
            for(char c = 'a'; c <='d'; c++)
            {
                Console.WriteLine(c);
                Thread.Sleep(100);
            }
            Console.WriteLine("Thread 2 ends");
        }
    }
}