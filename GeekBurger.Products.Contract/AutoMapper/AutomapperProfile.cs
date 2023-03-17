using AutoMapper;
using GeekBurger.Products.Contract.DTO;
using GeekBurger.Products.Contract.UpSert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBurger.Products.Contract.AutoMapper
{
    public class AutomapperProfile: Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Product, ProductToGet>();
            CreateMap<Item, ItemToGet>();

            CreateMap<ProductToUpsert, Product>()
    .AfterMap<MatchStoreFromRepository>();
            CreateMap<ItemToUpsert, Item>()
                .AfterMap<MatchItemsFromRepository>();

        }
    }
}
