using prmToolkit.NotificationPattern;
using YouLearn.Domain.Entities.Base;
using YouLearn.Domain.ValueObjects;

using YouLearn.Domain.Extensions;

namespace YouLearn.Domain.Entities
{
    public class Usuario : EntityBase
    {
        public Usuario(Email email, string senha)
        {
            Email = email;
            Senha = senha;

            Senha = Senha.ConvertToMD5();
            AddNotifications(email);
        }

        public Usuario(Nome nome, Email email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;

            new AddNotifications<Usuario>(this).IfNullOrEmptyOrInvalidLength(x => x.Senha, 3, 32);
            Senha = Senha.ConvertToMD5();
            AddNotifications(nome, email);

        }

        public Nome Nome { get; private set; }
        public Email Email { get; private set; }
        public string Senha { get; private set; }
    }
}
