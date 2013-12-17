using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XboxLeadersNETWrapper
{
    public class Achievements
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
        public Achievements()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Current"></param>
        /// <param name="Total"></param>
        public Achievements(Int32 Current, Int32 Total)
        {
            this.Current = Current;
            this.Total = Total;
        }
    }
}