using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.dominio
{
	public class Endereco
	{
		public Endereco(string logradouro, string n, string cep, string bairro, string cidade)
		{
			logradouro = logradouro.NewMethodValidador();
			n = n.NewMethodValidador();
			cep = cep.NewMethodValidador();
			bairro = bairro.NewMethodValidador();
			cidade = cidade.NewMethodValidador();
		}
		public string Logradouro { get; private set; }
		public string N { get; private set; }
		public string CEP { get; private set; }
		public string Bairro { get; private set; }
		public string Cidade { get; private set; }
	}


}
