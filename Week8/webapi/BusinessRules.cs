using System;
using Database.Entities;

namespace StudentBusinessRules {
    public static class BusinessRules
    {
        public static bool isSpecialSnowFlake(Student student) => 
            student.StudentId > someArbitraryNumber;

        public static long someArbitraryNumber = 50;
    }
}