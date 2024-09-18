
namespace UMN_IN_1
{
    public class Kunder
    {
        private string name;
        private string email;
        private string id;

        public Kunder()
        {
        }

        public Kunder(string name, string email, string Id)
        {
            Name = name;
            Email = email;
            id = Id;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Id
        {
            get { return Id; }
            set { Id = value; }
        }
        public void Showinfo()
        {
            Console.WriteLine($"Name: {name}, Email: {email} Id: {id}");
        }
    }


}
