using System;

namespace YouLearn.Domain.Arguments.Usuario
{
    public class AdicionarUsuarioResponse
    {
        public AdicionarUsuarioResponse(Guid id)
        {
            Id = new Guid();
        }
        public Guid Id { get; set; }
    }
}
