using System;
using Microsoft.AspNetCore.Mvc;
using Task03.Models;
using Task03.Services;

namespace Task03.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentController : Controller
    {
        
        private IDbService _dbService;

        public StudentController(IDbService dbService)
        {
            _dbService = dbService;
        }


        [HttpGet]
        public IActionResult GetStudent(string orderBy) // action method
        {
            // int age = 15;
            // var s1 = "Ala is" +age + " years old";
            // var s2 = string.Format("Ala is {0} years old", age);
            // var s3 = $"Ala is {age} years old";//string interprolation
            return Ok(_dbService.GetStudents());
        }

        // [HttpGet("{id}")]
        // //1. how to pass data using URL segment
        // public IActionResult GetStudent(int id)
        // {
        //     if (id == 1)
        //     {
        //         return Ok("Jongok");
        //     }
        //
        //     else if (id == 2)
        //     {
        //         return Ok("Okjong");
        //     }
        //
        //     return NotFound("Student was not found");
        // }
        
        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            student.IndexNumber = $"s{new Random().Next(1, 2000)}";
            return Ok(student);
        }
       

        [HttpPut("{id}")]
        public IActionResult PutMethod(int id)
        {
            return Ok("Put completed");
        }
        
        [HttpDelete("{id}")]
        public IActionResult DeleteMethod(int id)
        {
            return Ok("Delete completed");
        }
        
    }


}