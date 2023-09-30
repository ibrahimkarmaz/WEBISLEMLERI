using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class Job
    {
        public int JobID { get; set; }
        public string JobName { get; set; }

        //İlişkiler
        //Bir iş birden fazla müşteride olabilir
        public List<Customer> Customers { get; set; }

    }
}
