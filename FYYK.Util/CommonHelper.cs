using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FYYK.Util
{
    public class CommonHelper
    {

        #region InitializationDate
        /// <summary>
        /// InitializationDate
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string InitializationDate(int value)
        {
            return System.DateTime.Now.AddDays(DateTime.Now.Day - value).ToString("yyyy-MM-dd");
        }
        #endregion
    }
}
