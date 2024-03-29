using Domain;

namespace Infrastructure;

public interface IStudentGroupService
{

List<StudentGroup> GetStudentGroups();
StudentGroup GetStudentGroupById(int id);
string AddStudentGroup(StudentGroup studentGroup);
string UpdateStudentGroup(StudentGroup studentGroup);
bool DeleteStudentGroup(int id);

}
