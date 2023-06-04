namespace PRITT
{
    public class AuthorizeController
    {
        public static User CurrentUser { get; private set; }

        public AuthorizeController()
        {
            CurrentUser = null;
        }

        public void Authorize(string login, string password)
        {
            if (true)
            {
                CurrentUser = null;
            }
        }
    }
}