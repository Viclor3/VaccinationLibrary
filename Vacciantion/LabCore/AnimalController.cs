using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace PRITT
{
    public class AnimalController
    {
        public Animal CurrentAnimal { get; private set; }

        public AnimalController()
        {
            CurrentAnimal = null;
        }

        public void CreateVaccination(string vaccinationType, int vaccineDuration, string serialNumber,
            MunicipalContract municipalContract)
        {
            var vaccination = new Vaccination(CurrentAnimal, DateTime.Now, vaccinationType, serialNumber,
                DateTime.Now.AddDays(vaccineDuration), AuthorizeController.CurrentUser, municipalContract);
            /*Добавление в бд*/
        }

        public void CreateAnimal(string registrationNumber, DateTime birthday, string chipNumber, int animalCategory,
            string nickname, int gender, string specialSigns)
        {
            Animal animal = new Animal(registrationNumber, birthday, chipNumber, animalCategory, nickname, gender,
                specialSigns, AuthorizeController.CurrentUser.Organization.Locality);
            /*Добавление в бд*/
        }

        public void UpdateAnimal(Animal animal, string chipNumber, string nickname, string specialSigns)
        {
            animal.ChipNumber = chipNumber;
            animal.Nickname = nickname;
            animal.SpecialSigns = specialSigns;
            /*Запрос в бд для обновления записи животного*/
        }

        public void DeleteAnimal(Animal animal)
        {
            /*Удаление записи животного в бд*/
        }

        public void GetAnimalList()
        {
            /*Fetch all animals*/
        }
    }
}