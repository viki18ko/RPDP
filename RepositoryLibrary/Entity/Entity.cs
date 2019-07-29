using System;

namespace RPDP.RepositoryLibrary.Entity
{
    public abstract class Entity<T> where T : Entity<T>
    {
        public virtual Int32 Id { get;  set; }

        private Boolean IsNew()
        {
            return Equals(Id, null);
        }

        public override Boolean Equals(Object obj)
        {
            var other = obj as T;
            if (other == null) return false;


            if (IsNew() && other.IsNew())
                return ReferenceEquals(this, other);

            return Id.Equals(other.Id);
        }

        private Nullable<Int32> oldHashCode;

        public override Int32 GetHashCode()
        {
            if (oldHashCode.HasValue)
                return oldHashCode.Value;

            if (IsNew())
            {
                oldHashCode = base.GetHashCode();
                return oldHashCode.Value;
            }
            return Id.GetHashCode();
        }

        public static Boolean operator ==(Entity<T> lhs, Entity<T> rhs)
        {
            return Equals(lhs, rhs);
        }

        public static Boolean operator !=(Entity<T> lhs, Entity<T> rhs)
        {
            return !Equals(lhs, rhs);
        }
    }
}