using Domain;

namespace Infrastructure;

public interface ICourseService
{

     List<Courses> GetCourses();
    Courses GetCoursesById(int id);
    string AddCourse(Courses course);
    string UpdateCourse(Courses course);
    bool DeleteCourse(int id);

}
