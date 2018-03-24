
using System.Collections.Generic;
using UnityEngine;

namespace CC.AI
{
    /// <summary>
    /// 行为树基类（所有节点都继承他）
    /// </summary>
    public abstract class CCBTBase:ScriptableObject
    {
        protected List<CCBTBase> ChildNode;
        protected CCPrecondition PreCondition;              //外在执行判断条件
    }
}
