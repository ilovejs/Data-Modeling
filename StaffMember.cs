using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBookCatalog
{
    public class StaffMember
    {
        public virtual int Id { get; set; }
        //describe person and the role they fulfill
        public virtual Person Person { get; set; }
        public virtual Role Role { get; set; }

        public Person Person1
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Role Role1
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
