using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBookCatalog
{
    public class ComicBook_v1
    {
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public virtual int Volume { get; set; }
        public virtual int Issue { get; set; }
        public virtual int Year { get; set; }
        public virtual string Company { get; set; }
        public virtual string Writer { get; set; }
        public virtual string Pencils { get; set; }
        public virtual string Ink { get; set; }
        public virtual string Letterer { get; set; }
        public virtual string Colorist { get; set; }
        public virtual string Editor { get; set; }
        public virtual string EditorInChief { get; set; }
        //Star War I
        //Star War II
        //Hence, the name of story will show up twice
        public virtual string Story { get; set; }
        public virtual int Part { get; set; }
    }
}
