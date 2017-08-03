using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System.Display;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace InsTsinghua.TsinghuaTVs
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class TsinghuaTV : Page
    {
      
        public ObservableCollection<TV1> TV1;
        public List<TV1> TTT;

        // Create this variable at a global scope. Set it to null.
        private DisplayRequest appDisplayRequest = null;

        public TsinghuaTV()
        {
            this.InitializeComponent();
            TV1 = new ObservableCollection<TV1>();
            TTT = new List<TV1>();
           

        }

        private async void REFRESH_Click(object sender, RoutedEventArgs e)
        {
            TTT = TVManager.GETTV("hd", true, TV1);
            ConnectWarning.Visibility = Visibility.Collapsed;

            if (InOut.IsOn)
            {
                TVGrid.IsEnabled = false;
                ConnectWarning.Visibility = Visibility.Visible;
                //
                bool outside_campus_network = await DataAccess.OutOfCampus();
                //
                if (DataAccess.isDemo())
                {
                    MessageDialog ms1g = new MessageDialog("测试账号！");
                    await ms1g.ShowAsync();
                    try
                    {
                        await Remote.logintoiptvDemo();
                    }
                    catch
                    {
                        MessageDialog msg = new MessageDialog("Connect fails with Demo");
                    }

                    TVGrid.IsEnabled = true;
                }
                else if(DataAccess.credentialAbsent()&&outside_campus_network)
                {
                    MessageDialog msg = new MessageDialog("访问校内资源请先登录！");
                    await msg.ShowAsync();
                    TVGrid.IsEnabled = false;
                }
                else
                {
                    //
                    if (outside_campus_network)
                        try
                        {
                            await Remote.logintoiptv();
                        }
                        catch
                        {
                            MessageDialog msg = new MessageDialog("检查网络连接！");
                            await msg.ShowAsync();
                        }
                    
                    TVGrid.IsEnabled = true;
                }
                ConnectWarning.Visibility = Visibility.Collapsed;
            }
        }

        private void TVGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)

        {
            string Url
        = "https://iptv.tsinghua.edu.cn/player.html?vid=cctv1hd";
            try
            {
                int tp = TVGrid.SelectedIndex;
                if (InOut.IsOn)
                    Url = TTT[tp].URL;
                else
                    Url = TTT[tp].URLS;
                // Webview.Navigate(new Uri(Url));
                MyMedias.Source = new Uri(Url);
            }
            catch
            {
                
            }
           
        }

        private void MyMedias_CurrentStateChanged(object sender, RoutedEventArgs e)
        {
            MediaElement mediaElement = sender as MediaElement;
            if (mediaElement != null && mediaElement.IsAudioOnly == false)
            {
                if (mediaElement.CurrentState == Windows.UI.Xaml.Media.MediaElementState.Playing)
                {
                    if (appDisplayRequest == null)
                    {
                        // This call creates an instance of the DisplayRequest object. 
                        appDisplayRequest = new DisplayRequest();
                        appDisplayRequest.RequestActive();
                    }
                }
                else // CurrentState is Buffering, Closed, Opening, Paused, or Stopped. 
                {
                    if (appDisplayRequest != null)
                    {
                        // Deactivate the display request and set the var to null.
                        appDisplayRequest.RequestRelease();
                        appDisplayRequest = null;
                    }
                }
            }

        }



        private async void InOut_Toggled(object sender, RoutedEventArgs e)
        {
            bool outside_campus_network = await DataAccess.OutOfCampus();
            try
            {
                ToggleSwitch toggleSwitch = sender as ToggleSwitch;
                if (toggleSwitch != null)
                {
                    TVGrid.SelectedItem = null;
                    MyMedias.Stop();
                    MyMedias.Source = null;
                    if (toggleSwitch.IsOn == true)
                    {
                        if (DataAccess.credentialAbsent()&&outside_campus_network)
                            TVGrid.IsEnabled = false;
                        else
                        {
                            TVGrid.IsEnabled = true;
                        }
                        TTT = TVManager.GETTV("hd", true, TV1);
                    }
                    else if (toggleSwitch.IsOn == false)
                    {
                        TVGrid.IsEnabled = true;
                        TTT = TVManager.GETTV("hd", false, TV1);
                    }
                }
            }
            catch
            {

            }

        }
    }
}
