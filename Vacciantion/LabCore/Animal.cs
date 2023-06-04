using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace PRITT
{
    public class Animal
    {
        private string RegistrationNumber { get; }
        private DateTime Birthday { get; }
        public string ChipNumber { get; set; }
        private int Category { get; }
        public string Nickname { get; set; }
        private string Gender { get; }
        private List<Image> Photos { get; }
        public string SpecialSigns { get; set; }
        private Locality Locality { get; }

        public Animal(string registrationNumber, DateTime birthday, string chipNumber, int category,
            string nickname, string gender, string specialSigns, Locality locality, Image photo)
        {
            RegistrationNumber = registrationNumber;
            Birthday = birthday;
            ChipNumber = chipNumber;
            Category = category;
            Nickname = nickname;
            Gender = gender;
            Photos = new();
            SpecialSigns = specialSigns;
            Locality = locality;

            //TODO: Создание животного в бд
        }

        public void EditPhoto(Image photo)
        {
            Photos.Add(photo);
            
            //TODO: Изменение фотографий в бд
        }

        public void DeletePhoto(int number)
        {
            Photos.RemoveAt(number);
            
            //TODO: Удаление фото животного в бд
        }
    }
}