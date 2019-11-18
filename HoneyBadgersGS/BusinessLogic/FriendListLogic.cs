using System.Collections.Generic;
using HoneyBadgers._0.DataLayers;
using HoneyBadgers._0.Models;

namespace HoneyBadgers._0.BusinessLogic
{
    public class FriendListLogic : IFriendListLogic
    {
        private IFriendListDal _friendListDal;

        public FriendListLogic(IFriendListDal friendListDal)
        {
            _friendListDal = friendListDal;
        }

        public IEnumerable<FriendList> GetAll()
        {
            return _friendListDal.GetAll();
        }

        public bool Add(FriendList friendList)
        {
            return _friendListDal.Add(friendList);
        }

        public bool Update(FriendList friendList)
        {
            return _friendListDal.Update(friendList);
        }

        public FriendList Details(string id)
        {
            return _friendListDal.GetData(id);
        }

        public int Delete(string id)
        {
            return _friendListDal.Delete(id);
        }
    }
}