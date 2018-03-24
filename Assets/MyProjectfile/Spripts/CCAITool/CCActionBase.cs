using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CC.AI
{
    /// <summary>
    /// 行为树叶子节点基类（执行节点）
    /// </summary>
   public abstract class CCActionBase:CCBTBase
    {
        /// <summary>
        /// 执行
        /// </summary>
        public abstract void Act();
    }
}
