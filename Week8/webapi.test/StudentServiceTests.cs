using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using FakeItEasy;
using FluentAssertions;
using Database.Entities;
using StudentBusinessRules;

public class StudentServiceTest
{
    private StudentService _studentService; // System Under Test (SUT)
    private IStudentRepository _studentRepository; // Mock

    [SetUp]
    public void Setup()
    {
        _studentRepository = A.Fake<IStudentRepository>();

        _studentService = new StudentService(_studentRepository);
    }

    [Test]
    public void HeyWhereAreTheSpecialStudents()
    {
        // Arrange
        A.CallTo(() => _studentRepository.GetAllStudents()).Returns(
            new List<Student> {
                new Student {
                    StudentId = 482738,
                    email_address = "Something@gmail.com"
                },
                new Student {
                    StudentId = 45678932,
                    email_address = "Something@gmail.com"
                }
            }
        );

        // Act
        var studentDtos = _studentService.GetAllStudents();

        // Assert (NUnit Assertions)
        Assert.That(studentDtos.Any(pdto => pdto.special), Is.EqualTo(false));

        // Assert (FluentAssertions)
        studentDtos.Any(pdto => pdto.special).Should().BeFalse();
    }

    [Test]
    public void EverybodyWhoIsNotSpecialPlease()
    {
        // Arrange
        A.CallTo(() => _studentRepository.GetAllStudents()).Returns(
            new List<Student> {
                new Student {
                    StudentId = 4,
                    email_address = "Something@gmail.com"
                },
                new Student {
                    StudentId = 5,
                    email_address = "Something@gmail.com"
                }
            }
        );

        // Act
        var studentDtos = _studentService.GetAllStudents();

        // Assert (NUnit Assertions)
        Assert.That(studentDtos.Any(pdto => pdto.special), Is.EqualTo(false));

        // Assert (FluentAssertions)
        studentDtos.Any(pdto => pdto.special).Should().BeFalse();
    }

}