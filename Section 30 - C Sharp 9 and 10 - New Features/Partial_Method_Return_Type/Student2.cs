using System;

namespace Partial_Method_Return_Type
{
    partial class Student
    {
        public int StudentID
        {
            get => _studentId;
            set => _studentId = value;
        }

        //Partial Method Implementation
        internal partial int GetStudentID()
        {
            return 10;
        }
    }
}
