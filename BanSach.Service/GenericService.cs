using BanSach.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanSach.Service
{
    public class GenericService<T> where T : class
    {
        protected readonly IType_Repository type_Repository;
        public GenericService()
        {
            type_Repository = new Type_Repository();
        }
    }
}
