﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class FeatureManager : IFeatureDal
    {
        IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void Delete(Feature t)
        {
            throw new NotImplementedException();
        }

        public Feature GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Feature> GetList()
        {
            return _featureDal.GetList();
        }

        public List<Feature> GetListByFilter(Expression<Func<Feature, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Feature t)
        {
            throw new NotImplementedException();
        }

        public void Update(Feature t)
        {
            throw new NotImplementedException();
        }
    }
}
