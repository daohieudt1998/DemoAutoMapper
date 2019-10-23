using Data.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IStudentClass
    {
        IEnumerable<ClassStudent> GetAllStudent();
        Task<ClassStudent> GetByIdAsync(int id);
        Task<ClassStudent> CreateAsync(ClassStudent student);
        Task<ClassStudent> UpdateAsync(ClassStudent student);
        Task<IActionResult> DeleteAsync(int id);
    }
}
