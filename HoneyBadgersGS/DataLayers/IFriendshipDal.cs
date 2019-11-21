using System.Collections.Generic;
using HoneyBadgers._0.Models;

namespace HoneyBadgers._0.DataLayers
{
    public interface IFriendshipDal
    {
        IEnumerable<Friendship> GetAll();
        bool Add(Friendship friend);
        bool Update(Friendship friend);
        Friendship GetData(string id);
        int Delete(string id);
    }
}
