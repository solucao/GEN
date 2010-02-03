using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLInfo.GEN.Domain.Entities
{
    public class Regra:EntidadeBase
    {
        public virtual string Nome { get; set; }
        public virtual string Descricao { get; set; }
        public virtual IList<Grupo> Grupos { get; set; }
    }
}
