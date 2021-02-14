using System;
using System.Linq;
using System.Threading.Tasks;

namespace szkchm_azdev_t3_frontend2.Data
{
    public class PersonService
    {
        public Task<Person[]> GetPersonAsync(int id)
        {
            
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new Person
            {
                Id = index,
                FirstName = "FirstName" + index.ToString(),
                LastName = "LastName" + index.ToString()
            }).ToArray());
        }
    }
}