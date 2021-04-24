using YuzTanima.Business.Abstract;
using YuzTanima.Core.Utilities.Results;
using YuzTanima.Entities.Concrete;
using YuzTanima.DataAccess.Abstract;
using YuzTanima.Business.Constants;
using System.Collections.Generic;

namespace YuzTanima.Business.Concrete
{
    public class RaporlarManager : IRaporlarService
    {
        private IRaporlarDal _raporlarDal;

        public RaporlarManager(IRaporlarDal raporlarDal)
        {
            _raporlarDal = raporlarDal;
        }
        public IResult Add(Raporlar raporlar)
        {
            _raporlarDal.Add(raporlar);
            return new SuccessResult(Messages.RaporlarAdded);
        }

        public IResult Delete(Raporlar raporlar)
        {
            return new SuccessResult(Messages.RaporlarDeleted);
        }

        public IDataResult<List<Raporlar>> GetAll()
        {
            return new SuccessDataResult<List<Raporlar>>(_raporlarDal.GetAll());
        }
        public IDataResult<Raporlar> GetById(int raporId)
        {
            return new SuccessDataResult<Raporlar>(_raporlarDal.Get(x => x.raporId == raporId));
        }
    }
}