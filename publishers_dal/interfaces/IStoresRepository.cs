using publishers_models;
using System.Collections.Generic;

namespace publishers_dal
{
    public interface IStoresRepository
    {
        public Store OphalenStoreViaPK(string stor_id);

        public List<Store> OphalenStoresViaState(string state);

        public List<Store> OphalenStoresViaStorName(string naam);

        public List<Store> OphalenStoresViaStorNameEnState(string naam, string state);
    }
}