using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Entities
{
    public class Writer : EntityBase
    {
        [DisplayName("Adı Soyadı")]
        [required]
        [maxlengt]
        public string NameSurname { get; set; }
    }
}


