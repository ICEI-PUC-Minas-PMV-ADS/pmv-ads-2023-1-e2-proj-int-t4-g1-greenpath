using System;
namespace GP23.Data
{
	public static class UserRoles
	{
        //regra para 2 níveis de acesso, pode incluir outros
        //separa duas categorias de usuários Admin e User, podemos separar tb o User em PF e PJ, ou criar userPF e userPJ

        public const string Admin = "admin";
		public const string User = "user";
	}
}

