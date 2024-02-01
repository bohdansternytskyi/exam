﻿using System.ComponentModel.DataAnnotations;

namespace Test.DAL
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
    }
}
