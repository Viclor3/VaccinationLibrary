using System;

namespace PRITT
{
    public class Vaccination
    {
        private Animal Animal { get; }
        private DateTime VaccinationDate { get; }
        private string VaccinationType { get; }
        private string SerialNumber { get; }
        private DateTime ExpirationDate { get; }
        private User Vet { get; }
        private MunicipalContract MunicipalContract { get; }

        public Vaccination(Animal animal, DateTime vaccinationDate, string vaccinationType, string serialNumber,
            DateTime expirationDate, User vet, MunicipalContract municipalContract)
        {
            Animal = animal;
            VaccinationDate = vaccinationDate;
            VaccinationType = vaccinationType;
            SerialNumber = serialNumber;
            ExpirationDate = expirationDate;
            Vet = vet;
            MunicipalContract = municipalContract;
        }
    }
}