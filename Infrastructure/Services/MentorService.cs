using Domain;
using Dapper;
namespace Infrastructure;

public class MentorService : IMentorService
{


    DapperContext dapperContext = new DapperContext();
    public string AddMentor(Mentors mentor)
    {
        var sql= $"Insert into Mentors (M_name,M_price,M_expirens)"+
       $"values('{mentor.Name}',{mentor.price},{mentor.Expirens})";
     var result =dapperContext.Connection().Execute(sql);
     if(result>0) return "Successfully added mentor";
      return "Failed to add mentor";
    }

    public bool DeleteMentor(int id)
    {
        var sql = $"delete  from Mentors as m where m.id={@id}";
            var result =dapperContext.Connection().Execute(sql);
            if(result>0) return true;
            return false;
    }

    public Mentors GetMentorById(int id)
    {
         var sql = $"Select * from Mentors as m where m.id={@id} ";
            var result = dapperContext.Connection().QueryFirstOrDefault<Mentors>(sql);
            return result;
    }

    public List<Mentors> GetMentors()
    {
        var sql = "Select * from Mentors ";
            var result =dapperContext.Connection().Query<Mentors>(sql);
            return result.ToList();
    }

    public string UpdateMentor(Mentors mentor)
    {
       var sql = $"Update Mentors SET M_name='{mentor.Name}'" +
                      $", M_price={mentor.price}" +
                      $",M_expirens={mentor.Expirens}"+
                      $"where id={mentor.Id}";
            
            var result = dapperContext.Connection().Execute(sql);
            if (result > 0) return "Successfully updated mentor";
            return "Failed to update mentor";
    }
}
