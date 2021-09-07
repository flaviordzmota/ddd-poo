using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.dominio
{
	public class ContaBancaria
	{
		public ContaBancaria(Cliente cliente)
		{
			Random random = new Random();
			NumeroConta = random.Next(50000, 120000);
			DigitoConta = random.Next(1, 9);


			Situacao = SituacaoConta.Criada;

			Cliente = cliente ?? throw new Exception("O nome do cliente não pode ser em branco ou vazio.");
		}
		public int NumeroConta { get; init; }
		public int DigitoConta { get; init; }
		public decimal SaldoEmConta { get; protected set; }
		public DateTime? DataAberturaConta { get; private set; }
		public DateTime? DataEncerramentoConta { get; private set; }
		public SituacaoConta Situacao { get; private set; }
		public string Senha { get; private set; }
		public Cliente Cliente { get; init; }

	}
}
