namespace Model
{
    public class Customer
    {
        public int Id { get; }
        public string Email { get; }
        public string Lastname { get; }
        public string Firstname { get; }
        public string Fullname 
        {
            get
            {
                return $"{Firstname} {Lastname}";
            }
        }

        public Customer(int id, string firstname, string lastname, string email)
        {
            Id = id;
            Email = email;
            Lastname = lastname;
            Firstname = firstname;
        }

        public override string ToString()
        {
            return $"[Customer] id: {Id} | Name: {Fullname} | Email: {Email}";
        }
    }
}
