namespace TDLibCore.Api
{
    public abstract class TLObject { }
    public abstract class Function : TLObject { }
    public abstract class Function<T> : Function where T : TLObject { }
}
