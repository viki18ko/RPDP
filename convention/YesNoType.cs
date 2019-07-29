using System;
using System.Data;
using NHibernate;
using NHibernate.SqlTypes;
using NHibernate.Type;
using NHibernate.UserTypes;

namespace RPDP.convention
{
    /// <summary>
    /// A NHibernate <see cref="IType"/> for a <see cref="System.Nullable&lt;Boolean&gt;"/>
    /// mapped to a CHAR(1) database column with values '0', '1' or NULL.
    /// </summary>
    /// 
    public class YesNoType : IUserType
    {
        public Boolean IsMutable
        {
            get { return false; }
        }

        public Type ReturnedType
        {
            get { return typeof (YesNoType); }
        }

        public SqlType[] SqlTypes
        {
            get { return new[] {NHibernateUtil.String.SqlType}; }
        }

        public Object NullSafeGet(IDataReader rs, String[] names, Object owner)
        {
            var obj = NHibernateUtil.String.NullSafeGet(rs, names[0]);

            if (obj == null) return null;

            var yesNo = (String) obj;

            if (!Equals("1", yesNo) && !Equals("0", yesNo))
                throw new Exception(String.Format("Expected data to be '1' or '0' but was {0}", yesNo));

            return Equals("1", yesNo);
        }

        public void NullSafeSet(IDbCommand cmd, Object value, Int32 index)
        {
            if (value == null)
            {
                ((IDataParameter) cmd.Parameters[index]).Value = DBNull.Value;
            }
            else
            {
                var yes = (Boolean) value;
                ((IDataParameter) cmd.Parameters[index]).Value = yes ? "1" : "0";
            }
        }

        public Object DeepCopy(Object value)
        {
            return value;
        }

        public Object Replace(Object original, Object target, Object owner)
        {
            return original;
        }

        public Object Assemble(Object cached, Object owner)
        {
            return cached;
        }

        public Object Disassemble(Object value)
        {
            return value;
        }

        public new Boolean Equals(Object x, Object y)
        {
            if (ReferenceEquals(x, y)) return true;

            if (x == null || y == null) return false;

            return x.Equals(y);
        }

        public Int32 GetHashCode(Object x)
        {
            return x == null ? typeof (Boolean).GetHashCode() + 473 : x.GetHashCode();
        }
    }
}