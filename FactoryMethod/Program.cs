using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
   


       public abstract class Creator
        {
            public abstract IVehicle Vehicle();

           

            public string Operation()
            {
                var product = Vehicle();
                var result = "Sonuc olarak : " + product.CreateProduct();

                return result;



            }

        }

         class ConcreateTruckFactory : Creator
        {
            public override IVehicle Vehicle()
            {
               return new Truck();
            }
        }

        class ConcreateShipFactory : Creator
        {
            public override IVehicle Vehicle()
            {
                return new Ship();
            }
        }


      
     

       public interface IVehicle
        {
            string CreateProduct();

        }

        public class Truck : IVehicle
        {
            public string CreateProduct()
            {
                return  "Truck Oluşturuldu";
            }
        }

        public class Ship : IVehicle
        {
            public string CreateProduct()
            {
                return "Ship Oluştu";
            }
        }


      public  class Client
        {

            public void Main()
            {
                Console.WriteLine("Truck ürününden 1 adet isterim");
                ClientCode(new ConcreateTruckFactory());

                Console.WriteLine("Ship ürününden isterim");

                ClientCode(new ConcreateShipFactory());
                

            }

            public void ClientCode(Creator creator)
            {
                Console.WriteLine("Hangi sınıftan ürünün nasıl üretildiği benim(client) umrumda değil !"+creator.Operation());
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
