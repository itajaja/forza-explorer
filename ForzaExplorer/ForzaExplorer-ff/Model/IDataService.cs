using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForzaFramework.Model
{
    public interface IDataService
    {
        void GetData(Action<ModelSample, Exception> callback);
    }
}
