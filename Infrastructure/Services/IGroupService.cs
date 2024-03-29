using Domain;

namespace Infrastructure;

public interface IGroupService
{

   List<Groups> GetGroups();
    Groups GetGroupById(int id);
    string AddGroup(Groups group);
    string UpdateGroup(Groups group);
    bool DeleteGroup(int id);

}
