using publishers_models;
using System.Collections.Generic;

namespace publishers_dal
{
    public interface ITitlesRepository
    {
        public IEnumerable<Title> OphalenTitlesPublisher(string publisher = "", string title = "");
    }
}