using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ImportToolsNet.Core
{
    public class StreamUtil
    {
        //文件读取操作类
        /// <summary>
        /// 读取*json文件返回读取的字符串
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public string GetJsonText(string url)
        {
            string reslut = string.Empty;
            try
            {
                using (StreamReader sr = new StreamReader(url,Encoding.Default))
                {
                    while (!sr.EndOfStream)
                    {
                        reslut+= sr.ReadLine();
                    }
                }
            }
            catch (IOException ex)
            {
                throw new Exception( ex.Message);
            }
            return reslut;
        }
    }
}
