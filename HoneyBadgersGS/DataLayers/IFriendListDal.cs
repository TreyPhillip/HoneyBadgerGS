using System.Collections.Generic;
using HoneyBadgers._0.Models;

namespace HoneyBadgers._0.DataLayers
{
    public interface IFriendListDal
    {
        IEnumerable<FriendList> GetAll();
        bool Add(FriendList friend);
        bool Update(FriendList friend);
        FriendList GetData(string id);
        int Delete(string id);
    }
}
