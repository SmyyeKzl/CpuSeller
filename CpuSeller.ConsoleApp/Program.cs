using CpuSeller.Business.Abstract;
using CpuSeller.Business.CrossCuttingConcerns.DependencyResolvers.Ninject;
using System;

namespace CpuSeller.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var cpuService = InstanceFactory.Get<ICpuService>();
            var list = cpuService.GetAll();
            foreach (var c in list)
            {
                Console.WriteLine(c);
            }
            Console.ReadKey();
        }
    }
}
