using AutoMapper;
using GeekBurger.Products.Contract.UpSert;
using GeekBurger.Products.Model;

namespace GeekBurger.Products.Repository
{
    public class MatchStoreFromRepository : IMappingAction<ProductToUpsert, Product>
    {
        private IStoreRepository _storeRepository;
        public MatchStoreFromRepository(IStoreRepository storeRepository)
        {
            _storeRepository = storeRepository;
        }

        public void Process(ProductToUpsert source, Product destination)
        {
            var store = _storeRepository.GetStoreByName(source.StoreName);

            if (store != null)
                destination.StoreId = store.StoreId;
        }

        public void Process(ProductToUpsert source, Product destination, ResolutionContext context)
        {
            throw new NotImplementedException();
        }
    }
}
