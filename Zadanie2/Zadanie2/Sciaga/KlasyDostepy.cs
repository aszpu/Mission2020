using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2.Sciaga
{
    public abstract class A
    {
        public void DoSmth()
        {
            DoSmthElse();
        }

        private void DoSmthElse()
        {
            DoSmthElse2();
        }

        protected abstract void DoSmthElse2();
    }

    public class B1 : A
    {
        protected override void DoSmthElse2()
        {
            
        }
    }

    public class B2 : A
    {
        protected override void DoSmthElse2()
        {

        }
    }

    public class C
    {
        private int _num;
        protected int _x;

        public void DoSmth()
        {

        }
    }

    public class D : C
    {
        private string _name;

        private void M()
        {
            _x = 0;

            DoSmth();
        }
    }

    public class G
    {
        private const int AnotherOffset = 100;

        private int _x;
        private static int _y;
        private readonly static int _offset = 10;

        public void Meth1(int value)
        {
            _x = _offset + value + AnotherOffset;
        }

        public static void Meth2(int value)
        {
            _y = value;
        }

        public static void Meth3(int value)
        {
            //Meth1(1);
            new G().Meth1(1);
        }
    }

    public class Test
    {
        public void TestMethod()
        {
            var b1 = new B1();
            var b2 = new B2();
            var c = new C();
            var d = new D();

            c.DoSmth();
            d.DoSmth();

            b1.DoSmth();
            b2.DoSmth();

            var g = new G();
            g.Meth1(6);
            G.Meth2(4);
        }
    }
}
