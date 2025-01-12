namespace backend.Abstraction.Result
{
    public interface IResult<T>
    {
        T Value { get; }
        bool IsSuccess { get; }
    }
}
