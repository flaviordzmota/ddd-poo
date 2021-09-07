using AgenciaBancaria.dominio;
using System;

namespace AgenciaBancaria.app
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{

				Endereco endereco = new Endereco("Rua Expedito Torreão Braz", "114", "58468454", "Malvinas", "Campina Grande");
				Cliente Cliente = new Cliente("Flávio Mota", "006.005.008-81", "1265487",endereco);


				ContaBancaria conta = new ContaBancaria(Cliente);

				Console.WriteLine("Conta Criada:" + conta.NumeroConta + "-" + conta.DigitoConta);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
		
	}
}
