using System;
using System.Collections.Generic;
using System.Text;
using YuzTanima.Business.Abstract;
using YuzTanima.Business.Constants;
using YuzTanima.Core.Utilities.Results;
using YuzTanima.DataAccess.Abstract;
using YuzTanima.Entities.Concrete;

namespace YuzTanima.Business.Concrete
{
    public class BirimlerManager : IBirimlerService
    {
        private IBirimlerDal _birimlerDal;

        public BirimlerManager(IBirimlerDal birimlerDal)
        {
            _birimlerDal = birimlerDal;
        }

        public IResult Add(Birimler birimler)
        {
            _birimlerDal.Add(birimler);
            return new SuccessResult(Messages.BirimlerAdded);
        }

        public IResult Delete(Birimler birimler)
        {
            _birimlerDal.Delete(birimler);
            return new SuccessResult(Messages.BirimlerDeleted);
        }

        public IDataResult<List<Birimler>> GetAll()
        {
            return new SuccessDataResult<List<Birimler>>(_birimlerDal.GetAll());
        }

        public IDataResult<Birimler> GetById(int birimId)
        {
            return new SuccessDataResult<Birimler>(_birimlerDal.Get(x => x.birimId == birimId));
        }

    }
}
