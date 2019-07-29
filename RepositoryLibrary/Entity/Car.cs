using System;
using System.Collections.Generic;

namespace RPDP.RepositoryLibrary.Entity
{
    public class Car:Entity<Car>
    {
        public virtual String NumberCar { get; set; }
        public virtual TypeCar IdTypeCar { get; set; }
        public virtual Registrar IdRegistrar { get; set; }
        public virtual Char Busy { get; set; }
        public virtual IList<Train> Trains { get; set; }

        public Car()
        {
            Trains = new List<Train>();
        }
    }
}
