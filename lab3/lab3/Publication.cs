using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Publication
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Doi { get; set; }
        public string Udc { get; set; }
        public int CountPages { get; set; }
        public DateTime CreationDate { get; set; }
        public Publisher Publisher { get; set; }
        public int Citation { get; set; }
        public List<Author> Authors { get; set; }
    }
}
