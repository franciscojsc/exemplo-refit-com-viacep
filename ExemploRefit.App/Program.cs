using System;
using System.Threading.Tasks;
using Refit;

namespace ExemploRefit.App
{
    internal static class Program
    {
        private static async Task Main(string[] args)
        {
            try
            {
                ICepApiService cepClient = RestService.For<ICepApiService>("http://viacep.com.br");
                Console.WriteLine("Informe seu cep:");

                string cepInformado = Console.ReadLine();
                Console.WriteLine("Consultando informações do CEP: " + cepInformado);

                CepResponse address = await cepClient.GetAddressAsync(cepInformado);

                Console.Write($"\nLogradouro:{address.Logradouro},\nBairro:{address.Bairro},\nCidade:{address.Localidade}");
                _ = Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro na consulta de cep: " + e.Message);
            }
        }
    }
}
