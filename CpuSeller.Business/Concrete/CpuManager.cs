using CpuSeller.Business.Abstract;
using CpuSeller.DataAccessLayer.Abstract;
using CpuSeller.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CpuSeller.Business.Concrete
{
    public class CpuManager : ICpuService
    {
        private ICpuDal _cpuDal;
        public CpuManager(ICpuDal cpuDal)
        {
            _cpuDal = cpuDal;
        }

        public void Add(Cpu entity)
        {
            _cpuDal.Add(entity);
        }

        public void Delete(Cpu entity)
        {
            _cpuDal.Delete(entity);
        }

        public Cpu Get(Expression<Func<Cpu, bool>> filter)
        {
            return _cpuDal.Get(filter);
        }

        public List<Cpu> GetAll(Expression<Func<Cpu, bool>> filter = null)
        {
            return _cpuDal.GetAll(filter);
        }

        public void Update(Cpu entity)
        {
            _cpuDal.Update(entity);
        }
    }
}
