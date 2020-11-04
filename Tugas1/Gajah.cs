using System;

namespace Tugas1
{
    public class Gajah
    {
        protected string tinggiBadan = "Sedang";
        public int Kaki = 4;

        public void info()
        {
            Console.WriteLine("Kaki gajah ada : " + this.Kaki);
            Console.WriteLine("Tinggi badan gajah : " + this.tinggiBadan);
        }
    }
}