using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankApp.Api.Models
{
    public class Conta
    {
        [Key]
        public Guid IdConta { get; set; }

        [Column(TypeName = "MONEY")]
        public decimal Saldo { get; set; }

        public TipoConta TipoConta { get; set; }

        public bool EstaAtivo { get; set; }

        [ForeignKey("Cliente")]
        public Guid IdCliente { get; set; }

        public Cliente Cliente { get; set; }
    }

    public enum TipoConta
    {
        Corrente,
        Poupanca,
        Investimento
    }
}
