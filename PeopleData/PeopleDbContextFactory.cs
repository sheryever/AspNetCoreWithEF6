using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleData
{
    public class PeopleDbContextFactory : IDbContextFactory<PeopleEntities>
    {
        public PeopleEntities Create()
        {
            return new PeopleEntities("data source=.\\SQLEXPRESS2016;initial catalog=Ef6Test;persist security info=True;user id=sa;password=Test123;MultipleActiveResultSets=True;App=EntityFramework");
        }
    }
}
