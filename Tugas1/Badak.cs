using System;

namespace Tugas1
{
    public class Badak : Gajah
    {
        private string identitas = "Bercula";

        public void info()
        {
            Console.WriteLine("Tinggi badan : " + base.tinggiBadan);
            Console.WriteLine("Kaki Badak ada : " + base.Kaki);
            Console.WriteLine("Identitas Badak : " + this.identitas);
        }
    }
}