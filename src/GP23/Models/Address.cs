using System;
using System.ComponentModel.DataAnnotations;

namespace GP23.Models
{
	public class Address
	{
        [Key]
        public int Id { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public int ZipCode { get; set; }
    }
}

