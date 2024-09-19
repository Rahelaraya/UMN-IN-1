
using System.Xml.Linq;

namespace UMN_IN_1
{
    class Medlemskap
    {
        public string name;
        public string kön;
        private string id;
        string startdatum;
        string slutdatum;
        string membershiptypårmånad;

        public Medlemskap()
        {
        }

        public Medlemskap(string name, string kön, string id, string startdatum, string slutdatum, string membershiptypårmånad)
        {
            name = name;
            kön = kön;
            id = id;
            startdatum = startdatum;
            slutdatum = slutdatum;
            membershiptypårmånad = membershiptypårmånad;
        }

        public void GetIt()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Kön: {kön}");
            Console.WriteLine($"ID: {id}"); // Using GetId() here
            Console.WriteLine($"Start datum: {startdatum}");
            Console.WriteLine($"Slut datum: {slutdatum}");
            Console.WriteLine($"Membershiptyp år/månad: {membershiptypårmånad}");
        }

    }
}
