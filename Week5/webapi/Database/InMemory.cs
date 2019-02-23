using System.Collections.Generic;

namespace Database
{
    public static class InMemory
    {
        public static List<Student> students = new List<Student> {
            new Student {
                Id = 1,
                email = "random@oit.edu"
            },
            new Student {
                Id = 2,
                email = "random2@oit.edu"
            },
        };

        public static List<Person> persons = new List<Person> {
            new Person {
                Id = 1,
                firstName = "Tung",
                middleInitial = 'H',
                lastName = "Duong"
            },
            new Person {
                Id = 2,
                firstName = "Keanu",
                middleInitial = ' ',
                lastName = "Reeves"
            }
        };
    }
}