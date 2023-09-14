using HotelProject.DataAccess.Abstract;
using HotelProject.DataAccess.Concrete;
using HotelProject.DataAccess.Repositories;
using HotelProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccess.EntityFramework
{
    public class EfAboutDal : GenericRepository<About>, IAboutDal
    {
        public EfAboutDal(Context context) : base(context)
        {
        }
    }
}
