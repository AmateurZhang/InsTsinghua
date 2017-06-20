using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System.Display;
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
      
        private ObservableCollection<TV1> TV1;
        private List<TV1> TTT;

        // Create this variable at a global scope. Set it to null.
        private DisplayRequest appDisplayRequest = null;

        public TsinghuaTV()
        {
            this.InitializeComponent();
            TV1 = new ObservableCollection<TV1>();
            TTT = new List<TV1>();

        }

        private void REFRESH_Click(object sender, RoutedEventArgs e)
        {
            TTT = TVManager.GETTV("hd", TV1);
        }

        private void TVGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)

        {
            string Url
        = "https://iptv.tsinghua.edu.cn/player.html?vid=cctv1hd";
            int tp = TVGrid.SelectedIndex;
            if (InOut.IsOn)
                Url = TTT[tp].URL;
            else
                Url = TTT[tp].URLS;
            // Webview.Navigate(new Uri(Url));
            MyMedias.Source = new Uri(Url);
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
    }
}
