using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace FYYK.Util
{
    public class CheckHelper
    {
        #region CheckNumber 验证数字
        /// <summary>
        /// 验证数字
        /// </summary>
        /// <param name="number">数字内容</param>
        /// <returns>true 验证成功 false 验证失败</returns>
        public static bool CheckNumber(string number)
        {
            if (string.IsNullOrEmpty(number))
                return false;
            Regex regex = new Regex(@"^(-)?\d+(\.\d+)?$");
            if (regex.IsMatch(number))
                return true;
            else
                return false;
        }
        #endregion
    }
}
