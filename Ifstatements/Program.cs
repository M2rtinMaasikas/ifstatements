using System;

namespace Ifstatements
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //programm küsib kasutaja vanust
            //kui kasutajaon vanem kui 18 siis konsoolis kuvatakse "oled piisavalt vana"
            //kui kasutaja on noorem, kui 18 siis konsoolis kuvatakse "oled liiga noor"
            //kui kasutaja 18, siis konsoolis kuvatakse "oledki 18"
            Console.WriteLine("kui vana sa oled?");

            int Age = Int32.Parse(Console.ReadLine());

            if (Age > 18)
            {
                Console.WriteLine("oled piisavalt vana");
            }
            else if (Age < 18)
                Console.WriteLine("oled liiga noor");
           
            else
            {
                Console.WriteLine("oledki 18");

            }
            Console.WriteLine("Ilusta päeva!");


          
               
            
            
            





            

        }
    }
    
}
