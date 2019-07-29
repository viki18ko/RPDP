using System;
using System.Collections.Generic;

namespace RPDP.RepositoryLibrary.Entity
{
    public class AmountCar:Entity<AmountCar>
    {
        public virtual Int32 Number { get; set; }

        public virtual IList<Train> Trains { get; set; }

        public AmountCar()
        {
            Trains = new List<Train>();
        }

        public virtual void AddTrain(Train train)
        {
            train.IdAmountCar = this;
            Trains.Add(train);
        }
    }
}
