using CramignonApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CramignonApp.Services
{
    public interface IPeopleService
    {
        Task<IList<Person>> GetAll();

        void AddPerson();
    }
}
