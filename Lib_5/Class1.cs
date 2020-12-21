using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib_5
{
    public class Class1
    {
        public static void First(int a, int b, int c, out int v, out int s)
        {
            v = a * b * c;
            s = 2 * (a * b + a * b + b * c);
        }
        public static void Second(int a, out int sum, out int proiz)
        {
            if (a >= 10 && a <= 99)
            {
                sum = a / 10 + a % 10;
                proiz = a / 10 * (a % 10);
            }
            else
            {
                MessageBox.Show("Число должно быть двузначным");
                sum = 0;
                proiz = 0;
            }
        }
    }
}
