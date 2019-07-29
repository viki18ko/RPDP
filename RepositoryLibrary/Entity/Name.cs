using System;

namespace RPDP.RepositoryLibrary.Entity
{
    public class Name
    {
        public String name { get; protected set; }

        public String Surname { get; protected set; }

        public String Patronymic { get; protected set; }

        public Name()
        {
            name = "defaultLastName";
            Surname = "defaultFirstName";
            Patronymic = "defaultMiddleName";
        }

        public Name(String surname, String name, String midleName)
        {
            if (String.IsNullOrWhiteSpace(surname))
                throw new ArgumentException("Argument first Name must be defined");

            if (String.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Argument last Name must be defined");

            Surname = surname;
            this.name = name;
            Patronymic = midleName;
        }

        public override Int32 GetHashCode()
        {
            unchecked
            {
                var result = Surname.GetHashCode();
                result = (result * 397) ^ (Patronymic?.GetHashCode() ?? 0);
                result = (result * 397) ^ name.GetHashCode();
                return result;
            }
        }

        public override Boolean Equals(Object other)
        {
            return Equals(other as Name);
        }

        public Boolean Equals(Name other)
        {
            if (other == null)
                return false;

            if (ReferenceEquals(this, other))
                return true;

            return Equals(other.Surname, Surname) && 
                    Equals(other.name, name) &&
                    Equals(other.Patronymic, Patronymic);
        }

        public override String ToString()
        {
            return $"{Surname} {name} {Patronymic}";
        }

        public static Name ToName(String name)
        {
            var names = name.Split(' ');
            Name res = new Name();
            res.Surname = names[0];
            res.name = names[1];
            res.Patronymic = names[2];
            return res;
        }
    }
}