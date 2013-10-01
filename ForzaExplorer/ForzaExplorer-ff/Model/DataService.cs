using System;

namespace ForzaFramework.Model
{
    public class DataService : IDataService
    {
        public void GetData(Action<ModelSample, Exception> callback)
        {
            // Use this to connect to the actual data service

            var item = new ModelSample("Welcome to MVVM Light");
            callback(item, null);
        }
    }
}