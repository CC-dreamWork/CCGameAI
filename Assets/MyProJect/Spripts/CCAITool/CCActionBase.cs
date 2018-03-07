using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CC.AI
{
    /// <summary>
    /// 行为树叶子节点基类
    /// </summary>
   public abstract class CCActionBase:CCBTBase
    {
        public abstract void Act();
    }
}
