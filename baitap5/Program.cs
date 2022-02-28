using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap5
{
    class Program
    {
        static void Main(string[] args)
        {
            int soDoMaySinh, SoDoNguoiDoan;
            Random r = new Random();
            soDoMaySinh = r.Next(21);
            Console.WriteLine("May tinh da sinh ra 1 so ngau nhien >0 va <=20, bay gio moi ban doan so do");
            
            int dem = 1;
            int choilai = 1;

            while (choilai == 1)
            {
                while (dem <= 7)
                {
                    Console.WriteLine("Ban dang dung lan dem so: " + (dem));
                    SoDoNguoiDoan = Int16.Parse(Console.ReadLine());
                    if (SoDoNguoiDoan == soDoMaySinh)
                    {
                        Console.WriteLine("chuc mung ban da doan dung!");
                        break;
                    }

                    else
                        if (SoDoNguoiDoan > soDoMaySinh)
                    {
                        Console.WriteLine("Ban doan so qua lon");
                        if (dem >= 7)
                        {
                            Console.WriteLine("ban da thua roi, so may sinh ra la: {0}", soDoMaySinh);
                            break;
                        }

                        Console.WriteLine("Moi ban doan lai: ");
                        dem = dem + 1;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Ban doan so qua nho");
                        if (dem >= 7)
                        {
                            Console.WriteLine("ban da thua roi, so may sinh ra la: {0}", soDoMaySinh);
                            break;
                        }
                        Console.WriteLine("moi ban doan lai");
                        dem = dem + 1;

                    }

                }
                Console.WriteLine("Bạn có muốn chơi lại không: có: gõ số 1/ không muốn: gõ số 0");
                choilai = Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadLine();
                
        }
    }
}
