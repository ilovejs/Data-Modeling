using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBookCatalog
{
    public class Title
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        //navigation property, cut out the searching process
        public virtual Company Company { get; set; }
        public virtual int CompanyId { get; set; }

        public Company Company1
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
