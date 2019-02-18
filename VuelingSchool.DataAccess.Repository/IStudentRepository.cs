using VuelingSchool.Common.Library.Models;


namespace VuelingSchool.DataAccess.Repository
{
    public interface IStudentRepository
    {
        Student AddStudent(Student s);

        void ShowAllStudents();

        Student FoundStudentById(Student s);

        void UpdateStudentById(Student s);

        void DeleteStudentById(Student s);

    }
}
