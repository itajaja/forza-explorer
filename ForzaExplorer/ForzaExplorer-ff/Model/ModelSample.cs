using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForzaExplorer.Model
{
    /// <summary>
    /// Model Class Implementation Sample
    /// </summary>
    public class ModelSample : ModelBase
    {
        private string _title;

        public string Title
        {
            get { return _title; }
            set { Set("Title", ref _title, value); }
        }

        public ModelSample(string title)
        {
            Title = title;
        }

        public override bool Equals(object other)
        {
            var castOther = other as ModelSample;
            if(castOther != null)
            {
                return castOther.Title == Title;
            }
            return false;
        }
    }
}
