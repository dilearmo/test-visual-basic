using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exame2_CS.POO
{
    public class Z
    {
        public void M() { Console.WriteLine("Z.M"); }
        public virtual void P() { Console.WriteLine("Z.P"); }
    }

    public class Y : Z
    {
        public void M() { Console.WriteLine("Y.M"); }
        public override void P() { Console.WriteLine("Y.P"); }
    }

    public class X : Y
    {
        public void M() { Console.WriteLine("X.M"); }
    }

    public class W : X
    {

        public void M() { Console.WriteLine("W.M"); }
    }


    public class POO_4
    {
        public static void Exec()
        {
            W d = new W();
            Z a = d;
            Y b = d;
            X c = d;

            a.M();
            b.M();
            c.M();
            d.M();

            Y b1 = new Y();
            Z a1 = b;

            a1.P();
            b1.P();

            Console.ReadLine();
        }
    }
}
