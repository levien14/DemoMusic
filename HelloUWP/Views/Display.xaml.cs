using HelloUWP.Emity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace HelloUWP.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Display : Page
    {



        public Display()
        {

            this.InitializeComponent();
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;

        }

        private async void Do_CheckId(object sender, RoutedEventArgs e)
        {
            //try
            //{
            // SplitView.currentMemberID = long.Parse(TextID.Text);
            HttpClient client = new HttpClient();
            #region format, thêm thuộc tính header
            // sửa lại, thêm thuộc tính cho header
            client.DefaultRequestHeaders.Accept.Clear();
            //("key","Basic Token")
            client.DefaultRequestHeaders.Add("Authorization", "Basic ATbW0oE3GGUfLQolmvqrgJA8M7DQcgIHsvNeabIsDxbG71j2Bs6kT43mvhKQ95w8");
            #endregion

            string reponese = await client.GetStringAsync(ServiceUrl.ServiceUrl.MEMBER_INFORMATION);
            Member member = JsonConvert.DeserializeObject<Member>(reponese);
            Uri url = new Uri(member.avatar, UriKind.Absolute);
            BitmapImage bmImage = new BitmapImage(url);
            this.Avatar.Source = bmImage;
            Debug.WriteLine(reponese);
            //Lable
            this.LUserName.Text = "Nick Name";
            this.LPassWord.Text = "PassWord";
            this.LEmail.Text = "Email";
            this.LPhonenumber.Text = "Phone Number";
            this.LAddress.Text = "Address";
            this.LGender.Text = "Gender";
            this.LBirthday.Text = "Birthday";
            this.LIntroduction.Text = "Introduction";
            this.UserName.Text = ": " + member.firstName + member.lastName;
            this.PassWord.Text = ": " + member.password;
            this.Email.Text = ": " + member.email;
            this.Phonenumber.Text = ": " + member.phone;
            this.Address.Text = ": " + member.address;
            if (member.gender == 1)
            {
                this.Gender.Text = ": Male";
            }
            else if (member.gender == 2)
            {
                this.Gender.Text = ": Falmale";
            }
            else
            {
                this.Gender.Text = ": Other";
            }
            this.Birthday.Text = "Birthday : " + member.birthday;
            this.Introduction.Text = "Introduction : " + member.introduction;
            //}catch(Exception ex)
            //{
            //    this.UserName.Text = "Error Sever";
            //}
        }
    }
}
