using Domain;

namespace Infrastructure;

public interface ICourseGroupService
{

  List<CourseGroup> GetCourseGroups();
  CourseGroup GetCourseGroupByID(int id);
  string AddCourseGroup(CourseGroup courseGroup);
  string UpdateCourseGroup (CourseGroup courseGroup);
  bool DeeteCourseGroup (int id);

}
