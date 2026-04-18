using System;

namespace WindowsFormsApp2
{
    public class StudentInfo
    {
        
        private string studentID;
        private string firstName;
        private string lastName;

        
        public string StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        
        public StudentInfo()
        {
            this.studentID = "";
            this.firstName = "";
            this.lastName = "";
        }

        
        public StudentInfo(string studentID, string firstName, string lastName)
        {
            this.StudentID = studentID;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        
        public StudentInfo(string studentID) : this(studentID, "Unknown", "Unknown")
        {
        }
    }
}
