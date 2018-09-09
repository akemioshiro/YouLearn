using System;

namespace YouLearn.Domain.Entities
{
    public class Canal
    {
        public string Nome { get; set; }
        public string UrlLogo { get; set; }
        public Usuario Usuario { get; set; }
        public Guid Id { get; set; }

    }
}
