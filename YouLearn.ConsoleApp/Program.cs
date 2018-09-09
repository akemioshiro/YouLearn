using System;
using YouLearn.Domain.Arguments.Usuario;
using YouLearn.Domain.Services;

namespace YouLearn.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AdicionarUsuarioRequest adicionarUsuarioRequest = new AdicionarUsuarioRequest() {
                Email="akemioshiro@hotmail.com",
                PrimeiroNome="QAZwrrf jygjh",
                UltimoNome = "Oshiro",
                Senha = "12212116"
            };
            //var response = new ServiceUsuario().AdicionarUsuario(adicionarUsuarioRequest);

            Console.ReadKey();
        }
    }
}
