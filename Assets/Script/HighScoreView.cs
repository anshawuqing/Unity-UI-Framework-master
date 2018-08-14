using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/*
 *	
 *  
 *
 *	by Xuanyi
 *
 */

namespace MoleMole
{
   /// <summary>
   ///  代指游戏中每个View的上下文,存储了这个界面的各种数据状态
   ///  游戏中会通过 栈的方式管理Context  
   /// </summary>
    public class HighScoreContext : BaseContext
    {
        public HighScoreContext()
            : base(UIType.HighScore)
        {

        }
    }

    /// <summary>
    /// 代指中的主要界面, 主界面，装备界面，装备详情界面
    /// 在 View  包含了界面处理数据的逻辑
    /// </summary>
    public class HighScoreView : AnimateView
    {
        public GridScroller _gridScroller;

        public override void OnEnter(BaseContext context)
        {
            base.OnEnter(context);
            _gridScroller.Init(OnChange, 100, new Vector2(0.12f, 1f));
        }

        public override void OnExit(BaseContext context)
        {
            base.OnExit(context);
        }

        public override void OnPause(BaseContext context)
        {
            base.OnPause(context);
        }

        public override void OnResume(BaseContext context)
        {
            base.OnResume(context);
        }

        public void BackCallBack()
        {
            Singleton<ContextManager>.Instance.Pop();
        }

        public void OnChange(Transform trans, int index)
        {
            trans.GetComponent<HighScoreItem>().Init(index);
        }
    }
}
