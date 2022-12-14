using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppEF_CodeFirst.Models;
namespace WebAppEF_CodeFirst.IRepository
{
    public interface IBatchRepository
    {
        void AddBatch(Batch batch);
        void EditBatch(int id, Batch batch);
        void DeleteBatch(int id);
        Batch Search(int id);
        List<Batch> GetBatches();

    }
}
