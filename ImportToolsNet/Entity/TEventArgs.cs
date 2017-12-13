using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImportToolsNet.Entity
{
    //定义泛型类
    public class TEventArgs<T> : EventArgs
    {
        public TEventArgs(T t)
        {
            Data = t;
        }

        public T Data { get; set; }
    }
}
