using System;
using System.Collections.Generic;

namespace RPDP.RepositoryLibrary.Entity
{
    public class TypeCar:Entity<TypeCar>
    {
        public virtual String Type { get; set; }
        public virtual IList<Car> Cars { get; set; }

        public TypeCar()
        {
            Cars = new List<Car>();
        }

        public virtual void AddTypeCar(Car car)
        {
            car.IdTypeCar = this;
            Cars.Add(car);
        }
    }
}
