using ApplicationData.Models;

namespace ApplicationData.Repository
{
    public class StudentRepo : Istudent
    {
        public List<StudentModel> GetAllstudent()
        {
            return DataSource();

        }

        public StudentModel GetstudentById(int id)
        {
            return DataSource().Where(x => x.rollNo == id).FirstOrDefault();


        }
        private List<StudentModel> DataSource()
        {
            return new List<StudentModel>
            {
                new StudentModel  {rollNo=1, name="kiran",Gender = "male",Standard = 12 },
                new StudentModel {rollNo=2, name="kishor" ,Gender = "male",Standard = 10 },
                new StudentModel  {rollNo=3, name="Shiv",Gender = "male",Standard = 12  }
                };

        }
    }
}
