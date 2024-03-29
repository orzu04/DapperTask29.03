using Domain;
using Dapper;
namespace Infrastructure;

public class StudentGroupService : IStudentGroupService
{

    DapperContext dapperContext = new DapperContext();
    public string AddStudentGroup(StudentGroup studentGroup)
    {
       var sql = $"INSERT INTO StudentGroup (Stud_id,Gr_id)" +
                      $"values({studentGroup.St_id},{studentGroup.Gr_id})";
            var result =dapperContext.Connection().Execute(sql);
            if (result > 0) return "Successfully added studentGroup";
             return "Failed to add studentGroup";
    }

    public bool DeleteStudentGroup(int id)
    {
         var sql = $"delete  from StudentGroup  as sg where sg.id={@id}";
            var result =dapperContext.Connection().Execute(sql);
            if(result>0) return true;
            return false;
    }

    public StudentGroup GetStudentGroupById(int id)
    {
        var sql = $"Select * from StudentGroup  as sg where sg.id={@id} ";
            var result = dapperContext.Connection().QueryFirstOrDefault<StudentGroup>(sql);
            return result;
        
    }

    public List<StudentGroup> GetStudentGroups()
    {
        var sql = "Select * from StudentGroup ";
            var result =dapperContext.Connection().Query<StudentGroup>(sql);
            return result.ToList();
    }

    public string UpdateStudentGroup(StudentGroup studentGroup)
    {
        var sql = $"Update StudentGroup  SET Stud_id={studentGroup.St_id}" +
                      $", Gr_id={studentGroup.Gr_id}" +
                      $"where id={studentGroup.Id}";
            
            var result =dapperContext.Connection().Execute(sql);
            if (result > 0) return "Successfully updated studentGroup";
            return "Failed to update studentGroup"; 
    }
}
