using System.Collections.Generic;
using System.Linq;
using HoneyBadgers._0.Models;

namespace HoneyBadgers._0.DataLayers
{
    public class FriendListDal : IFriendListDal
    {
        private HoneyBadgerDBContext _db;

        public FriendListDal(HoneyBadgerDBContext db)
        {
            _db = db;
        }

        public IEnumerable<FriendList> GetAll()
        {
            return _db.FriendList.ToList();
        }

        public bool Add(FriendList friendList)
        {
            _db.FriendList.Add(friendList);
            _db.SaveChangesAsync();
            return true;
        }

        public bool Update(FriendList friendList)
        {
            _db.FriendList.Update(friendList);
            _db.SaveChangesAsync();
            return true;
        }

        public FriendList GetData(string id)
        {
            FriendList friendList = _db.FriendList.Find(id);

			//if the object is null, just return an empty object
			if(friendList == null)
			{
				friendList = new FriendList();
			}
            return friendList;
        }

        public int Delete(string id)
        {
            FriendList friendList = _db.FriendList.Find(id);
            _db.FriendList.Remove(friendList);
            _db.SaveChangesAsync();
            return 1;
        }
    }
}