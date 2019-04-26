using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesingPattern
{
    class Program
    {
        public class Person
        {
            public string Name;
            public string Surname;
      
            public idInfo IdInfo;

            public Person ShallowCopy()
            {
                return (Person) this.MemberwiseClone();
            }

            public Person DeepCopy()
            {
                Person clone = (Person) this.MemberwiseClone();
                clone.Name = String.Copy(Name);
                clone.IdInfo=new idInfo(IdInfo.number);

                return clone;
            }



        }

        public class idInfo
        {
            public int number;

            public idInfo(int idNumber)
            {
                number = idNumber;
            }
        }

        static void Main(string[] args)
        {
            Person p1=new Person();
            p1.Name = "Orjinal Tugba";
            p1.Surname="BBB";
            p1.IdInfo=new idInfo(1);

            //Shallow copy : Nesnenin referansını gösterir yani kopyaladığımız değişken orjinal değişkeni etkilemez.
            Person p2 = p1.ShallowCopy();
          Console.WriteLine("Shallow copy deneme !");

            Console.WriteLine("orjinal değer : "+p1.Name);
            Console.WriteLine("Shallow copy ilk hali : "+p2.Name);

            p2.Name = "ShallowCopy Tugba";
            Console.WriteLine("p2 ye yeni değer girdiğimizde orjinal değirin değişmediği gözlemlendi.");
         

            Console.WriteLine("orjinal değer :"+p1.Name);
            Console.WriteLine("shallow copy değişim hali : "+p2.Name);

            Console.WriteLine("Deep Copy deneme");
            Console.WriteLine("---------------");

            Person p3 = p1.DeepCopy();

            Console.WriteLine("orjinal değer :" + p1.Name);
            Console.WriteLine("Deep copy ilk hali :" + p3.Name);

            p3.Name = "DeepCopy Tugba";

            Console.Write(p1.Name);
            Console.Write(p3.Name);
        }
    }
}
