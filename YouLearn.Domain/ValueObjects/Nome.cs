using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;
using YouLearn.Domain.Resources;

namespace YouLearn.Domain.ValueObjects
{
    public class Nome:Notifiable
    {
        public Nome(string primeiroNome, string ultimoNome)
        {
            PrimeiroNome = primeiroNome;
            UltimoNome = ultimoNome;

            new AddNotifications<Nome>(this)
                .IfNullOrInvalidLength(x => x.PrimeiroNome, 1, 50, 
                MSG.X0_E_OBRIGATORIO_E_DEVE_CONTER_X1_CARACTERES.ToFormat("Primeiro nome", 1, 50));

            new AddNotifications<Nome>(this)
               .IfNullOrInvalidLength(x => x.UltimoNome, 1, 50, 
               MSG.X0_E_OBRIGATORIO_E_DEVE_CONTER_X1_CARACTERES.ToFormat("Último nome", 1, 50));

        }

        public string PrimeiroNome { get; private set; }
        public string UltimoNome { get; private set; }
    }
}
