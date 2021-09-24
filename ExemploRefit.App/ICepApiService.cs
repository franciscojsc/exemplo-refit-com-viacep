using System.Threading.Tasks;
using Refit;

namespace ExemploRefit.App
{
    public interface ICepApiService
    {
        [Get("/ws/{cep}/json")]
        Task<CepResponse> GetAddressAsync(string cep);
    }
}
