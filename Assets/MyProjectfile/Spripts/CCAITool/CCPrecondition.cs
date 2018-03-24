using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace CC.AI
{
    /// <summary>
    /// 执行条件（前提）
    /// </summary>
   public abstract class CCPrecondition:ScriptableObject
    {
        /// <summary>
        /// 判断
        /// </summary>
        /// <returns></returns>
        public virtual bool Check()
        {
            return true;
        }
    }
}
