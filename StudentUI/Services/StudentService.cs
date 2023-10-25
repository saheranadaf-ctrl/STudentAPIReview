namespace StudentUI.Services
{
    public class StudentService : IStudentService
    {
        private readonly HttpClient httpClient;
        public StudentService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public Task<IEnumerable<Student>> AddStudent()
        {
            throw new NotImplementedException();
        }
    }
}
