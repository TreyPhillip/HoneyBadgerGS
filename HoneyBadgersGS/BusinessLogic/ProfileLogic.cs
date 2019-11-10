using System;
using System.Collections.Generic;
using HoneyBadgers._0.DataLayers;
using HoneyBadgers._0.Models;

namespace HoneyBadgers._0.BusinessLogic
{
    public class ProfileLogic : IProfileLogic
    {
        private IProfileDal _profileDal;

        public ProfileLogic(IProfileDal profileDal)
        {
            _profileDal = profileDal;
        }


        public IEnumerable<Profile> GetAll()
        {
            return _profileDal.GetAll();
        }

		public bool Add(Profile profile)
		{
			return _profileDal.Add(profile);
		}

		public bool Update(Profile profile)
        {
            return _profileDal.Update(profile);
        }

        public Profile Details(string id)
        {
            return _profileDal.GetData(id);
        }
        public int Delete(string id)
        {
            return _profileDal.Delete(id);
        }
    }
}
