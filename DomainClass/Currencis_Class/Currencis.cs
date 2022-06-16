using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClass.Currencis_Class
{
  public  class Currencis
    {
        public Currencis()
        {
            ID = Guid.NewGuid();
        }
       [Key]
        public Guid ID { get; set; }
        public string Name { get; set; }
    }
}
