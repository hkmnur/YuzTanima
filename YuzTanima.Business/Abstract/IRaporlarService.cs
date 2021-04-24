using System.Collections.Generic;
using YuzTanima.Core.Utilities.Results;
using YuzTanima.Entities.Concrete;

namespace YuzTanima.Business.Abstract
{
    public interface IRaporlarService
    {
         IResult Add(Raporlar raporlar);
         IResult Delete(Raporlar raporlar);
         IDataResult <List<Raporlar>> GetAll();
    }
}