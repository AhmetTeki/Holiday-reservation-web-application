using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFReservationDal : GenericRepository<Reservation>, IReservationDal
    {
        public List<Reservation> GetListWithReservationByAccepted(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetListWithReservationByPrevious(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetListWithReservationByWaitAproval(int id)
        {
            throw new NotImplementedException();
        }
    }
}
