using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAtividadeEntrevista.Models
{
    /// <summary>
    /// Classe de Modelo de beneficiario
    /// </summary>
    public class BeneficiarioModel
    {
        /// <summary>
        /// id do beneficiario
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// CPF
        /// </summary>
        [Required]
        public string CPF { get; set; }

        /// <summary>
        /// Nome
        /// </summary>
        [Required]
        public string Nome { get; set; }


        /// <summary>
        /// id do cliente
        /// </summary>
        public long IdCliente { get; set; }


    }
}