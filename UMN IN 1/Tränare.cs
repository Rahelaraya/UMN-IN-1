
namespace UMN_IN_1
{
    public class Tränare
    {
        public string Name;
        public string Email;
        private int Id;

        public Tränare()
        {
        }

        public Tränare(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;

        }
        public void workout()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Email: {Email}");
        }
    }
}
 