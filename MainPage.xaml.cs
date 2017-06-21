using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System.Profile;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Storage;
using Windows.UI.ViewManagement;
using InsTsinghua.TsinghuaTVs;
using InsTsinghua.Logins;
using InsTsinghua.Courses;
using InsTsinghua.Mails;
using InsTsinghua.Newss;
using InsTsinghua.Welcomes;

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace InsTsinghua
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<NavMenuItem> navMenuPrimaryItem = new List<NavMenuItem>(
            new[]
            {
                new NavMenuItem()
                {
                    FontFamily = new FontFamily("Segoe MDL2 Assets"),
                    Icon = "\xE80F",
                    Label = "新闻",
                    Selected = Visibility.Visible,
                    DestPage = typeof(News)
                },

                new NavMenuItem()
                {
                    FontFamily = new FontFamily("Segoe MDL2 Assets"),
                    Icon = "\xE7BE",
                    Label = "学堂",
                    Selected = Visibility.Collapsed,
                    DestPage = typeof(Weblearn)
                },

                new NavMenuItem()
                {
                    FontFamily = new FontFamily("Segoe MDL2 Assets"),
                    Icon = "\xE119",
                    Label = "邮箱",
                    Selected = Visibility.Collapsed,
                    DestPage = typeof(Email)
                },

                new NavMenuItem()
                {
                    FontFamily = new FontFamily("Segoe MDL2 Assets"),
                    Icon = "\xE1E4",
                    Label = "电视",
                    Selected = Visibility.Collapsed,
                    DestPage = typeof(TsinghuaTV)
                }

            });

        private List<NavMenuItem> navMenuSecondaryItem = new List<NavMenuItem>(
            new[]
            {
                new NavMenuItem()
                {
                    FontFamily = new FontFamily("Segoe MDL2 Assets"),
                    Icon = "\xE13D",
                    Label = "登录",
                    Selected = Visibility.Collapsed,
                    DestPage = typeof(loginindex)
                }
            });

        public MainPage()
        {
            this.InitializeComponent();
            NavigationCacheMode = NavigationCacheMode.Enabled;
            var bb = AnalyticsInfo.VersionInfo.DeviceFamily;
            if (bb == "Windows.Desktop" || bb == "Windows.Tablet")
            {
                var titleBar = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().TitleBar;
                titleBar.BackgroundColor = Colors.Purple;
                titleBar.ButtonHoverBackgroundColor = Colors.Wheat;
                titleBar.ButtonBackgroundColor = Colors.Purple;
            }
            else
            {
                StatusBar status = StatusBar.GetForCurrentView();
                status.BackgroundColor = Colors.BlueViolet;
                status.BackgroundOpacity = 1; // 透明度
                status.ForegroundColor = Colors.White;

                // Highest.Background = "Black";

            }

            NavMenuPrimaryListView.ItemsSource = navMenuPrimaryItem;
            NavMenuSecondaryListView.ItemsSource = navMenuSecondaryItem;
            // SplitView 开关
            PaneOpenButton.Click += (sender, args) =>
            {
                RootSplitView.IsPaneOpen = !RootSplitView.IsPaneOpen;
            };
            // 导航事件
            NavMenuPrimaryListView.ItemClick += NavMenuListView_ItemClick;
            NavMenuSecondaryListView.ItemClick += NavMenuListView_ItemClick;
            // 默认页
           
            RootFrame.SourcePageType = typeof(News);
        }
        private void NavMenuListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            // 遍历，将选中Rectangle隐藏
            foreach (var np in navMenuPrimaryItem)
            {
                np.Selected = Visibility.Collapsed;
            }
            foreach (var ns in navMenuSecondaryItem)
            {
                ns.Selected = Visibility.Collapsed;
            }

            NavMenuItem item = e.ClickedItem as NavMenuItem;
            // Rectangle显示并导航
            item.Selected = Visibility.Visible;
            TitleTextBlock.Text = item.Label;
            if (item.DestPage != null)
            {
                RootFrame.Navigate(item.DestPage);
            }

            RootSplitView.IsPaneOpen = false;
        }

        
         private void Initial1(object sender, RoutedEventArgs e)
         {
             ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
            //判断是否是第一次启动
            if ((localSettings.Values["FirstStart"] == null))
            {
                //第一次启动，初始化本地数据文件
                localSettings.Values["FirstStart"] = true;
            
                Frame root = Window.Current.Content as Frame;
                root.Navigate(typeof(Startspage));
            }
           
         }

       
        /*
private void Webview_NewWindowRequested(WebView sender, WebViewNewWindowRequestedEventArgs e)
{

   Webview.Navigate(e.Uri);

   e.Handled = true;

}

private void BackButton_Click(object sender, RoutedEventArgs e)
{
   if (News.IsSelected && Webview.CanGoBack && Webview.Source != new Uri("http://news.tsinghua.edu.cn/publish/thunews/index.html"))
   {
       Webview.GoBack();

   }


}
*/


    }
}
