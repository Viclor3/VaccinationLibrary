namespace PRITT
{
    public class Organization
    {
        private string FullName { get; }
        private string Inn { get; }
        private string Kpp { get; }
        private string RegistrationAddress { get; set; }
        private int OrganizationType { get; set; }
        private bool NaturalOrLegalPerson { get; }
        public Locality Locality { get; private set; }

        public Organization(string fullName, string inn, string kpp, string registrationAddress,
            bool naturalOrLegalPerson, Locality locality, int organizationType)
        {
            FullName = fullName;
            Inn = inn;
            Kpp = kpp;
            RegistrationAddress = registrationAddress;
            NaturalOrLegalPerson = naturalOrLegalPerson;
            Locality = locality;
            OrganizationType = organizationType;
            
            //TODO: Создание организации в бд
        }
        
        
    }
}