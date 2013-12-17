using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XboxLeadersNETWrapper
{
    public class GamerScore
    {
        /// <summary>
        /// 
        /// </summary>
        public Int32 Current { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Int32 Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public GamerScore()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Current"></param>
        /// <param name="Total"></param>
        public GamerScore(Int32 Current, Int32 Total)
        {
            this.Current = Current;
            this.Total = Total;
        }
    }
}
