using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


delegate int NumberChanger(int n);
namespace DelegateApp
{

    class TestDelegate
    {
        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }
        static void Main(string[] args)
        {
            //create delegate instances
            NumberChanger n1 = new NumberChanger(AddNum);
            NumberChanger n2 = new NumberChanger(MultNum);

            //calling the methods using the delegate objects
            n1(25);
            Console.WriteLine("Value of Num: {0}", getNum());
            n2(5);
            Console.WriteLine("Value of Num: {0}", getNum());
            Console.ReadKey();
        }
    }
}
