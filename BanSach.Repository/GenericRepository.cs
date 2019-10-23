using BanSach.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanSach.Repository
{
    public class GenericRepository<T> where T:class
    {
        QuanLyBanSachEntities1 db = new QuanLyBanSachEntities1();
    }
}
