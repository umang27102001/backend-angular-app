namespace backend.Abstraction.Result
{
    public class Result<T>: IResult<T>
    {
        public T Value { get; set; } = default!;
        public bool IsSuccess { get; set; }
    }
}
