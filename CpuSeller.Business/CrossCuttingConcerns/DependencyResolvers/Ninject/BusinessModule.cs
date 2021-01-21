using CpuSeller.Business.Abstract;
using CpuSeller.Business.Concrete;
using CpuSeller.DataAccessLayer.Abstract;
using CpuSeller.DataAccessLayer.Concrete.ADONET;
using CpuSeller.DataAccessLayer.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace CpuSeller.Business.CrossCuttingConcerns.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICpuService>().To<CpuManager>().InSingletonScope();
            Bind<ICpuDal>().To<AdoCpuDal>().InSingletonScope();

            
        }
    }
}
