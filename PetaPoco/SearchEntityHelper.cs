using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace PetaPoco
{
    /// <summary>
    /// <Remark>作者：李小平 创建日期：2014-12-06</Remark>
    /// <Remark>描述：反射实现构建查询条件</Remark>
    /// </summary>
    public class SearchEntityHelper
    {
        public static string CreateSearchCondiiton<T>(T t)
        {
            var sbCondition = new StringBuilder(" where 1=1");

            Type type = t.GetType();
            PropertyInfo[] propertyArray = type.GetProperties();

            foreach (var property in propertyArray)
            {
                string pName = property.Name;
                object pValue = property.GetValue(t, null);
                int index = pName.LastIndexOf("_", StringComparison.Ordinal);
                bool isIntType = IsIntegralType(property.PropertyType) || IsIntegrallObjct(property.PropertyType);

                if (isIntType)
                {
                    if (pValue != null && Convert.ToInt32(pValue) > 0)
                    {
                        sbCondition.Append(" and");
                        sbCondition.Append(GetWildcards(pName.Substring(0, index),
                            pName.Substring(index + 1, pName.Length - index - 1), pValue, true));
                    }
                }
                else
                {
                    if (pValue != null && !string.IsNullOrEmpty(pValue.ToString()))
                    {
                        sbCondition.Append(" and");
                        sbCondition.Append(GetWildcards(pName.Substring(0, index),
                            pName.Substring(index + 1, pName.Length - index - 1), pValue, false));
                    }
                }
            }

            return sbCondition.ToString();
        }

        /// <summary>
        /// 判断是否Int对象类型
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        private static bool IsIntegrallObjct(Type t)
        {
            var tc = Type.GetTypeCode(t);
            return t == typeof(Int32?) || t == typeof(Int16?) || t == typeof(Int64?) || t == typeof(byte?) || t == typeof(SByte?);
        }

        /// <summary>
        /// 判断是否对象类型
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        private static bool IsIntegralType(Type t)
        {
            var tc = Type.GetTypeCode(t);
            return tc >= TypeCode.SByte && tc <= TypeCode.UInt64;
        }

        /// <summary>
        /// 生成查询条件
        /// </summary>
        /// <param name="field"></param>
        /// <param name="strOperator"></param>
        /// <param name="objValue"></param>
        /// <param name="isIntType"></param>
        /// <returns></returns>
        private static string GetWildcards(string field, string strOperator, object objValue, bool isIntType)
        {
            var strWildcards = new StringBuilder(field);

            if (strOperator.ToLower().Equals("in"))
                return strWildcards.Append(" in(" + objValue + ")").ToString();
            else if (strOperator.ToLower().Equals("notin"))
                return strWildcards.Append(" not in(" + objValue + ")").ToString();
            else if (strOperator.ToLower().Equals("like"))
                return strWildcards.Append(" like '%" + objValue + "%'").ToString();

            string strValue = objValue.ToString();
            if (!isIntType) strValue = "'" + objValue + "'";

            switch (strOperator.ToLower())
            {
                case "equal":
                    strWildcards.Append("=");
                    break;
                case "notequal":
                    strWildcards.Append("<>");
                    break;
                case "less":
                    strWildcards.Append("<");
                    break;
                case "lessequal":
                    strWildcards.Append("<=");
                    break;
                case "than":
                    strWildcards.Append(">");
                    break;
                case "thanequal":
                    strWildcards.Append(">=");
                    break;
            }

            return strWildcards.Append(strValue).ToString();
        }
    }
}
