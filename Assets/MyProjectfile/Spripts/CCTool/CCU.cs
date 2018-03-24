using System;
using System.Text.RegularExpressions;

namespace CC.U
{
    /// <summary>
    /// CC工具类
    /// </summary>
    public class CCU
    {
        /// <summary>
        /// 随机种子
        /// </summary>
        private static System.Security.Cryptography.RNGCryptoServiceProvider _rng;

        /// <summary>
        /// 使用RNGCryptoServiceProvider产生的种子生成真随机数
        /// </summary>
        public static int GetRandomByGuid(int min = 0, int max = 0)
        {
            int len = 0;
            Random random = new Random(GetRandomSeed());
            len = random.Next(min, max+1);
            return len;
        }

        /// <summary>
        /// 使用RNGCryptoServiceProvider生成随机种子
        /// </summary>
        /// <returns></returns>
        private static int GetRandomSeed()
        {
            byte[] bytes = new byte[4];
            if (_rng == null)
            {
                _rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            }
            _rng.GetBytes(bytes);
            return BitConverter.ToInt32(bytes, 0);
        }

        /// <summary>
        /// 字符串分割
        /// </summary>
        /// <param name="url">字符串</param>
        /// <param name="separate">分割符</param>
        /// <returns></returns>
        public static string USeparateString(string url, string separate)
        {
            if (url == "")
            {
                return "";
            }
            var strArray = Regex.Split(url, separate, RegexOptions.IgnoreCase);
            return strArray[GetRandomByGuid(0, strArray.Length)];
        }

        public static string USetintToTime(int time)
        {
            TimeSpan ts = new TimeSpan(0, 0, time);
            return ts.Hours + "小时" + ts.Minutes + "分钟" + ts.Seconds + "秒";
        }
    }
}
