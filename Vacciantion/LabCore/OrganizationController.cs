using System.Collections.Generic;

namespace PRITT;

public static class OrganizationController
{
    private static Organization CurrentOrganization { get; set; }

    public static void CreateOrganization(string fullName, string inn, string kpp, string registrationAddress,
        bool naturalOrLegalPerson, Locality locality, OrganizationType organizationType)
    {
        // TODO: Создание организации в бд
    }

    public static void UpdateCurrentOrganization(string registrationAddress, int organizationType, Locality locality)
    {
        // TODO: Обновление организации в бд
    }

    public static void DeleteCurrentOrganization()
    {
        // TODO: Удаление организации в бд
    }

    public static List<Organization> GetOrganizationList()
    {
        return new List<Organization>(); 
        
        // TODO: Вывод списка всех организаций
    }
}