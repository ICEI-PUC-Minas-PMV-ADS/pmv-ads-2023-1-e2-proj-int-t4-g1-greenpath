using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace GreenPath.Models
{
    public class AppUser : IdentityUser
	{
		[ForeignKey("Address")]
		public int? AdressId { get; set; }
		public Address? Address { get; set; }
		public string? ProfileImageUrl { get; set; }
	}
}

//criei uma chave extrangeira no endereço, pois, penso que é um critério importante para vincular vagas com pessoas, pessoas com pessoas
//Se preferirem retirar isso, tem que excluir todas as tabelas no Db, apagar a chave aqui e iniciar a migration novamente.
