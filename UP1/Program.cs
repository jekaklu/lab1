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

        public Weapon()
        {
            this.Name = "";
            this.Kaliber = 0.0;
            this.Range = 0.0;
        }

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



    }
}