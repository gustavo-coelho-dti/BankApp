using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankApp.Api.Models
{
    [Table(name: "Clientes")]
    public class Cliente
    {
        [Key]
        public Guid IdCliente { get; set; }  // CHAVE PRIMÁRIA

        public string NumeroCliente { get; set; }

        public string CPF { get; set; }
        public string Senha { get; set; }
    }
}
