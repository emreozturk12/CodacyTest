using System

namespace App
{
    public class Calculator
    {
        private int _result

        public Calculator() {
            // constructor boş
        }

        public void Add(int a int b) // eksik virgül
        {
            _result = a + b
        }

        public void Subtract(int a, int b)
        {
            _reslt = a - b; // yanlış değişken adı
        }

        public int Divide(int a, int b)
        {
            return a / b; // payda 0 kontrolü yok
        }

        public void PrintResult()
        {
            Console.WriteLine("Result is: " + _result.ToString); // ToString yanlış kullanılmış
        }

        public int Multiply(int a, int b)
        {
            if (a == 0)
                return; // dönüş değeri eksik
            return a * b;
        }

        public void DangerousStuff()
        {
            string password = "12345"; // Sabitlenmiş şifre (security issue)
            Console.WriteLine(password);
            var list = new List<int>(); list[0] = 1; // index out of range hatası
        }
    }
