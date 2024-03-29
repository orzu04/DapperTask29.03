using System.Data;
using Domain;
using Npgsql;
using Dapper;
namespace Infrastructure;

public class GroupService : IGroupService
{
    DapperContext dapperContext = new DapperContext();

   
    public string AddGroup(Groups group)
    {
        var sql= $"Insert into Groups (Count_student,Count_groups)"+
       $"values({group.Count_student},{group.Count_groups})";
     var result = dapperContext.Connection().Execute(sql);
     if(result>0) return "Successfully added group";
      return "Failed to add group";

    }

    public bool DeleteGroup(int id)
    {
        var sql = $"delete  from Groups as g where g.id={@id}";
            var result = dapperContext.Connection().Execute(sql);
            if(result>0) return true;
            return false;
    }

    public Groups GetGroupById(int id)
    {
         var sql = $"Select * from Groups as g where g.id={@id} ";
            var result = dapperContext.Connection().QueryFirstOrDefault<Groups>(sql);
            return result;
    }

    public List<Groups> GetGroups()
    {
        var sql = "Select * from Groups ";
            var result = dapperContext.Connection().Query<Groups>(sql);
            return result.ToList();
    }

    public string UpdateGroup(Groups group)
    {
            var sql = $"Update Groups SET Count_student={group.Count_student}" +
                      $", Count_groups={group.Count_groups}" +
                      $"where id={group.id}";
            
            var result =dapperContext.Connection().Execute(sql);
            if (result > 0) return "Successfully updated group";
            return "Failed to update group";
    }
}
