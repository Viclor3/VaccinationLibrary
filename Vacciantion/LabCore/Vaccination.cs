using System;

namespace PRITT
{
    public class Vaccination
    {
        public Animal Animal { get; }
        public DateTime VaccinationDate { get; }
        public string VaccinationType { get; }
        public string SerialNumber { get; }
        public DateTime ExpirationDate { get; }
        public User Vet { get; }
        public MunicipalContract MunicipalContract { get; }

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