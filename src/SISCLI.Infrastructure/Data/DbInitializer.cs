using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISCLI.ApplicationCore.Entity;

namespace SISCLI.Infrastructure.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ClienteContext context)
        {
            if (context.Clientes.Any())
            {
                return;
            }

            var clientes = new Cliente[]
            {
                new Cliente()
                {
                    Nome = "Fulano da Silva",
                    CPF = "22222222222",
                },

                new Cliente()
                {
                    Nome = "Beltrano da Silva",
                    CPF = "22222222222",
                },

                new Cliente()
                {
                    Nome = "Ciclano da Silva",
                    CPF = "22222222222",
                }
            };

            context.AddRange(clientes);

            var contatos = new Contato[]
            {
                new Contato()
                {
                    Nome = "Contato 1",
                    Telefone = "40028922",
                    Email = "email.contato@teste.com",
                    Cliente = clientes[0]
                },

                new Contato()
                {
                    Nome = "Contato 2",
                    Telefone = "32244000",
                    Email = "email.contato@teste.com",
                    Cliente = clientes[1]
                },

                new Contato()
                {
                    Nome = "Contato 3",
                    Telefone = "32244000",
                    Email = "email.contato@teste.com",
                    Cliente = clientes[2]
                }
            };

            context.AddRange(contatos);

            context.SaveChanges();
        }
    }
}
