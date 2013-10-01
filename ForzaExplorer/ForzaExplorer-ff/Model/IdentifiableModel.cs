using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForzaFramework.Model
{
    /// <summary>
    /// Defines a model object that can be identified by an Id
    /// </summary>
    public abstract class IdentifiableModel : ModelBase
    {
        Guid _id;

        public Guid Id
        {
            get { return _id; }
            set { Set("Id", ref _id, value); }
        }

        public override int GetHashCode()
        {
            return _id.GetHashCode();
        }
    }
}
