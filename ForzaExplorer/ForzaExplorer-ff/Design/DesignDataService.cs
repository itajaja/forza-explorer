using System;
using ForzaFramework.Model;

namespace ForzaFramework.Design
{
    public class DesignDataService : IDataService
    {
        public void GetData(Action<ModelSample, Exception> callback)
        {
            // Use this to create design time data

            var item = new ModelSample("Welcome to MVVM Light [design]");
            callback(item, null);
        }
    }
}