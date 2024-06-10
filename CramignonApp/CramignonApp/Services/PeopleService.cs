using CramignonApp.Models;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CramignonApp.Services
{
    public class PeopleService : IPeopleService
    {
        IList<Person> _people = [
            new() {PersonID=0,Comite="Eben",FirstName="Matha",LastName="Verb",Genre=Person.Gender.Male,MainLanguage="FR",TelNumb="8",Village="Eben" },
            new() {PersonID=1,Comite="Eben",FirstName="Cam",LastName="Blaff",Genre=Person.Gender.Female,MainLanguage="FR",TelNumb="9",Village="Eben" }

            ];
        string url = "https://cramignonapp-default-rtdb.europe-west1.firebasedatabase.app";
        ChildQuery query;

        public PeopleService()
        {
            query = new FirebaseClient(url).Child("data");

        }
        public void AddPerson()
        {
            throw new NotImplementedException();
        }


        public async Task<IList<Person>> GetAll()
        {
            List<Person> list = new();
            var p = await query.Child("people").Child("people").OnceAsListAsync<Person>();
            foreach (FirebaseObject<Person> item in p)
            {
                list.Add(item.Object);
            }
            return list;
        }
    }
}
