
using System.Collections;
using GameStoreModel.Models;

namespace GameStore.DAL.Interfaces
{
    public interface ICommentRepository : IRepository<Comment>
    {
        IEnumerable GetCommentsByGameKey(string key);
    }
}
