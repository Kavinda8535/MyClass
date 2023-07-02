using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class CourseRepository
    {
            //private readonly string _connectionString;

            //public CourseRepository(string connectionString)
            //{
            //    _connectionString = connectionString;
            //}

            private readonly ApplicationDbContext _dbContext;

            public CourseRepository(ApplicationDbContext dbContext)
            {
                _dbContext = dbContext;
            }

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
    }

    }
