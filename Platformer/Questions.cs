using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platformer
{
    public class Questions
    {
        public static DataTable listQuestion(int ID_SJ)
        {
            return Database.SelectQuery("select * from Questions where ID_SJ =" + ID_SJ);
        }
    }
}
