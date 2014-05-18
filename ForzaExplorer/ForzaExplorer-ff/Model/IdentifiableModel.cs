using System;

namespace ForzaExplorer.Model
{
  /// <summary>
  /// Defines a model object that can be identified by an Id
  /// </summary>
  public abstract class IdentifiableModel : ModelBase
  {
    readonly Guid _id;

    protected IdentifiableModel(Guid id)
    {
      _id = id;
    }


    public Guid Id
    {
      get { return _id; }
    }

    public override int GetHashCode()
    {
      return _id.GetHashCode();
    }
  }
}
