using System;
using System.Collections.Generic;

namespace RPDP.RepositoryLibrary.Entity
{
    public class TypeRegistrar:Entity<TypeRegistrar>
    {
        public virtual String Type { get; set; }
        public virtual IList<Registrar> Registrars { get; set; }

        public TypeRegistrar()
        {
            Registrars = new List<Registrar>();
        }

        public virtual void AddTypeRegistrar(Registrar typeReg)
        {
            typeReg.IdTypeRegistrar = this;
            Registrars.Add(typeReg);
        }
    }
}
