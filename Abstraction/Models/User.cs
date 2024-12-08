﻿using System.ComponentModel.DataAnnotations;

namespace backend.Abstraction.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Contact {  get; set; } = string.Empty;
        public string Address {  get; set; } = string.Empty;
        public List<Product>? Products { get; set; } = default!;
    }
}
