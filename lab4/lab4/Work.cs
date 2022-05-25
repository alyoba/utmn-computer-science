using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Work
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public int CountPages { get; set; }
        public string UdcId { get; set; }
        public DateTime CreationDate { get; set; }
        public string PublisherId { get; set; }
        public string Doi { get; set; }
        public List<string> AuthorsIds { get; set; }
    }
}
