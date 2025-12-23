using Attend.Domain.Models;
using Attend.Infrastructure.Data;

namespace Attend.Application
{
    public class Services
    {
        public DbContext Context { get; set; }
        public Services()
        {
            this.Context = new DbContext();
        }

        public void AddStudent(string firstName, string lastName, string code, string email)
        {
            var newStudent = new Student
            {
               FirstName=firstName,
               LastName=lastName,
               Code=code,
               Email=email
            };

            this.Context.Students.Add(newStudent);
        }

        public void GetAllStudents()
        {
            foreach(var student in this.Context.Students)
            {
                Console.WriteLine($" ism: {student.FirstName}, familiya {student.LastName}, code: {student.Code}, email: {student.Email}");
            }
        }

        public void AddAttendence(DateTime enterDate, DateTime exitDate, int participationMinutes, int waitingMinutes)
        {
            var newAttend = new Attendance
            {
                EnterDate = enterDate,
                ExitDate = exitDate,
                ParticipationMinutes = participationMinutes,
                WaitingMinutes = waitingMinutes
            };
            this.Context.Attendances.Add(newAttend);
        }

        public void GetAllAttends()
        {
            foreach( var attend in this.Context.Attendances)
            {
                Console.WriteLine($" EnterDate={attend.EnterDate}, ExitDate={attend.ExitDate}, ParticipationMinutes: {attend.ParticipationMinutes},  waitingMinutes: {attend.WaitingMinutes}  ");
            }
        }       
    }
}
