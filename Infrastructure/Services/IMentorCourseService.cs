using Domain;

namespace Infrastructure;

public interface IMentorCourseService
{

List<MentorCourse> GetMentorCourses();
MentorCourse GetMentorCourseById(int id);
string AddMentorCourse(MentorCourse mentorCourse);
string UpdateMentorCourse(MentorCourse mentorCourse);
bool DeleteMentorCourse(int id);

}
