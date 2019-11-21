using System.Collections.Generic;
using HoneyBadgers._0.DataLayers;
using HoneyBadgers._0.Models;

namespace HoneyBadgers._0.BusinessLogic
{
    public class FriendshipLogic : IFriendshipLogic
    {
        private IFriendshipDal _friendshipDal;

        public FriendshipLogic(IFriendshipDal friendshipDal)
        {
            _friendshipDal = friendshipDal;
        }

        public IEnumerable<Friendship> GetAll()
        {
            return _friendshipDal.GetAll();
        }

        public bool Add(Friendship friendship)
        {
            return _friendshipDal.Add(friendship);
        }

        public bool Update(Friendship friendship)
        {
            return _friendshipDal.Update(friendship);
        }

        public Friendship Details(string id)
        {
            return _friendshipDal.GetData(id);
        }

        public int Delete(string id)
        {
            return _friendshipDal.Delete(id);
        }
    }
}