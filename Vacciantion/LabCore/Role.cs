namespace PRITT
{
    public class Role
    {
        public int Id { get; }
        public string Name { get; }
        public bool CanEditAnimals { get; }
        public bool CanEditOrganizations { get; }
        public bool CanEditMunicipalContracts { get; }

        public Role(int id, string name, bool canEditAnimals, bool canEditOrganizations, bool canEditMunicipalContracts)
        {
            Id = id;
            Name = name;
            CanEditAnimals = canEditAnimals;
            CanEditOrganizations = canEditOrganizations;
            CanEditMunicipalContracts = canEditMunicipalContracts;
        }
    }
}