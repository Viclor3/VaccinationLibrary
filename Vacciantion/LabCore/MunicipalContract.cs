using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace PRITT
{
    public class MunicipalContract
    {
        private string ContractNumber { get; }
        private DateTime AgreementDate { get; }
        private DateTime ValidityDate { get; }
        private Organization Customer { get; }
        private Organization Contractor { get; }
        private List<Locality> Localities { get; set; }
        private Image Photo { get; }

        public MunicipalContract(string contractNumber, DateTime agreementDate, DateTime validityDate,
            Organization customer, Organization contractor, Image photo, List<Locality> localities)

        {
            ContractNumber = contractNumber;
            AgreementDate = agreementDate;
            ValidityDate = validityDate;
            Customer = customer;
            Contractor = contractor;
            Localities = localities;
            Photo = photo;
            
            //TODO: Создание контракта в бд
        }

        public void EditPhoto(Image photo)
        {
            //TODO: Изменение фото контракта в бд
        }

        public void DeletePhoto(Image photo)
        {
            //TODO: Удаление фото контракта в бд
        }
    }
}