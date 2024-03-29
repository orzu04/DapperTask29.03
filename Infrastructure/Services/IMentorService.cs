using Domain;

namespace Infrastructure;

public interface IMentorService
{

   List<Mentors> GetMentors();
    Mentors GetMentorById(int id);
    string AddMentor(Mentors mentor);
    string UpdateMentor(Mentors mentor);
    bool DeleteMentor(int id);



}
