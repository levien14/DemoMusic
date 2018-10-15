using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloUWP.Emity
{
    public class Song
    {
        private string _id;
        private string _name;
        private string _thumbnail;

        public string name { get => _name; set => _name = value; }
        public string thumbnail { get => _thumbnail; set => _thumbnail = value; }
        public string id { get => _id; set => _id = value; }
    }
}
