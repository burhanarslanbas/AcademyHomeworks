using ReactHomework3.Question5.AbstractExamples.SecondExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactHomework3.Question5.InterfaceExamples.SecondExample
{
    public interface IUserRepository : IGenericRepository<User>
    {
        User AuthenticateUser(string email, string password);
        IEnumerable<User> GetTeachersByInstitutionId(int? institutionId);
    }
}
