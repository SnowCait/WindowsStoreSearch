﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x411 を参照してください

namespace WindowsStoreSearch
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void Search_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            await Launcher.LaunchUriAsync(new Uri($"ms-windows-store://search/?query={args.QueryText}"));
        }

        private async void Tags_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            await Launcher.LaunchUriAsync(new Uri($"ms-windows-store://assoc/?Tags={args.QueryText}"));
        }

        private async void Publisher_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            await Launcher.LaunchUriAsync(new Uri($"ms-windows-store://publisher/?name={args.QueryText}"));
        }

        private async void FileExt_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            await Launcher.LaunchUriAsync(new Uri($"ms-windows-store://assoc/?FileExt={args.QueryText}"));
        }

        private async void Protocol_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            await Launcher.LaunchUriAsync(new Uri($"ms-windows-store://assoc/?Protocol={args.QueryText}"));
        }
    }
}
