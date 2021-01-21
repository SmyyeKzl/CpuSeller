using CpuSeller.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CpuSeller.DataAccessLayer.Abstract
{
    public interface ICpuDal:IEntityRepository<Cpu>
    {
    }
}
