using System;
using Com.Scwang.Smartrefresh.Layout.Api;
using Com.Scwang.Smartrefresh.Layout.Constant;
using Com.Scwang.Smartrefresh.Layout.Listener;

namespace SmartRefreshLayout.Additions
{
    public class OnRefreshListenerImpl : Java.Lang.Object, IOnRefreshListener
    {
        public Action<IRefreshLayout> RefreshAction { get; set; }
        public void OnRefresh(IRefreshLayout p0)
        {
            RefreshAction?.Invoke(p0);
        }
    }

    public class OnRefreshLoadmoreListenerImpl : Java.Lang.Object, IOnRefreshLoadmoreListener
    {
        public Action<IRefreshLayout> LoadmoreAction { get; set; }
        public Action<IRefreshLayout> RefreshAction { get; set; }
        public void OnLoadmore(IRefreshLayout p0)
        {
            LoadmoreAction?.Invoke(p0);
        }

        public void OnRefresh(IRefreshLayout p0)
        {
            RefreshAction?.Invoke(p0);
        }
    }

    public class OnMultiPurposeListenerImpl : Java.Lang.Object, IOnMultiPurposeListener
    {
        public Action<IRefreshLayout> LoadmoreAction { get; set; }
        public Action<IRefreshLayout> RefreshAction { get; set; }
        public Action<IRefreshLayout, RefreshState, RefreshState> StateChangedAction { get; set; }
        public Action<IRefreshFooter, bool> FooterFinishAction { get; set; }
        public Action<IRefreshFooter, float, int, int, int> FooterPullingAction { get; set; }
        public Action<IRefreshFooter, float, int, int, int> FooterReleasingAction { get; set; }
        public Action<IRefreshFooter, int, int> FooterStartAnimatorAction { get; set; }


        public Action<IRefreshHeader, bool> HeaderFinishAction { get; set; }
        public Action<IRefreshHeader, float, int, int, int> HeaderPullingAction { get; set; }
        public Action<IRefreshHeader, float, int, int, int> HeaderReleasingAction { get; set; }
        public Action<IRefreshHeader, int, int> HeaderStartAnimatorAction { get; set; }

        public void OnLoadmore(IRefreshLayout p0)
        {
            LoadmoreAction?.Invoke(p0);
        }

        public void OnRefresh(IRefreshLayout p0)
        {
            RefreshAction?.Invoke(p0);
        }

        public void OnStateChanged(IRefreshLayout p0, RefreshState p1, RefreshState p2)
        {
            StateChangedAction?.Invoke(p0, p1, p2);
        }

        public void OnFooterFinish(IRefreshFooter p0, bool p1)
        {
            FooterFinishAction?.Invoke(p0, p1);
        }

        public void OnFooterPulling(IRefreshFooter p0, float p1, int p2, int p3, int p4)
        {
            FooterPullingAction?.Invoke(p0, p1, p2, p3, p4);
        }

        public void OnFooterReleasing(IRefreshFooter p0, float p1, int p2, int p3, int p4)
        {
            FooterReleasingAction?.Invoke(p0, p1, p2, p3, p4);
        }

        public void OnFooterStartAnimator(IRefreshFooter p0, int p1, int p2)
        {
            FooterStartAnimatorAction?.Invoke(p0, p1, p2);
        }

        public void OnHeaderFinish(IRefreshHeader p0, bool p1)
        {
            HeaderFinishAction?.Invoke(p0, p1);
        }

        public void OnHeaderPulling(IRefreshHeader p0, float p1, int p2, int p3, int p4)
        {
            HeaderPullingAction?.Invoke(p0, p1, p2, p3, p4);
        }

        public void OnHeaderReleasing(IRefreshHeader p0, float p1, int p2, int p3, int p4)
        {
            HeaderReleasingAction?.Invoke(p0, p1, p2, p3, p4);
        }

        public void OnHeaderStartAnimator(IRefreshHeader p0, int p1, int p2)
        {
            HeaderStartAnimatorAction?.Invoke(p0, p1, p2);
        }
    }

    public class OnLoadmoreListenerImpl : Java.Lang.Object, IOnLoadmoreListener
    {
        public Action<IRefreshLayout> LoadmoreAction { get; set; }
        public void OnLoadmore(IRefreshLayout p0)
        {
            LoadmoreAction?.Invoke(p0);
        }
    }
}