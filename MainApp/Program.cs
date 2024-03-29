



using Domain;
using Infrastructure;

var studentService = new StudentService();

var students = new Students(){

Firstname = "Toni",
Lastname = "Ferguson",
 Ege = 20



};


studentService.AddStudent(students);
   var result= studentService.GetCourses();
// var getbyid= studentService.GetStudentById(3);

//var upd = studentService.UpdateStudent(students);
//studentService.DeleteStudent(2);
//_________________________________________________-


var courseService = new CourseService();

var course = new Courses(){
    name = "C#",
    price = 1500,
    description = "Good Course"


};

courseService.AddCourse(course);

courseService.GetCourses();
//var cUpd= courseService.UpdateCourse(course);
//var cgetid= courseService.GetCoursesById(3);
//var cdel = courseService.DeleteCourse(2);


//___________________________________________________



var mentorService = new MentorService();

var mentor = new Mentors(){

Name = "Pol",
price = 2000,
Expirens = 3


};


mentorService.AddMentor(mentor);
mentorService.GetMentors();
// var mdel=  mentorService.DeleteMentor(2);
//var mfetid = mentorService.GetMentorById(1);




//______________________________________________________




var groupService = new GroupService();

var group = new Groups(){

 Count_student = 10,
 Count_groups = 5


};

groupService.AddGroup(group);
groupService.GetGroups();
//var delg = groupService.DeleteGroup(1);
//var getidg= groupService.GetGroupById(2);



//________________________________________________



var mentorcourseService = new MentorCourseService();

var mentorcourse= new MentorCourse(){

Men_Id = 2,
Cours_Id = 3



};

mentorcourseService.AddMentorCourse(mentorcourse);
mentorcourseService.GetMentorCourses();
//var delm= mentorService.DeleteMentor(2);
 //var getidm= mentorService.GetMentorById(1);

//______________________________________________________________



var studentgroupservice = new StudentGroupService();

var studentgroup = new StudentGroup(){


St_id = 1,
Gr_id = 3



};

 studentgroupservice.AddStudentGroup(studentgroup);
 studentgroupservice.GetStudentGroups();



//__________________________________________________________



var coursegroupservice = new CourseGroupService();
var coursegroup = new CourseGroup(){

Course_id = 2,
Grp_Id = 1


};

coursegroupservice.AddCourseGroup(coursegroup);
coursegroupservice.GetCourseGroups();




