using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace InsTsinghua.Welcomes
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class Startspage : Page
    {
        public Startspage()
        {
            this.InitializeComponent();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
           /* if (localSettings.Values["FirstStart"] == null)
            {
                FlipSts.Visibility = Visibility.Visible;
                localSettings.Values["FirstStart"] = true;
            }
            else
            {
                FlipSts.Visibility = Visibility.Collapsed;
            }*/
        }

        private  void StartButton_Click(object sender, RoutedEventArgs e)
        {


           // Sts.Visibility = Visibility.Collapsed;
            Frame root = Window.Current.Content as Frame;
            root.Navigate(typeof(MainPage));
            /*if (DataAccess.supposedToWorkAnonymously())
            {
                btnLogin.Content = "登录";
                //  btnRefreshTimetable.IsEnabled = false;
                //  btnUpdate.IsEnabled = false;
                update_without_credential();
            }
            else if (!DataAccess.supposedToWorkAnonymously()
               && DataAccess.credentialAbsent())
            {
                update_without_credential();
                await changeAccountAsync();
            }
            else if (!DataAccess.credentialAbsent())
            {
                update_with_credential();
            }*/
        }
    }
}
