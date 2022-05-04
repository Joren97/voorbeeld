using publishers_models;
using System.Collections.Generic;

namespace publishers_dal
{
    public interface IPublishersRepository
    {
        public IEnumerable<Publisher> OphalenPublishers(string publisher = "");
    }
}