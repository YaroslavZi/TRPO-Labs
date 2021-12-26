using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_LB2.Entities
{
    class Bolnici : IEntity
    {
        public int Id { get; set; }
        public string Otdelenie { get; set; }
        public int Palati { get; set; }
        public string Pacienti { get; set; }
    }

}
