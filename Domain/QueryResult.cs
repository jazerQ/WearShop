namespace Domain;

public class QueryResult<T>
{
    public bool IsSuccess { get; private set; }
    
    public IEnumerable<string> Errors { get; set; }
    
    public T Value { get; private set; }

    private QueryResult(T result, bool succeeded, IEnumerable<string> errors)
    {
        IsSuccess = succeeded;
        Value = result;
        Errors = errors;
    }

    public static QueryResult<T> Success(T result) => new QueryResult<T>(result, true,  []);

    public static QueryResult<T> Failure(IEnumerable<string> errors) => new QueryResult<T>(default, false, errors);
}