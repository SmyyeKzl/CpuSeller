using CpuSeller.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CpuSeller.Business.Abstract
{
    public interface ICpuService
    {
        List<Cpu> GetAll(Expression<Func<Cpu, bool>> filter = null);
        Cpu Get(Expression<Func<Cpu, bool>> filter);
        void Add(Cpu entity);
        void Update(Cpu entity);
        void Delete(Cpu entity);
    }
}
