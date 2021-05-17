using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace db_app3.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public List<Post> Posts { get; set; }
    } 
}