﻿using System.ComponentModel.DataAnnotations;

namespace UserService.Models
{
    public class ApplicationUser
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public required string Nome { get; set; }
        [Required]
        public required string Email { get; set; }
        [Required]
        public required string Senha { get; set; }
    }
}
