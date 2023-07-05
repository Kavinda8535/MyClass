using ApplicationDomain.Entities;
using Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class CourseRepository : ICourseRepository
    {

        private readonly ApplicationDbContext _applicationDbContext;

        public CourseRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return _applicationDbContext.Courses.ToList();
        }

        public void InsertCourse(Course course)
        {
            _applicationDbContext.Courses.Add(course);
            _applicationDbContext.SaveChanges();
        }

        public Course GetById(int courseId)
        {
            return _applicationDbContext.Courses
            .Include(c => c.Students)
            .FirstOrDefault(c => c.Id == courseId);
        }

        public void Update(Course course)
        {
            _applicationDbContext.Courses.Update(course);
            _applicationDbContext.SaveChanges();
        }




        #region sqlConnection
        //private readonly string _connectionString;

        //public CourseRepository(string connectionString)
        //{
        //    _connectionString = connectionString;
        //}


        //public async Task<IEnumerable<Course>> GetAllCoursesAsync()
        //{
        //    using (var connection = new SqlConnection(_connectionString))
        //    {
        //        await connection.OpenAsync();
        //        var command = new SqlCommand("GetAllCourses", connection);
        //        command.CommandType = CommandType.StoredProcedure;

        //        var courses = new List<Course>();

        //        using (var reader = await command.ExecuteReaderAsync())
        //        {
        //            while (reader.Read())
        //            {
        //                var course = new Course
        //                {
        //                    CourseId = reader.GetInt32("CourseId"),
        //                    CourseName = reader.GetString("CourseName"),
        //                    CourseDescription = reader.GetString("CourseDescription"),
        //                    TeacherId = reader.GetInt32("TeacherId")
        //                };
        //                courses.Add(course);
        //            }
        //        }

        //        return courses;
        //    }
        //}
        #endregion
    }

}
