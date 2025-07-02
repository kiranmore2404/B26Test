using ApplicationData.Models;

namespace ApplicationData.Repository
{
    public interface Istudent
    {
        List<StudentModel> GetAllstudent();
        StudentModel GetstudentById(int id);
    }
}
