using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;



namespace Database.Entities
{
    [Table("person")]
    public class Person
    {
        [Column("person_id")]
        [Key]
        public long PersonId {get; set;}
        [Column("first_name")]
        public string FirstName {get; set;}
        [Column("middle_name")]
        public string MiddleName {get; set;}
        [Column("last_name")]
        public string LastName {get; set;}

        
        [Column("student_id")]
        public long StudentId { get; set; }
        public Student Student { get; set; }
    }

}