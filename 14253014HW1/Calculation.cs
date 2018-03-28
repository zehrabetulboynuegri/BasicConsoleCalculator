using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14253014HW1  
{
    class Calculation
    {

        static void Main(string[] args)
        {
            
            char continuation = 'e';
            while (continuation == 'e')
            {
                //ilk sayiyi kullanicidan alma ve hata kontrolu yapma
                Console.Write("Bir sayi giriniz:");
                string num = Console.ReadLine();
                int num1;
                bool control = int.TryParse(num, out num1);
                while (control == false)
                {

                    Console.WriteLine("Lutfen sayi giriniz!");
                     num = Console.ReadLine();
                    control = int.TryParse(num, out num1);

                }

                //yapilacak islemi kullacidan alma ve hata kontrolu yapma
                Console.Write("Islemi giriniz(+, -, *, /): ");
                char operation;
                string op = Console.ReadLine();
                control = char.TryParse(op, out operation);
                while (operation != '+' && operation != '-' && operation != '*' && operation != '/')
                {

                    Console.WriteLine("Islemi dogru giriniz!");
                    op = Console.ReadLine();
                   control = char.TryParse(op, out operation);
                }

                //girilecek ikinci sayiyi kulanıcıdan alma ve hata kontrolu yapma
                Console.Write("Ikinci sayiyi giriniz:");
                int num2;
                 num = Console.ReadLine();
                control = int.TryParse(num, out num2);
                while (control == false)
                {

                    Console.WriteLine("Lutfen sayi giriniz!");
                    num = Console.ReadLine();
                    control = int.TryParse(num, out num2);

                }
               //////////////////////////////////////////////////
                MathOperations calculus = new MathOperations();  
                if (operation == '+')
                {
                  
                    Console.WriteLine("Sonuc="+calculus.addition(num1, num2));
                }
                else if (operation == '-')
                {
                   
                    Console.WriteLine("Sonuc=" + calculus.subtraction(num1, num2));
                }
                else if (operation == '*')
                {
          
                    Console.WriteLine("Sonuc=" + calculus.multiplication(num1, num2));
                }
                else // (operation == '/')
                {   if (num2!=0)  //bolen sayi 0 degilse bolme methodunu uygular
                    {
                     
                        Console.WriteLine("Sonuc=" + calculus.division(num1, num2));
                    }
                    else
                    {
                        Console.WriteLine("Bolen sifir olamaz!");
                    }
                }
                Console.Write("Devam etmek istiyormusunuz? (e/h): ");
                string yesOrNo = Console.ReadLine();
                bool cntrl = char.TryParse(yesOrNo, out continuation);
                while (continuation != 'e' && continuation != 'h') //kullanici e ya da h tusuna basincaya kadar dongu icinde kalir
                    {
                   
                    Console.WriteLine("Lutfen devam etmek istiyorsaniz 'e', cıkmak istiyorsaniz  'h' tusuna basiniz!");
                    yesOrNo = Console.ReadLine();
                    cntrl = char.TryParse(yesOrNo, out continuation);
                   
                    }
               

            }
        }
    }
}