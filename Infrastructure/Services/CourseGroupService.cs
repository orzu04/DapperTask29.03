using Domain;
using Dapper;
namespace Infrastructure;

public class CourseGroupService : ICourseGroupService

{

    DapperContext dapperContext = new DapperContext();
    public string AddCourseGroup(CourseGroup courseGroup)
    {
        var sql = $"INSERT INTO CourseGroup (Cours_id,Gr_id)" +
                      $"values({courseGroup.Course_id},{courseGroup.Grp_Id})";
            var result =dapperContext.Connection().Execute(sql);
            if (result > 0) return "Successfully added courseGroup";
             return "Failed to add courseGroup";
    }

    public bool DeeteCourseGroup(int id)
    {
         var sql = $"delete  from CourseGroup  as cg where cg.id={@id}";
            var result = dapperContext.Connection().Execute(sql);
            if(result>0) return true;
            return false;
    }

    public CourseGroup GetCourseGroupByID(int id)
    {
           var sql = $"Select * from  CourseGroup as cg where cg.id={@id} ";
            var result = dapperContext.Connection().QueryFirstOrDefault<CourseGroup>(sql);
            return result;
        
    }

    public List<CourseGroup> GetCourseGroups()
    {
       var sql = "Select * from CourseGroup ";
            var result = dapperContext.Connection().Query<CourseGroup>(sql);
            return result.ToList();
    }

    public string UpdateCourseGroup(CourseGroup courseGroup)
    {
            var sql = $"Update CourseGroup SET Cours_id={courseGroup.Course_id}" +
                      $", Gr_id={courseGroup.Grp_Id}" +
                      $"where id={courseGroup.Id}";
            
            var result =dapperContext.Connection().Execute(sql);
            if (result > 0) return "Successfully updated course";
            return "Failed to update course";
    }
}
