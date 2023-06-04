namespace PRITT
{
    public class User
    {
        public int Id { get; }
        public string Login { get; }
        public string Password { get; }
        public string LastName { get; }
        public string FirstName { get; }
        public Role Role { get; }
        public Organization Organization { get; }

        public User(int id, string login, string password, string lastName, string firstName, Role role,
            Organization organization)
        {
            Id = id;
            Login = login;
            Password = password;
            LastName = lastName;
            FirstName = firstName;
            Role = role;
            Organization = organization;
        }
    }
}