namespace StudentUI.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> AddStudent();
    }
}
