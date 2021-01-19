using CpuSeller.DataAccessLayer.Abstract;
using CpuSeller.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CpuSeller.DataAccessLayer.Concrete.EntityFramework
{
    public class EfCpuDal:
        EfRepositoryBase<Cpu,CpuSellerContext>,
        ICpuDal
    {
    }
}
