namespace PRITT
{
    public class Role
    {
        private string Name { get; }
        private bool CanEditAnimals { get; }
        private bool CanEditOrganizations { get; }
        private bool CanEditMunicipalContracts { get; }

        public Role(string name, bool canEditAnimals, bool canEditOrganizations, bool canEditMunicipalContracts)
        {
            Name = name;
            CanEditAnimals = canEditAnimals;
            CanEditOrganizations = canEditOrganizations;
            CanEditMunicipalContracts = canEditMunicipalContracts;
            
            //TODO: Создание роли в бд
        }
    }
}