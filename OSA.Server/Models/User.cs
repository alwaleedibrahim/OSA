using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OSA.Server.Models
{
    public class User
    {
        [Key]
        public int user_id { get; set; }

        public string username { get; set; }

        public string password { get; set; }

        public string role { get; set; }

        public string full_name { get; set; }

        public string email { get; set; }

        public string gender { get; set; }

        public string phone_number { get; set; }

        public string nationality { get; set; }

        public char password_changed { get; set; }
    }

    public class Administrator
    {
        [Key]
        public int admin_id { get; set; }

        [ForeignKey("User")]
        public int user_id { get; set; }

        public virtual User User { get; set; }
    }

    public class Instructor
    {
        [Key]
        public int instructor_id { get; set; }

        [ForeignKey("User")]
        public int user_id { get; set; }

        public virtual User User { get; set; }
    }

    public class Student
    {
        [Key]
        public int student_id { get; set; }

        [ForeignKey("User")]
        public int user_id { get; set; }

        public virtual User User { get; set; }
    }

}