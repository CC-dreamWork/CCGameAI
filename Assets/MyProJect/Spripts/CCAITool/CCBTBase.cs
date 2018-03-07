
using System.Collections.Generic;
using UnityEngine;

namespace CC.AI
{
    /// <summary>
    /// 行为树基类（所有节点都继承他）
    /// </summary>
    public abstract class CCBTBase:ScriptableObject
    {
        protected List<W_BTNode> ChildNode;
    }
}
