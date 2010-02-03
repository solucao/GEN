using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLInfo.GEN.Domain.Entities
{
    public class Grupo:EntidadeBase
    {
        public virtual string Nome { get; set; }
        public virtual IList<Regra> Regras { get; set; }
        public virtual IList<Usuario> Usuarios { get; set; }
    }
}
