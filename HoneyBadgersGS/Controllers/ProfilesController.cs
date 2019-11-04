﻿using System.Collections.Generic;
using HoneyBadgers._0.BusinessLogic;
using HoneyBadgers._0.Models;
using Microsoft.AspNetCore.Mvc;

namespace HoneyBadgers._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfilesController : ControllerBase
    {
        private IProfileLogic _profileLogic;

        public ProfilesController(IProfileLogic profileLogic)
        {
            _profileLogic = profileLogic;
        }

        // GET: api/Profiles
        [HttpGet]
        [Route("api/Profile")]
        public IEnumerable<Profile> GetAllProfiles()
        {
            return _profileLogic.GetAll();
        }

        //Add Single Profile to records
        [HttpPost]
        [Route("api/Profile/Add")]
        public bool Add(string id)
        {
            return _profileLogic.Add(id);
        }

        //Update Profiles in records
        [HttpPut]
        [Route("api/Profile/Update")]
        public int Update(Profile profile)
        {
            return _profileLogic.Update(profile);
        }

        //Get single profile details
        [HttpGet("getprofiles/{id}")]
        [Route("api/Profile/Details/{id}")]
        public Profile Details(string id)
        {
            return _profileLogic.Details(id);
        }

        //Delete game from records
        [HttpDelete]
        [Route("api/Profile/Delete")]
        public int Delete(string id)
        {
            return _profileLogic.Delete(id);
        }
    }
}
