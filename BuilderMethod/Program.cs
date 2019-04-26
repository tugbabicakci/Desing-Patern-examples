using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMethod
{
    interface IBuilder
    {
        void BuildPartA();

        void BuildPartB();

        void BuildPartC();
    }

    public class ConcreateBuilder1 : IBuilder
    {
        public void BuildPartA()
        {
            throw new NotImplementedException();
        }

        public void BuildPartB()
        {
            throw new NotImplementedException();
        }

        public void BuildPartC()
        {
            throw new NotImplementedException();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
