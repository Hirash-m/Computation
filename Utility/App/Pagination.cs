using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility.App
{
    public class Pagination
    {
        public int DataRow { get; set; } = 50;
        public int PageIndex { get; set; } = 1;
        public int PageCount { get; set; }  
        public int TotalCount { get; set; }


        public int CalculatePageCount()
        {
            if (TotalCount % DataRow == 0)
            {
                return TotalCount / DataRow;
            }
            else
            {
                return (TotalCount / DataRow) + 1;
            }
        }
        public int Skip() {  return  (DataRow * PageIndex) - DataRow; }

    }
}
