using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Input;

namespace PRITT
{
    public static class AnimalController
    {
        private static Animal CurrentAnimal { get; set; }

        public static void CreateVaccination(string vaccinationType, int vaccineDuration, string serialNumber,
            MunicipalContract municipalContract)
        {
            var vaccination = new Vaccination(CurrentAnimal, DateTime.Now, vaccinationType, serialNumber,
                DateTime.Now.AddDays(vaccineDuration), AuthorizeController.CurrentUser, municipalContract);
            /*Добавление в бд*/
        }

        public static void CreateAnimal(string registrationNumber, DateTime birthday, string chipNumber, int animalCategory,
            string nickname, string gender, string specialSigns, Image photo)
        {
            Animal animal = new Animal(registrationNumber, birthday, chipNumber, animalCategory, nickname, gender,
                specialSigns, AuthorizeController.CurrentUser.Organization.Locality, photo);
            /*Добавление в бд*/
        }

        public static void UpdateAnimal(Animal animal, string chipNumber, string nickname, string specialSigns)
        {
            animal.ChipNumber = chipNumber;
            animal.Nickname = nickname;
            animal.SpecialSigns = specialSigns;
            /*Запрос в бд для обновления записи животного*/
        }

        public static void DeleteAnimal(Animal animal)
        {
            /*Удаление записи животного в бд*/
        }

        public static void GetAnimalList()
        {
            /*Fetch all animals*/
        }
    }
}