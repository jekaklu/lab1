using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace S4et
{
    class Weapon
    {
        public String Name { get; set; }

        private double Kaliber { get; set; }

        public double Range { get; set; }



        public void Input()
        {
            Console.Write("Введите название оружия: "); this.Name = Console.ReadLine();
            Console.Write("Введите калибр оружия: "); this.Kaliber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите его дальность: "); this.Range = Convert.ToDouble(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine($"Название: { this.Name }");
            Console.WriteLine($"Калибр: { this.Kaliber }");
            Console.WriteLine($"Дальность: { this.Range }");
        }

        static void Main(string[] args)
        {
            Weapon scr = new Weapon();
            scr.Input();
            scr.Print();
            Console.ReadKey();
        }

    }
}