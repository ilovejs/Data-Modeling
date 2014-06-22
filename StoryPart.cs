using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBookCatalog
{
    /*
     * Comic book -> StoryPart -> Story -> Title means
     * We don't need Title property on Comic Book entity
     */
    public class StoryPart
    {
        public virtual int Id { get; set; }
        public virtual Story Story { get; set; }
        public virtual int Part { get; set; }
        public virtual string Subtitle { get; set; }

        public Story Story1
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
