using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ierarxiya
{
    class Person
    {
        public Person Chief { get; set; }
        public string Employ { get; set; }
        public string Work { get; set; }
        public Person(Person chief, string employ, string work)
        {
            this.Chief = chief;
            this.Employ = employ;
            this.Work = work;
        }
        public Person(string employ) { this.Employ = employ; }

        public static void Proverka(Person name, Person employ, List<Person> a)
        {
            Person chief = employ.Chief;
            Person chief1 = employ.Chief;
            bool Flag = false;
            for (int i = 0; i < a.Count; i++)
            {
                for (int q = i; q < a.Count; q++)
                {
                    if (Equals(a[q].Chief,chief))
                    {
                        chief = a[i].Chief;
                        if (Equals(name,chief1))
                        {
                            Console.WriteLine($"{employ.Employ} берёт") ;
                            Flag = true;
                            break;
                        }
                    }
                    else
                    {
                        Flag = false;
                        continue;
                    }
                }
                if (Equals(Flag, true))
                {
                    break;
                }
            }
            if (Equals(Flag, false))
            {
                Console.WriteLine("Не берёт");
            }
        }
        public static void ProvChief(Person chief, Person employ, List<Person> a, string q)
        {
            Console.WriteLine($"{chief.Employ} дал задание {employ.Employ} на тему {q}");
            if (string.Compare(chief.Employ,employ.Employ)==0)
            {
                Console.WriteLine("Сам себе задание не задашь!");
            }
            else if (string.Compare(q,employ.Work)!=0)
            {
                Console.WriteLine("Такую работу не делаем");
            }
            else if (chief == employ.Chief)
            {
                Console.WriteLine($"{employ.Employ} берёт задание");
            }
            else if (string.Compare(employ.Employ,"Борис")==0)
            {
                Console.WriteLine("Куда на начальника?");
            }
            else
            {
                Proverka(chief, employ, a);
            }
        }

    }
}
