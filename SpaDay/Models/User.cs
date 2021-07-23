using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Models
{
    public class User
    {
        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        private DateTime? dateCreated = null;

        public DateTime DateCreated => this.dateCreated.HasValue
                   ? this.dateCreated.Value
                   : DateTime.Now;


    }
}
