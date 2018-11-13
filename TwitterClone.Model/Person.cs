using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Model
{
    public partial class PERSON
    {
        public PERSON()
        {
            this.TWEETs = new HashSet<TWEET>();
            this.Following = new HashSet<PERSON>();
            this.Followers = new HashSet<PERSON>();
        }

        public string User_ID { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public System.DateTime Joined { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<TWEET> TWEETs { get; set; }
        public virtual ICollection<PERSON> Following { get; set; }
        public virtual ICollection<PERSON> Followers { get; set; }
    }
}
