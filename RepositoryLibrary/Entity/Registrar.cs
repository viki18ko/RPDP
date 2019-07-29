using System;
using System.Collections.Generic;

namespace RPDP.RepositoryLibrary.Entity
{
    public class Registrar:Entity<Registrar>
    {
        public virtual String NumberRegistrar { get; set; }
        public virtual TypeRegistrar IdTypeRegistrar { get; set; }
        public virtual DateTime ManufactureDate { get; set; }
        public virtual Char Busy { get; set; }
        public virtual IList<Car> Cars { get; set; }

        public Registrar()
        {
            Cars = new List<Car>();
        }

        public virtual void AddNumberRegistrar(Car car)
        {
            car.IdRegistrar = this;
            Cars.Add(car);
        }
    }
}
