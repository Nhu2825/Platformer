using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platformer
{
    public class Subject
    {
        public static DataTable listSubject()
        {
            return Database.SelectQuery("select * from Subject");
        }
    }
}
