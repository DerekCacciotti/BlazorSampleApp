using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Model;

namespace DataAccess
{
    public class PeopleData : IPeopleData
    {
        private readonly ISQLDataAccess _db;

        public PeopleData(ISQLDataAccess db)
        {
            _db = db;
        }

        public Task<List<PersonModel>> GetPeople()
        {
            string sql = "select * from people";

            return _db.LoadData<PersonModel, dynamic>(sql, new { });
        }

        public Task InsertPerson(PersonModel person)
        {
            string sql = "insert into people (FirstName, LastName, EmailAddress) values (@FirstName, @LastName, @EmailAddress)";
            return _db.SaveData(sql, person);

        }
    }
}
