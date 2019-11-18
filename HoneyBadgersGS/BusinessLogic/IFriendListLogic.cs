using System.Collections.Generic;
using HoneyBadgers._0.Models;

namespace HoneyBadgers._0.BusinessLogic
{
    public interface IFriendListLogic
    {
        IEnumerable<FriendList> GetAll();
        bool Add(FriendList friendList);
        bool Update(FriendList friendList);
        FriendList Details(string id);
        int Delete(string id);
    }
}