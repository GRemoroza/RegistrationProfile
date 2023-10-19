using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationProfile
{
    internal class StudentInfoClass
    {
       public static int StudentNo = 0;
       public static int ContactNo = 0;

       public static string Program = "";
       public static string Gender = "";
       public static string Birthday = "";
       public static string FullName = "";

        public static long SetStudentNo { get; set; }
        public static long SetContactNo { get; set; }
        public static string SetProgram { get; set; }
        public static string SetGender { get; set; }
        public static string SetBirthDay { get; set; }
        public static string SetFullName { get; set; }
        public static int SetAge { get; set; }

    }
}
