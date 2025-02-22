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




//int[] numbers = { 4, 7, 2, 9, 4, 3, 7, 8, 9, 1, 5, 3, 6, 2, 8, 10 };
//int[] uniqueNumbers = numbers.Distinct().ToArray();

//int maxNumber = uniqueNumbers.Max();
//Console.WriteLine("Tekrarlanan edeler: " +string.Join(" - " , uniqueNumbers));
//Console.WriteLine("En boyuk eded: " +maxNumber);


//////////////////////////////////////////


//string[] words = { "Proqramlasdirma", "mekteb", "komputer", "developer", "texnologiya" };
//string[] sortedWords = words.OrderByDescending(word=> word.Length).ToArray();
//Console.WriteLine("En uzun 3 soz: ");
//for (int i = 0; i<3 && i< sortedWords.Length; i++)
//{
//    Console.WriteLine(sortedWords[i]);
//}

/////////////////////////////////



double[] numbers = { 10.5, 25.0, 30.2, 50.8, 75.3, 90.6 };

double[] modifiedNumbers = numbers.Select(modifiedNumbers => (modifiedNumbers / 5) + 2).ToArray();
Console.WriteLine("Yekun n'tice");
Console.WriteLine(string.Join(", ", modifiedNumbers));

/////////////////////////////////////
