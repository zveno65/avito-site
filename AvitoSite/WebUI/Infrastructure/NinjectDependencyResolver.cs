using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;
using System.Web.Mvc;
using Moq;
using Domain;
using Domain.Entities;
using Domain.Abstract;
using Domain.Concrete;

namespace WebUI.Infrastructure
{
    public class NinjectDependencyResolver: IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver (IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        private void AddBindings()
        {
            //Mock<IAvitoRepository> mock = new Mock<IAvitoRepository>();
            //mock.Setup(m => m.Accounts).Returns(new List<Account>
            //{
            //    new Account { login = "Privet", password  = "No", e_mail = "Ziryanov2@mail.ru"},
            //    new Account { login = "Poka", password  = "Yes", e_mail = "Ziryanov3@mail.ru"}
            //});
            kernel.Bind<IAvitoRepository>().To<EFAviotRepository>();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
    }
}