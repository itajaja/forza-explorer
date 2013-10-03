using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForzaExplorer.Model
{
    public interface IDataService
    {
        void GetData(Action<ModelSample, Exception> callback);
    }
}
