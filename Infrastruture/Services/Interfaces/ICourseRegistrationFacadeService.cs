using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.Interfaces
{
    public interface ICourseRegistrationFacadeService
    {
        void RegisterStudentForCourse(int studentId, int courseId);
        void AssignTeacherToCourse(int teacherId, int courseId);
    }
}
