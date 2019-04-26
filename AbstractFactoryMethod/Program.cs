using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static AbstractFactoryMethod.ModernFactory;

namespace AbstractFactoryMethod
{

    public interface IMobilya
    {
        IChair CreateChair();
        ITable CreateTable();


    }

    public class OttomanFactory : IMobilya
    {


        IChair IMobilya.CreateChair()
        {
            return new OttomanChair();
        }

        ITable IMobilya.CreateTable()
        {
            return new OttomanTable();
        }
    }

    public class ModernFactory : IMobilya
    {




        public IChair CreateChair()
        {
            return new ModernChair();
        }

        public ITable CreateTable()
        {
            return new ModernTable();
        }



        public interface IChair
        {
            string Paint();

        }

        public class OttomanChair : IChair
        {
            public string Paint()
            {
                return "Ottoman chair boyadı";
            }
        }

        public class ModernChair : IChair
        {
            public string Paint()
            {
                return "Modern chair boyadı";
            }
        }



        public interface ITable
        {
            string Funtion();
        }

        public class OttomanTable : ITable
        {
            public string Funtion()
            {
                return "Ottoman Table hazır";
            }
        }

        public class ModernTable : ITable
        {
            public string Funtion()
            {
                return "Modern Table Hazır";
            }
        }

        public class Client
        {
            public void Main()
            {
                Console.WriteLine("Modern fabrika test ediliyor !");
                ClientMethod(new ModernFactory());


                Console.WriteLine("Ottoman fabrika test ediliyor !");
                ClientMethod(new OttomanFactory());



            }

            public void ClientMethod(IMobilya mobilya)
            {
                var b = mobilya.CreateChair();
                var c = mobilya.CreateTable();


                Console.WriteLine(b.Paint());
                Console.WriteLine(c.Funtion());
            }

        }

        class Program
        {
            static void Main(string[] args)
            {

                new Client().Main();


            }
        }
    }
}
