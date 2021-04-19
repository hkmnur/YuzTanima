﻿using YuzTanima.Core.DataAccess.EntityFramework;
using YuzTanima.DataAccess.Abstract;
using YuzTanima.Entities.Concrete;

namespace YuzTanima.DataAccess.Concrete.EntityFramework
{
    public class EfCalisanYollariDal : EfEntityRepositoryBase<CalisanYollari, DatabaseContext>, ICalisanYollariDal
    {
    }
}
