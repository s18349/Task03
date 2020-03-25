using System.Collections.Generic;
using Task03.Models;

namespace Task03.Services
{
    public interface IDbService
    {
        public IEnumerable<Student> GetStudents();
    }
}