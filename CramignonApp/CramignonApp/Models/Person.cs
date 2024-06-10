using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace CramignonApp.Models
{
    public class Person : INotifyPropertyChanged
    {
        private string firstName = "";
        private string lastName = "";
        public event PropertyChangedEventHandler? PropertyChanged;


        public Person()
        { }
        public Person(int id, string firstName, string lastName, string village, string comite, string telNumb, Gender genre, string mainLanguage)
        {
            PersonID = id;
            FirstName = firstName;
            LastName = lastName;
            FullName = $"{firstName} {lastName}";
            Village = village;
            Comite = comite;
            TelNumb = telNumb;
            Genre = genre;
            MainLanguage = mainLanguage;
        }


        public int PersonID { get; set; }
        public string FullName { get; set; }
        public string Village { get; set; }
        public string Comite { get; set; }
        public string TelNumb { get; set; }
        public Gender Genre { get; set; }
        public string MainLanguage { get; set; }
        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                FullName = $"{firstName} {lastName}";
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                FullName = $"{firstName} {lastName}";
            }
        }



        public enum Gender
        {
            Male,
            Female,
            Other
        }


    }
}
