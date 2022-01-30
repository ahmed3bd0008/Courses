using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Paging
{
    public class PagingList<T>:List<T>
    {
        public MetaData MetaData { get; set; }
        public PagingList(List<T>Source,int PageIndex,int PageSize,int AccountRecord)
        {
            MetaData=new ()
            {
                 PageIndex=PageIndex,
                 PageSize=PageSize,
                 TotalIndex=(int)Math.Ceiling((int)AccountRecord/(double)PageSize)
            };
            ;this.AddRange(Source);
        }
        public static PagingList<T> ToPageList(List<T>Source,int PageIndex,int PageSize)
        {
                    int count=Source.Count;
                    var items=Source.Skip((PageIndex-1)*PageSize).Take(PageSize).ToList();
                    return new PagingList<T>(Source:items,PageIndex:PageIndex,PageSize:PageSize,AccountRecord:count);
                    
        }
}
}