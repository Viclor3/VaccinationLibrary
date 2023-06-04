using System;
using System.Collections.Generic;

namespace PRITT
{
    public class MunicipalContract
    {
        public int Id { get; }
        public string ContractNumber { get; }
        public DateTime AgreementDate { get; }
        public DateTime ValidityDate { get; }
        public Organization Customer { get; }
        public Organization Contractor { get; }
        public List<Locality> Localitieses { get; set; }

        public MunicipalContract(int id, string contractNumber, DateTime agreementDate, DateTime validityDate,
            Organization customer, Organization contractor, List<Locality> localities)
        {
            Id = id;
            ContractNumber = contractNumber;
            AgreementDate = agreementDate;
            ValidityDate = validityDate;
            Customer = customer;
            Contractor = contractor;
            Localitieses = localities;
        }
    }
}