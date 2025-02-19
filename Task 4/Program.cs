//using System;
//using System.Collections.Generic;
//using System.Diagnostics.Tracing;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        //Srting array yaratmaq
//        string[] words = { "alma", "banan", "ciyelek", "gavali", "erik", "uzum", "nar", "heyva" };

//        //Tek uzunluqlu sozleri secmek
//        List<string> oddLengthWords = words.Where(word => word.Length % 2 == 1).ToList();

//        //Neticeni ekrana cap edek
//        Console.WriteLine("Tek uzunluqlu sozler:");
//        foreach(var word in oddLengthWords)
//        {
//            Console.WriteLine(word);
//        }
//    }
//}

////////////////////////


//using System;
//using System.Collections.Generic;
//class Program
//{
//    static void Main()
//    {
//        //Bos list yaratmaq
//        List<string> userNames = new List<string>();
//        while (true)
//        {
//            Console.Write("Istifadeci adi daxil edin (\"sil\" - sonuncunu sil, \"bitir\" - cixis):");
//            string input = Console.ReadLine();

//            if (input.ToLower() == "bitir")
//            {
//                break;
//            }
//            else if (input.ToLower() == "sil")
//            {
//                if (userNames.Count > 0)
//                {
//                    Console.WriteLine($"Silindi: {userNames[^1]}");
//                    userNames.RemoveAt(userNames.Count - 1);
//                }
//                else
//                {
//                    Console.WriteLine("Siyahi bosdur, Silinecek istifadeci adi yoxdur.");
//                }
//            }
//            else
//            {
//                userNames.Add(input);
//                Console.WriteLine($"Elave edildi: {input}");
//            }
//        }
//        //Butun adlari cap etmek
//        Console.WriteLine("\nIstifadeci adlari bazasi:");
//        if (userNames.Count > 0) 
//        {
//            foreach (var name in userNames)
//            {
//                Console.WriteLine(name);
//            }
//        }
//        else
//        {
//            Console.WriteLine("Siyahi bosdur. ");
//        }
//    }
//}
////////////////////////////////////////////


