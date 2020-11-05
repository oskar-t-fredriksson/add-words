using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fas1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quitProgram = false;
            Console.WriteLine("Lista på latinska ord! \nSkriv 'sluta' för att sluta");
            //List<string> sweToLatin = new List<string>();
            Dictionary<string, string> sweToLatin = new Dictionary<string, string>();
            string swedish = "";
            string latin = "";
            Dictionary[swedish] = 
            sweToLatin.Add(swedish, latin);
            while (!quitProgram)
            {
                Console.Write("> ");
                string command = Console.ReadLine();
                //Console.WriteLine("Command: {0}", command);
                if (command == "sluta")
                {
                    quitProgram = true;
                    Console.WriteLine("Adjö");
                }
                else if (command == "ny")
                {
                    Console.Write("Ange svenskt ord: ");
                    swedish = Console.ReadLine();
                    Console.WriteLine("{0} tillagt!", swedish);
                    Console.WriteLine("Ange latinsk översättning: ");
                    latin = Console.ReadLine();
                    Console.WriteLine("{0} är tillagd översättning för {1}", latin, swedish);                    
                }
                //else if (command == "visa")
                //{
                //    //Console.WriteLine("Inköpslista: \n {0}", ware[i]);
                //    for (int i = 0; i < sweToLatin.Count; i++)
                //    {
                //        Console.WriteLine("{0}: {1}", i + 1, sweToLatin[i]);
                //    }
                //}
                //else if (command == "ta bort")
                //{
                //    Console.Write("Vilket nummer vill du ta bort: ");
                //    int toRemove = int.Parse(Console.ReadLine());
                //    string saved = sweToLatin[toRemove - 1];
                //    sweToLatin.RemoveAt(toRemove - 1);
                //    Console.WriteLine("{0} togs bort!", saved);
                //}
                else if (command == "svenska")
                {
                    
                    Console.WriteLine("Vilket ord vill du ha översatt: ");
                    string translate = Console.ReadLine();
                    foreach (KeyValuePair<string, string> entry in sweToLatin)
                    {
                        Console.WriteLine("{0} - {1}", entry.Key, entry.Value);
                    }
                }
            }
            
            Console.ReadKey();
        }
        
    }
}
