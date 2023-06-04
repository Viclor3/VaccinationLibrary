namespace PRITT
{
    public class User
    {
        private string Login { get; }
        private string Password { get; }
        private string LastName { get; }
        private string FirstName { get; }
        private Role Role { get; }
        public Organization Organization { get; }

        public User(string login, string password, string lastName, string firstName, Role role,
            Organization organization)
        {
            Login = login;
            Password = password;
            LastName = lastName;
            FirstName = firstName;
            Role = role;
            Organization = organization;
            
            //TODO: Создание юзера в бд
        }
    }
}