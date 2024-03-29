using  Npgsql;
using Domain;
namespace Infrastructure;
using Dapper;

public class CourseService : ICourseService
{
    DapperContext dapperContext = new DapperContext();
    public string AddCourse(Courses course)
    {
         var sql = $"INSERT INTO Courses (C_name,C_price,C_discription)" +
                      $"values('{course.name}',{course.price},'{course.description}')";
            var result = dapperContext.Connection().Execute(sql);
            if (result > 0) return "Successfully added course";
             return "Failed to add course";
    }

    public bool DeleteCourse(int id)
    {
         var sql = $"delete  from Courses as c where c.id={@id}";
            var result = dapperContext.Connection().Execute(sql);
            if(result>0) return true;
            return false;
    }

    public List<Courses> GetCourses()
    {
         var sql = "Select * from Courses ";
            var result = dapperContext.Connection().Query<Courses>(sql);
            return result.ToList();
    }

    public Courses GetCoursesById(int id)
    {
        var sql = $"Select * from Courses where id={@id} ";
            var result = dapperContext.Connection().QueryFirstOrDefault<Courses>(sql);
            return result;
    }

    public string UpdateCourse(Courses course)
    {
        var sql = $"Update Courses SET C_name='{course.name}'" +
                      $", C_price='{course.price}',C_discription='{course.description}'" +
                      $"where id={course.id}";
            
            var result = dapperContext.Connection().Execute(sql);
            if (result > 0) return "Successfully updated course";
            return "Failed to update course";
    }
}
