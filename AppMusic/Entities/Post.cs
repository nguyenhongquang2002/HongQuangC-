using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMusic.Entities
{
    public class Post
    {
        public int id { get; set; }
        public string titel { get; set; }
        public string body { get; set; }
        public string userId { get; set; }

        public override string ToString()
        {
            return $"{titel}";
        }
    }
}
