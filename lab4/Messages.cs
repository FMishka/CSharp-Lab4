using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supabase;
using Postgrest.Attributes;

namespace lab4
{
    internal class Messages : SupabaseModel
    {
        [PrimaryKey("id", false)]
        public int id { get; set; }
        [Column("UserName")]
        public string UserName { get; set; }
        [Column("Message")]
        public string Message { get; set; }
    }
}
