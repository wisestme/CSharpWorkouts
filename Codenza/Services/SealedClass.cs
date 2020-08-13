using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codenza.Services
{
    sealed class SealedClass
    {
        public int x;
        public int y;
    }

    public class SealedTest
    {
        public void TestSealedClass()
        {
            SealedClass sc = new SealedClass();
            sc.x = 100;
            sc.y = 180;

            Console.WriteLine("x = {0}, y = {1}", sc.x, sc.y);
        }
    }
}
