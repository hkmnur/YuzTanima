using System;
using System.Collections.Generic;
using System.Text;
using YuzTanima.Core.Utilities.Results;
using YuzTanima.Entities.Concrete;

namespace YuzTanima.Business.Abstract
{
    public interface IBirimlerService
    {
        IResult Add(Birimler birimler);

        IResult Delete(Birimler birimler);

        IDataResult<List<Birimler>> GetAll();

        IDataResult<Birimler> GetById(int contactId);
    }
}
