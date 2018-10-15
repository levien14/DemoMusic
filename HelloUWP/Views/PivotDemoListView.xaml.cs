using HelloUWP.Emity;
using HelloUWP.Emity.DataAccessLibrary;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public sealed partial class PivotDemoListView : Page

    {
        private ObservableCollection<Song> listSong;
        internal ObservableCollection<Song> ListSong { get => listSong; set => listSong = value; }

        public PivotDemoListView()
        {
            this.ListSong = new ObservableCollection<Song>();
            this.ListSong.Add(new Song()
            {
                name = "Co ay da tung",
                thumbnail = "https://i.ytimg.com/vi/VaUfXNaSMbU/maxresdefault.jpg"

            });

            this.InitializeComponent();
           //ShowAll();

        }
        private void ShowAll()
        {
            //User entries = new User
            ListSong.Clear();
            using (SqliteConnection db =
                new SqliteConnection(DataAccess.SQL_CONNECTION_STRING))
            {
                db.Open();
                SqliteCommand selectCommand = new SqliteCommand
                    ("SELECT * from Songs", db);
                SqliteDataReader query = selectCommand.ExecuteReader();
                while (query.Read())
                {
                    
                    Debug.WriteLine(query.GetString(1));
                    Debug.WriteLine(query.GetString(2));

                    ListSong.Add(new Song()
                    {
                        
                        name = query.GetString(1)
                        

                    }); 


                }
                db.Close();
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Song song = new Song()
            {
                name = this.Name.Text,
                thumbnail = this.Namethumbnail.Text
            };
            this.ListSong.Add(song);
            this.Name.Text = String.Empty;
            this.Namethumbnail.Text = String.Empty;

            SongModel.Add(song);

        }
    }
}
