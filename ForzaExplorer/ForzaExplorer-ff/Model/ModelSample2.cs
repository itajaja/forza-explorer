using System;

namespace ForzaExplorer.Model
{
  /// <summary>
  /// Model Class Implementation Sample
  /// </summary>
  public class ModelSample2 : IdentifiableModel
  {
    private int _intProperty;

    public int IntProperty
    {
      get { return _intProperty; }
      set { Set("IntProperty", ref _intProperty, value); }
    }

    public ModelSample2(Guid id)
      : base(id)
    {
    }


    public ModelSample2(int prop, Guid id) : this(id)
    {
      IntProperty = prop;
    }

    public override bool Equals(object other)
    {
      var castOther = other as ModelSample2;
      if (castOther != null)
      {
        return castOther.Id.Equals(Id);
      }
      return false;
    }
  }
}
