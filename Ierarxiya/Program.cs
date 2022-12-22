using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ierarxiya
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Boris = new Person("Борис");
            Person Rashid = new Person(Boris, "Рашид", "Бухгалтерия");
            Person OIlham = new Person(Boris, "О Ильхам", "Автоматизация");
            Person Lukas = new Person(Rashid, "Лукас", "Финансы");
            Person Orkadiy = new Person(OIlham, "Оркадий", "Информационные системы");
            Person Volodya = new Person(Orkadiy, "Володя", "Информационные системы");
            Person Sergey = new Person(Volodya, "Сергей", "Разработка");
            Person Ilbshat = new Person(Volodya, "Ильшат", "Систематизация");
            Person Lyaisan = new Person(Sergey, "Ляйсан", "Разработка");
            Person Ivanich = new Person(Ilbshat, "Иваныч", "Систематизация");

            Person Marat = new Person(Lyaisan, "Марат", "Разработка");

            Person Dina = new Person(Lyaisan, "Дина", "Разработка");
            Person Ildar = new Person(Lyaisan, "Ильдар", "Разработка");
            Person Anton = new Person(Lyaisan, "Антон", "Разработка");

            Person Ilya = new Person(Ilbshat, "Илья", "Разработка");
            Person Vitya = new Person(Ilbshat, "Витя", "Систематизация");
            Person Jeka = new Person(Ilbshat, "Жека", "Систематизация");

            List<Person> a = new List<Person>
            {
                Marat, Dina, Ildar, Anton, Ilya, Vitya, Jeka, 
                Lukas, Lyaisan, Ivanich, Sergey, Ilbshat,
                Volodya, Orkadiy, Rashid, OIlham, Boris
            };


            Person.ProvChief(Rashid, Lukas, a, "Финансы");

            
            Console.ReadKey();
        }
    }
}
