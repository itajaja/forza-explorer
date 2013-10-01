using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace ForzaFramework.Model
{
    public abstract class ModelBase : ObservableObject
    {
        public override abstract bool Equals(object other);
    }
}
