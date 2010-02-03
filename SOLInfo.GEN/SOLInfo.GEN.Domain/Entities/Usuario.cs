using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLInfo.GEN.Domain.Entities
{
    public class Usuario : EntidadeBase
    {
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual IList<Grupo> Grupos { get; set; }
        public virtual Boolean Status { get; set; }
    }
}
