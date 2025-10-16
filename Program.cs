using System.Net.Http.Headers;

namespace fattoriale
{
    internal class Program
    {
        static int fattoriale(int b) 
        {
            int fatt=1;
            for (int i = 0;b>i ; b--)
            {
                fatt = fatt * b;
            }
            return fatt;
        }

        static void Main(string[] args)
        {
            int a,prod;
            Console.WriteLine("di quale numero vuoi che ti faccia il fattoriale");
            a = Convert.ToInt32(Console.ReadLine());
            prod=fattoriale(a);
            Console.WriteLine("il vettoriale del tuo numero è di " + prod);
            
        }
    }
}
  