using Domain;
using Dapper;
namespace Infrastructure;

public class MentorCourseService : IMentorCourseService
{


DapperContext dapperContext = new DapperContext();

    public string AddMentorCourse(MentorCourse mentorCourse)
    {
       var sql = $"INSERT INTO MentorCourse (Men_id,Cours_id)" +
                      $"values({mentorCourse.Men_Id},{mentorCourse.Cours_Id})";
            var result = dapperContext.Connection().Execute(sql);
            if (result > 0) return "Successfully added mentorCourse";
             return "Failed to add mentorCourse";
    }

    public bool DeleteMentorCourse(int id)
    {
          var sql = $"delete  from  MentorCourse as mc where mc.id={@id}";
            var result =dapperContext.Connection().Execute(sql);
            if(result>0) return true;
            return false;
    }

    public MentorCourse GetMentorCourseById(int id)
    {
      var sql = $"Select * from  MentorCourse as mc where mc.id={@id} ";
            var result =dapperContext.Connection().QueryFirstOrDefault<MentorCourse>(sql);
            return result;
    }

    public List<MentorCourse> GetMentorCourses()
    {
          var sql = "Select * from MentorCourse ";
            var result =dapperContext.Connection().Query<MentorCourse>(sql);
            return result.ToList();
    }

    public string UpdateMentorCourse(MentorCourse mentorCourse)
    {
        var sql = $"Update MentorCourse SET Men_id={mentorCourse.Men_Id}" +
                      $", Cours_id={mentorCourse.Cours_Id}" +
                      $"where id={mentorCourse.Id}";
            
            var result =dapperContext.Connection().Execute(sql);
            if (result > 0) return "Successfully updated mentorCourse";
            return "Failed to update mentorCourse";
    }
}
