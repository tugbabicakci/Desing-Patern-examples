using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SinletonDesingPattern;

namespace SinletonDesingPattern
{
    class Sing
    {
        private static Sing _instance;

        private Sing()
        {

        }

        public static Sing GetInstance()
        {
            if (_instance == null)
                _instance = new Sing();

            return _instance;
        }


        public string Create()
        {
            return "71624581483";

        }

    }





    class Program
    {
        static void Main(string[] args)
        {

            Sing s1 = Sing.GetInstance();
            Sing s2 = Sing.GetInstance();
            s1.Create();
            s2.Create();

            Console.WriteLine("s1  : " + s1.Create());
            Console.WriteLine("s2  : " + s2.Create());

            //if (s1 == s2)
            //{
            //    Console.WriteLine("Singleton başarılı");
            //}
            //else 
            //    Console.WriteLine("Başarısızzzzz !!!!");





        }
    }

}