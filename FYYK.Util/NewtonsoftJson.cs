using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FYYK.Util
{
    public class NewtonsoftJson
    {
        #region 序列化
        /// <summary>
        /// 将对象(包含集合对象)序列化为Json
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string SerializeObjToJson(object obj)
        {
            string strRes = string.Empty;
            try
            {
                strRes = JsonConvert.SerializeObject(obj);
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            return strRes;
        }
        #endregion

        #region 反序列化
        /// <summary>
        /// 将json反序列化为实体对象(包含DataTable和List<>集合对象)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="strJson"></param>
        /// <returns></returns>
        public static T JsonConvertDeserializeJsonToObj<T>(string strJson)
        {
            T oRes = default(T);
            try
            {
                oRes = JsonConvert.DeserializeObject<T>(strJson);
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }

            return oRes;
        }
        #endregion
    }
}
