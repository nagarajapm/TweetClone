using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Model
{
    public partial class TWEET
    {
        public int Tweet_ID { get; set; }
        public string User_ID { get; set; }
        public string Message { get; set; }
        public System.DateTime Created { get; set; }


    }
}
