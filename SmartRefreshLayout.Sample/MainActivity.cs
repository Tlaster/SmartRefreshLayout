using Android.App;
using Android.Widget;
using Android.OS;
using SmartRefreshLayout.Additions;

namespace SmartRefreshLayout.Sample
{
    [Activity(Label = "SmartRefreshLayout.Sample", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            var refreshLayout = FindViewById<Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout>(Resource.Id.refreshLayout);
            refreshLayout.SetOnRefreshListener(new OnRefreshListenerImpl
            {
                RefreshAction = view =>
                {
                    refreshLayout.FinishRefresh(2000);
                }
            });
            refreshLayout.SetOnLoadmoreListener(new OnLoadmoreListenerImpl
            {
                LoadmoreAction = view =>
                {
                    refreshLayout.FinishLoadmore(2000);
                }
            });
        }
    }
}

