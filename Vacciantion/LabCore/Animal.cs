using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace PRITT
{
    public class Animal
    {
        public string RegistrationNumber { get; }
        public DateTime Birthday { get; }
        public string ChipNumber { get; set; }
        public int Category { get; }
        public string Nickname { get; set; }
        public int Gender { get; }
        public List<Image> Photos { get; }
        public string SpecialSigns { get; set; }
        public Locality Locality { get; }

        public Animal(string registrationNumber, DateTime birthday, string chipNumber, int category,
            string nickname, int gender, string specialSigns, Locality locality)
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
        }

        public void AddPhoto(Image photo)
        {
            Photos.Add(photo);
        }

        public void DeletePhoto(int number)
        {
            Photos.RemoveAt(number);
        }
    }
}