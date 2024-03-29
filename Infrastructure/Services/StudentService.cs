using Domain;
using Dapper;
namespace Infrastructure;

public class StudentService : IStudentService
{

    DapperContext dapperContext = new DapperContext();
    public string AddStudent(Students student)
    {
         var sql= $"Insert into Students (S_firsname,S_lastname,S_age)"+
       $"values('{student.Firstname}','{student.Lastname}',{student.Ege})";
     var result =dapperContext. Connection().Execute(sql);
     if(result>0) return "Successfully added student";
      return "Failed to add student";

    }

    public bool DeleteStudent(int id)
    {
     var sql = $"delete  from Students as s where s.id={@id}";
            var result = dapperContext.Connection().Execute(sql);
            if(result>0) return true;
            return false;  
    }

    public List<Students> GetCourses()
    {
    
        var sql = "Select * from Students ";
            var result =dapperContext.Connection().Query<Students>(sql);
            return result.ToList();
    }

    public Students GetStudentById(int id)
    {
       var sql = $"Select * from Students as s where s.id={@id} ";
            var result =dapperContext.Connection().QueryFirstOrDefault<Students>(sql);
            return result;
    }

    public string UpdateStudent(Students student)
    {
       var sql = $"Update Students SET S_firsname='{student.Firstname}'" +
                      $", S_lastname='{student.Lastname}'" +
                      $",S_age={student.Ege}"+
                      $"where id={student.Id}";
            
            var result =dapperContext.Connection().Execute(sql);
            if (result > 0) return "Successfully updated student";
            return "Failed to update student";   
    }
}
