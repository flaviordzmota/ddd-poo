using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.dominio
{
	public static class Validacoes
	{
		public static string NewMethodValidador(this string texto)
		{
			return string.IsNullOrWhiteSpace(texto) ?
			   throw new Exception("O Campo deve estar prenchido!")
			   : texto;
		}
	}
}
