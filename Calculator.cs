using System;

namespace MyApp
{
    public class Calculator
    {
        public int Add(int a,int b){
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply( int a , int b )
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            if (b == 0)
                return 0; // Hatalı: sessizce 0 döndürülmesi güvenli değil. DivideZeroException döndürülmesi gerekiyor
            return a / b;
        }

        public void PrintResult(int result)
        {
            Console.WriteLine("Sonuç: " + result); // Hatalı: string formatlama zayıf, kültür bağımlı
        }

        public void DoSomething()
        {
            int unusedVar = 5; // Uyarı: kullanılmayan değişken
        }
    }
}
