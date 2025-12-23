using Attend.Application;

namespace Attend.Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myStudent = new Services();

            myStudent.AddStudent(" birinchi", "birinchi", "1110", "biirinchi@gmail.com");
            myStudent.AddStudent(" ikkinchi", "ikkinchi", "1110", "ikkinchi@gmail.com");
            myStudent.AddStudent(" uchinchi", "uchinchi", "1110", "uchinchi@gmail.com");

            myStudent.GetAllStudents();


            myStudent.AddAttendence(new DateTime(2025, 12, 23, 9, 0, 0), new DateTime(2025, 12, 23, 10, 30, 0), 60, 5);
            myStudent.GetAllAttends();
        }
    }
}
