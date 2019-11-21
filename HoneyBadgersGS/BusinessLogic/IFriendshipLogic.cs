using System.Collections.Generic;
using HoneyBadgers._0.Models;

namespace HoneyBadgers._0.BusinessLogic
{
    public interface IFriendshipLogic
    {
        IEnumerable<Friendship> GetAll();
        bool Add(Friendship friendship);
        bool Update(Friendship friendship);
        Friendship Details(string id);
        int Delete(string id);
    }
}