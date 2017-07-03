using ClassLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace InsTsinghua.Mails
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class Email : Page
    {
        public Email()
        {
            this.InitializeComponent();
        }

        private async void Oninitial(object sender, RoutedEventArgs e)
        {

            if(DataAccess.isDemo())
            {
                MessageDialog a = new MessageDialog("测试账号");
                await a.ShowAsync();
                Webemail.Visibility = Visibility.Visible;
                Warning.Visibility = Visibility.Collapsed;
            }
            else
            try
            {
                string username = DataAccess.getLocalSettings()["username"].ToString();
                var vault = new Windows.Security.Credentials.PasswordVault();
                string password = vault.Retrieve("Tsinghua_Learn_Website", username).Password;
                string emailname = await DataAccess.getemailName();
                    Webemail.Visibility = Visibility.Visible;
                    Warning.Visibility = Visibility.Collapsed;

                    string js1 = "";
                    js1 += $"document.getElementsByName('password')[0].setAttribute('value','{password}');";
                    await Webemail.InvokeScriptAsync("eval", new string[] { js1 });

                    string js =$"var nm='{emailname}';";
                    js += "document.getElementById('username').value=nm;";
                    await Webemail.InvokeScriptAsync("eval", new string[] { js });

                string js2 = "document.getElementsByName('action:login')[0].click();";
                await Webemail.InvokeScriptAsync("eval", new string[] { js2 });

                Webemail.Visibility = Visibility.Visible;
                Warning.Visibility = Visibility.Collapsed;
            }
            catch
            {
                MessageDialog a = new MessageDialog("网络故障或未登录");
                await a.ShowAsync();
            }


        }
    }
}
