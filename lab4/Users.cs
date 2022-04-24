using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supabase;
using Postgrest.Attributes;

namespace lab4
{
    internal class Users : SupabaseModel
    {
        [PrimaryKey("id", false)]
        public int id { get; set; }
        [Column("login")]
        public string login { get; set; }
        [Column("password")]
        public string password { get; set; }
    }
}
