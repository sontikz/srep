using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_event_2403 //for english alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new Delegate();
            reader.OnKeyPressed += Whriter;
            reader.Run();
        }
        public static void Whriter(object sender, char ch)
        {
            Console.WriteLine(ch);
        }
    }
    public class Delegate
    {
        public event EventHandler<char> OnKeyPressed;
        public void Run()
        {
            char symb = Console.ReadKey().KeyChar;
            while (symb != 'c')
            {
                OnKeyPressed?.Invoke(this, symb);
                symb = Console.ReadKey().KeyChar;
            }
        }
    }
}