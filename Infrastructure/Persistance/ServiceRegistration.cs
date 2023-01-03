using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Persistance.Concretes;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services /*IoC Container'a ekleme islemini yapiyoruz*/ ) //bu bir extension method'dur.
        {
            services.AddSingleton<IProductService, ProductService>();
            //IProductService turunden bir istek geldiginde ProductService'i gonder.

            //Bu extension method IoC Container'i barindiran Presentation'daki ASP.NET Core uygulamasi tarafindan cagirilmasi gerekiyor. Program.cs'de cagiriyoruz.
        }
    }
}
