namespace Core.Paging
{
    public class MetaData
    {
        public int PageIndex { get; set; }
        public int TotalIndex  { get; set; }
        public int AccountRecord { get; set; }
        public int PageSize { get; set; }
        public bool HasNext { get{
                    return (PageIndex+1)<TotalIndex;
        } }
        public bool HasPrevious 
        { get{
              return PageIndex>0;
             } 
        }
    }
}