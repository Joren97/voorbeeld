using publishers_models;
using System.Collections.Generic;

namespace publishers_dal
{
    public interface ISalesRepository
    {
        public IEnumerable<Sale> OphalenSalesVoorTitle(string titleId);

        public IEnumerable<Sale> OphalenSalesVoorPublisher(string publisherId);
    }
}