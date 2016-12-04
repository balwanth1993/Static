using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1static
{
    public class Sphere
    {
        static float _pi = 3.141F; // Class member is kept static because it is constant and can save lot of memory space.
        int _Radius ;

        public Sphere(int Radius)
        {
            this._Radius = Radius;
        }
        public float Volume()
        {
            return (4 / 3) * Sphere._pi * this._Radius * this._Radius * this._Radius;
        }
       


    }
    class Program
    {
        static void Main(string[] args)
        {
            Sphere s1 = new Sphere(5);
            float v1 = s1.Volume();
            Console.WriteLine("Volume =" +v1 );

            Sphere s2 = new Sphere(7);
            float v2 = s2.Volume();
            Console.WriteLine("Volume = " +v2 );



        }
    }
}
