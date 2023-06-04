using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace PRITT;

public static class MunicipalContractController
{
    private static MunicipalContract CurrentMunicipalContract { get; set; }
    
    public static void CreateMunicipalContract(string contractNumber, DateTime agreementDate, DateTime validityDate,
        Organization customer, Organization contractor, List<Locality> localities, Image photo)
    {
        // TODO: Создание контракта в бд
    }

    public static void UpdateCurrentMunicipalContract(List<Locality> localities, Image photo)
    {
        // TODO: Обновление контракта в бд
    }

    public static void DeleteCurrentMunicipalContract()
    {
        // TODO: Удаление контратка в бд
    }
}