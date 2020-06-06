using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Model;

namespace DataAccess
{
    public interface IPeopleData
    {
        Task<List<PersonModel>> GetPeople();
        Task InsertPerson(PersonModel person);
    }
}