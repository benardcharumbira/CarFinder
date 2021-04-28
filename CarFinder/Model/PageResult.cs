using CarFinder.Data;
using System.Collections.Generic;

namespace CarFinder.Model
{
    public class PageResult
    {
        public int Count { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public List<Car> Items { get; set; }
    }
}
