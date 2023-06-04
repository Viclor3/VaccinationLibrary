namespace PRITT
{
    public class Organization
    {
        public int Id { get; }
        public string FullName { get; }
        public string Inn { get; }
        public string Kpp { get; }
        public string RegistrationAdress { get; set; }
        public int OrganizationType { get; set; }
        public bool NaturalOrLegalPerson { get; }
        public Locality Locality { get; set; }

        public Organization(int id, string fullName, string inn, string kpp, string registrationAdress,
            bool naturalOrLegalPerson, Locality locality, int organizationType)
        {
            Id = id;
            FullName = fullName;
            Inn = inn;
            Kpp = kpp;
            RegistrationAdress = registrationAdress;
            NaturalOrLegalPerson = naturalOrLegalPerson;
            Locality = locality;
            OrganizationType = organizationType;
        }
        
        
    }
}