﻿using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constants;
using Core.Utulities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        private IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        [SecuredOperation("admin")]
        public IResult Add(Brand brand)
        {
            if (brand.BrandName.Length < 2)
            {
                return new ErrorResult();
            }
            _brandDal.Add(brand);
            return new SuccessResult();
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult();
        }

        public IDataResult<Brand> Get(int id)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(p => p.Id == id));
        }

        [SecuredOperation("admin")]
        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }

        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult();
        }
    }
}
