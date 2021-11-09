using AppMusic.Entities;
using AppMusic.Services;
using System;
using System.Collections.Generic;
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

namespace AppMusic.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CreateSongPage : Page
    {
        private int statusChoose = 1;
        SongService songSevice = new SongService();
        public CreateSongPage()
        {
            this.InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            
            var song = new Song
            {
                thumbnail = txt_thumbnail.Text,
                account_id = Int32.Parse(txt_userId.Text),
                name = txt_name.Text,
                author = txt_author.Text,
                link = txt_link.Text,
                singer = txt_singer.Text,
                description = txt_description .Text,
                status = statusChoose,
            };
            var relust = await songSevice.Save(song);
            if(relust == true)
            {
                ContentDialog dialog = new ContentDialog();
                dialog.Title = "Save your work?";
                dialog.Title = "Thong Bao";
                dialog.Content = "Thêm Thành Công";
                dialog.CloseButtonText = "Cancel";
                dialog.DefaultButton = ContentDialogButton.Primary;
                await dialog.ShowAsync();
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton status = sender as RadioButton;
            switch (status.Tag){
                case "public":
                    statusChoose = 1;
                    break;
                case "private":
                    statusChoose = 0;
                    break;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txt_name.Text = "";
            txt_author.Text = "";
            txt_singer.Text = "";
            txt_link.Text = "";
            txt_description.Text = "";
        }
    }
}
