using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Entities
{
    public class Category : EntityBase
    {
   
        [DisplayName("Kategori Adı")]
        [RequiredAttribute (error)]
        [maxlengt]
       
        public string Name { get; set; }
    }
}
