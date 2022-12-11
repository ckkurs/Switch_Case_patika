using System;

namespace Switch_Case_patika
{
    class Program
    {
        static void Main(string[] args)
        {
            int month=DateTime.Now.Month;

            //Expression yani kontrol etmek istediğimiz koşulu
            switch (month)
            {
                case 1:
                Console.WriteLine("Ocak Ayındayız!");
                break;
                case 2:
                Console.WriteLine("Şubat Ayındayız!");
                break;
                case 3:
                Console.WriteLine("Mart Ayındayız!");
                break;
                case 4:
                Console.WriteLine("Nisan Ayındayız!");
                break;
                case 5:
                Console.WriteLine("Mayıs Ayındayız!");
                break;
                case 6:
                Console.WriteLine("Haziran Ayındayız!");
                break;
                case 7:
                Console.WriteLine("Temmuz Ayındayız!");
                break;
                case 8:
                Console.WriteLine("Ağustos Ayındayız!");
                break;
                case 9:
                Console.WriteLine("Eylül Ayındayız!");
                break;
                case 10:
                Console.WriteLine("Ekim Ayındayız!");
                break;
                case 11:
                Console.WriteLine("Kasım Ayındayız!");
                break;
                case 12:
                Console.WriteLine("Aralık Ayındayız!");
                break;
                default://koşullara uymazsa ne yapmamız gerektiği
                break;
            }

            switch (month)
            {
                case 12://bu 3 ay geldiğinde aynı kod bloğunun çalışmasını söyledim.
                case 1:
                case 2:
                   Console.WriteLine("Kış Ayındayız!");
                   break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar Ayındasınız");
                    break;   
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz Ayındasınız");
                    break;       
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar Ayındasınız");
                    break;       
                default:
                break;
            }
        }
    }
}
