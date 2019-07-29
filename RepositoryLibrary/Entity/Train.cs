using System.Collections.Generic;

namespace RPDP.RepositoryLibrary.Entity
{
    public class Train:Entity<Train>
    {
        public virtual AmountCar IdAmountCar { get; set; }
        public virtual IList<Car> Cars { get; set; }

        public Train()
        {
            Cars = new List<Car>();

            IdAmountCar = new AmountCar();
            IdAmountCar.AddTrain(this);
        }

        public virtual void AddCar(Car car)
        {
            car.Trains.Add(this);
            Cars.Add(car);
        }
    }
}
