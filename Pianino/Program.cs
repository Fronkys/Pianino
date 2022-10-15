using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Xml;

namespace Pianino
{
    internal class Program
    {
        

        
        static void Main(string[] args)
        {
            Console.WriteLine("Здраствуйте, белые кнопки пианино ASD, а черные ZXC");
            Console.WriteLine("Для переключения октав нажмите 'F6'");
            Oktava();
        }
        static void Oktava()
        {
            
            Console.WriteLine("Выберите октаву F3 или F4: ");
            ConsoleKeyInfo Clavisha = Console.ReadKey();
            if (Clavisha.Key == ConsoleKey.F3)
            {   
                
                Oktava3();
            }
            if (Clavisha.Key == ConsoleKey.F4)
            {
                Oktava4();
            }
        }



        static void Oktava3()
        {

          int[] nota = new int[6] { 131, 147, 165, 139, 156, 185 }; 
          Console.WriteLine("Третья октава.");
          ConsoleKeyInfo button = Console.ReadKey();
            while (button.Key != ConsoleKey.F6)
            {
                switch (button.Key)
                {
                    case ConsoleKey.A:
                        Console.Beep(nota[0], 400);
                        break;
                    case ConsoleKey.S:
                        Console.Beep(nota[1], 400);
                        break;
                    case ConsoleKey.D:
                        Console.Beep(nota[2], 400);
                        break;
                    case ConsoleKey.Z:
                        Console.Beep(nota[3], 400);
                        break;
                    case ConsoleKey.X:
                        Console.Beep(nota[4], 400);
                        break;
                    case ConsoleKey.C:
                        Console.Beep(nota[5], 400);
                        break;
                }
                button = Console.ReadKey(); Console.Clear();

            } Oktava();

        }
        static void Oktava4()
        {
            Console.WriteLine("Это четвертая октава.");
            int[] nota = new int[6] { 260, 294, 330, 278, 311, 370 };
            ConsoleKeyInfo button = Console.ReadKey();
            while (button.Key != ConsoleKey.F6)
            {
                switch (button.Key)
                {
                    case ConsoleKey.A:
                        Console.Beep(nota[0], 400);
                        break;
                    case ConsoleKey.S:
                        Console.Beep(nota[1], 400);
                        break;
                    case ConsoleKey.D:
                        Console.Beep(nota[2], 400);
                        break;
                    case ConsoleKey.Z:
                        Console.Beep(nota[3], 400);
                        break;
                    case ConsoleKey.X:
                        Console.Beep(nota[4], 400);
                        break;
                    case ConsoleKey.C:
                        Console.Beep(nota[5], 400);
                        break;
                } button = Console.ReadKey(); Console.Clear();
            }Oktava();
        } 
    }
}

