using VuelingSchool.Common.Library.Models;


namespace VuelingSchool.DataAccess.Repository
{
    public interface IStudentRepository
    {
        Student AddStudent(Student s);

        Student ReadAllStudents(Student s);

        Student ReadStudentById(Student s);

    }
}
