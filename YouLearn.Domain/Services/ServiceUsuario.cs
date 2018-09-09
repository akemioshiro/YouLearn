using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;
using YouLearn.Domain.Arguments.Usuario;
using YouLearn.Domain.Entities;
using YouLearn.Domain.Interfaces.Services;
using YouLearn.Domain.Resources;
using YouLearn.Domain.ValueObjects;

namespace YouLearn.Domain.Services
{
    public class ServiceUsuario : Notifiable, IServiceUsuario
    {
        public AdicionarUsuarioResponse AdicionarUsuario(AdicionarUsuarioRequest request)
        {
            if (request == null)
            {
                AddNotification("AdicionarUsuarioRequest", MSG.OBJETO_X0_E_OBRIGATORIO.ToFormat("AdicionarUsuarioRequest"));
                return null;
            }

            Nome nome = new Nome(request.PrimeiroNome, request.UltimoNome);
            Email email = new Email(request.Email);
            Usuario usuario = new Usuario();
            usuario.Nome = nome;
            usuario.Email = email;
            usuario.Senha = request.Senha;

            AddNotifications(nome, email, usuario);



            if (usuario.Senha.Length <= 3)
            {
                throw new Exception("Senha deve ter no minimo 3 caracteres");
            }

            if(this.IsInvalid()==true)
            {
                return null;
            }

            throw new System.NotImplementedException();
        }

        public AutenticarUsuarioResponse AutenticarUsuario(AutenticarUsuarioRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}
