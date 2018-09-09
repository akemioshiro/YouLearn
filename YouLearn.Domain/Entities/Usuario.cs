using System;
using YouLearn.Domain.ValueObjects;

namespace YouLearn.Domain.Entities
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public Nome Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
