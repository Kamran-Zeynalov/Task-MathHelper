using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_MathHelper
{
    internal class MathHelper
    {

        public int PrintValue(int num1, int num2)
        {
            return num1 + num2;
        }
        public int PrintValue(bool number)
        {
            if (number) return 1;
            return 0;
        }
        public void PrintValue(string name, string surname)
        {
            Console.WriteLine(name + " " + surname);
        }
        public int PrintValue(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }



    }
}
