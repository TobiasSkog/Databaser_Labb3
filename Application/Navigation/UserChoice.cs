﻿namespace Databaser_Labb3.Application.Navigation
{
    internal enum UserChoice
    {
        GetPersonal,
        GetPersonalAll,
        GetPersonalByRole,
        GetPersonalTeachersOnly,
        GetPersonalAdminsOnly,
        GetPersonalLeadersOnly,
        GetStudent,
        GetStudentByFirstName,
        GetStudentByLastName,
        GetStudentsByClass,
        GetGrades,
        GetGradesLastMonth,
        GetGradesEnterDate,
        GetCourse,
        GetAllCourses,
        AddUser,
        AddStudent,
        AddPersonal,
        SortAscending,
        SortDescending,
        Back,
        Exit,
        Invalid
    }
}
