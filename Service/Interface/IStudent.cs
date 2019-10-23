using Data.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IStudent
    {
        IEnumerable<Student> GetAllStudent();
        Task<Student> GetByIdAsync(int id);
        Task<Student> CreateAsync(Student student);
        Task<Student> UpdateAsync(Student student);
        Task<IActionResult> DeleteAsync(int id);
    }
}
