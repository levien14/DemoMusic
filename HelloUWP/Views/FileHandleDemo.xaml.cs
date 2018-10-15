using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage.Pickers;
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
    public sealed partial class FileHandleDemo : Page
    {
        public FileHandleDemo()
        {
            this.InitializeComponent();
        }

        private async void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            string content = FileConten.Text;
            string filename = FileName.Text;

            // Windows.Storage.StorageFolder folder = Windows.Storage.ApplicationData.Current.LocalFolder;
            // Windows.Storage.StorageFolder folder = Windows.ApplicationModel.Package.Current.InstalledLocation;
            Windows.Storage.StorageFolder folder = Windows.Storage.KnownFolders.PicturesLibrary;
            Windows.Storage.StorageFile file = await folder.CreateFileAsync(filename, Windows.Storage.CreationCollisionOption.OpenIfExists);
            await Windows.Storage.FileIO.WriteTextAsync(file, content);

        }

        private async void BtnLoad_Click(object sender, RoutedEventArgs e)
        {
            string filename = FileName.Text;
            FileOpenPicker openPicker = new FileOpenPicker();
            openPicker.ViewMode = PickerViewMode.Thumbnail;
            openPicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;

            openPicker.FileTypeFilter.Add(".jpg");
            openPicker.FileTypeFilter.Add(".png");

            Windows.Storage.StorageFile file = await openPicker.PickSingleFileAsync();

            if(file != null)
            {

            }

            //Windows.Storage.StorageFolder folder = Windows.Storage.ApplicationData.Current.LocalFolder;
            // Windows.Storage.StorageFolder folder = Windows.ApplicationModel.Package.Current.InstalledLocation;
            //Windows.Storage.StorageFolder folder = Windows.Storage.KnownFolders.PicturesLibrary;
            //Windows.Storage.StorageFile file = await folder.GetFileAsync(filename);
            //string content = await Windows.Storage.FileIO.ReadTextAsync(file);
            //FileConten.Text = content;

        }
    }
}
