namespace Business.HttpResponse
{
public class HttpResponse<T>
{ 
 public bool Status { get; set; }
 public string Message { get; set; }
 public T Data { get; set; }
}
}