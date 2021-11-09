namespace Core.Paging
{
    public abstract class RequestPrameters
    {
        const int MaxSize=50;       
        private int _PageSize { get; set; }
        public int PageSize { 
                        get{
                                    return _PageSize;
                           } 
                        set{
                                    _PageSize=value>PageSize?MaxSize:value;
                        } 
                       }
        public int PageNumber { get; set; }
        public string SortField { get; set; }
        public string SortQueue { get; set; }
    }
    public class RequestCounteryPrameter:RequestPrameters
    {
        
    }
}