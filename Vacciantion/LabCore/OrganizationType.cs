namespace PRITT
{
    public class OrganizationType
    {
        private string OrganizationTypeName { get; }

        public OrganizationType(string name)
        {
            OrganizationTypeName = name;
            
            //TODO: Создание типа организации в бд
        }
    }
}