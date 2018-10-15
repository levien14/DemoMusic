using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace HelloUWP.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SplitView : Page
    {
        private string curren_tag;
        public static long currentMemberID;
        public SplitView()
        {
            this.InitializeComponent();
        }
      
        

        private void HomeClick(object sender, RoutedEventArgs e)
        {
            this.SplitViewla.IsPaneOpen = !this.SplitViewla.IsPaneOpen;
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            RadioButton rad = sender as RadioButton;
            if(curren_tag == rad.Tag.ToString())
            {
                return;
            }
            switch (rad.Tag.ToString())
            {
                case "Account":
                    curren_tag = "Account";
                    this.Login.Navigate(typeof(MainPage));
                    break;
                case "Display":
                    curren_tag = "Display";
                    this.Login.Navigate(typeof(Display));
                    break;
                case "Login":
                    curren_tag = "Login";
                    this.Login.Navigate(typeof(Login));
                    break;
                default:
                    break;
            }
        }
    }
}
