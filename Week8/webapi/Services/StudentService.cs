using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Database.Entities;
using StudentBusinessRules;
public class StudentService : IStudentService
{
    private readonly IStudentRepository _studentRepository;
    private readonly ILogger _logger;

    public StudentService(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public List<StudentDto> GetAllStudents()
    {
        var studentDtos = new List<StudentDto>();

        foreach(var student in _studentRepository.GetAllStudents())
        {
            studentDtos.Add(new StudentDto {
                studentId = student.StudentId,
                emailAddress = student.email_address
                
            });
        }

        return studentDtos;
    }
}