using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entity;
namespace Repository.Interfacies
{
    public interface ICurrencyRepo:IGenericRepo<Currency>
    {
        Task< IEnumerable<Currency>>GetCurrencies();
    }
}