using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class JobManager : IJobService
    {
        IJobDAL _JobDAL;

        public JobManager(IJobDAL jobDAL)
        {
            _JobDAL = jobDAL;
        }

        public Job GetById(int id)
        {
            return _JobDAL.GetById(id);
        }

        public void TAdd(Job t)
        {
            _JobDAL.Insert(t);
        }

        public void TDelete(Job t)
        {
            _JobDAL.Delete(t);
        }

        public List<Job> TGetList()
        {
            return _JobDAL.getList();
        }

        public void TUpdate(Job t)
        {
            _JobDAL.Update(t);
        }
    }
}
