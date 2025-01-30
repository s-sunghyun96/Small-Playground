using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AddMulQuiz
{
    internal class AddMulQuiz
    {
        public AddMulQuiz(bool add)
        {
            if (add) Op = "+";
            else Op = "*";
            N1 = R.Next(1, 30);
            N2 = R.Next(1, 30);
        }

        public static Random R = new();
        public int N1 { get; private set; }
        public int N2 { get; private set; }
        public string Op { get; private set; }

        public bool Check(int a)
        {
            if (Op == "+") return (a == N1 + N2);
            else return (a == N1 * N2);
        }
    }
}
