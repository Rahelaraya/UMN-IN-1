using System.Xml.Linq;
using System;

namespace UMN_IN_1
{
    internal class Fitnessklubbsmedlemskapssystem
    {
        static void Main(string[] args)
        {
            Klass klass = new Klass();
            klass.myMethod();
            Kunder kunder1 = new Kunder();
            kunder1.Showinfo();
            Tränare tränare = new Tränare();
            tränare.workout();
            Medlemskap medlemskap = new Medlemskap();
            medlemskap.GetIt();
        }
    }
}
