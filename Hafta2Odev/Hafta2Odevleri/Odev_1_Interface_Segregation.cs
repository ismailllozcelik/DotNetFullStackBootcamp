using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2Odevleri
{
    interface IFly
    {
        void Fly();
    }

    interface IWalk
    {
        void Walk();
    }

    interface ISwim
    {
        void Swim();
    }

    class Bird : IFly, ISwim
    {
        public void Fly()
        {
            Console.WriteLine("Bird is flying");
        }

        public void Swim()
        {
            Console.WriteLine("Bird is swimming");
        }
    }
}
