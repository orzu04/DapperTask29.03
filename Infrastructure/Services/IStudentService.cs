using Domain;

namespace Infrastructure;

public interface IStudentService
{

   List<Students> GetCourses();
    Students GetStudentById(int id);
    string AddStudent(Students student);
    string UpdateStudent(Students student);
    bool DeleteStudent(int id);


}
