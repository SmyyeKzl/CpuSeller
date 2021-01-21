using CpuSeller.Business.Abstract;
using CpuSeller.Business.CrossCuttingConcerns.DependencyResolvers.Ninject;
using CpuSeller.Entities.Concrete;
using System;

namespace CpuSeller.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var cpuService = InstanceFactory.Get<ICpuService>();
            //var list = cpuService.GetAll();
            //foreach (var c in list)
            //{
            //    Console.WriteLine(c);
            //}
            
            Console.WriteLine(cpuService.Get(p=>p.CpuId==3));
            cpuService.Add(new Cpu() { Family = "aaaa", Model = "a", Price = 1000 });
            cpuService.GetAll().ForEach(s => Console.WriteLine(s));
            Console.ReadKey();
        }
    }
}
