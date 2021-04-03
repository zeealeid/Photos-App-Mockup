using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Hosting;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Mail_Mockup
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class cole : Page
    {


        public cole()
        {
            this.InitializeComponent();
            ObservableCollection<Photos> photos = new ObservableCollection<Photos>();
            photos.Add(new Photos()
            {
                Images = "Assets/Images/image (1).jpg"
            });
            photos.Add(new Photos()
            {
                Images = "Assets/Images/image (2).jpg"
            });
            photos.Add(new Photos()
            {
                Images = "Assets/Images/image (3).jpg"
            });
            photos.Add(new Photos()
            {
                Images = "Assets/Images/image (4).jpg"
            });
            photos.Add(new Photos()
            {
                Images = "Assets/Images/image (5).jpg"
            });
            photos.Add(new Photos()
            {
                Images = "Assets/Images/image (6).jpg"
            });
            photos.Add(new Photos()
            {
                Images = "Assets/Images/image (7).jpg"
            });
            photos.Add(new Photos()
            {
                Images = "Assets/Images/image (8).jpg"
            });
            photos.Add(new Photos()
            {
                Images = "Assets/Images/image (9).jpg"
            });
            photos.Add(new Photos()
            {
                Images = "Assets/Images/image (10).jpg"
            });


            ImagesGrid.ItemsSource = photos;


            ObservableCollection<Photos2> photos2 = new ObservableCollection<Photos2>();
            photos2.Add(new Photos2()
            {
                Images2 = "Assets/Images/image (11).jpg"
            });
            photos2.Add(new Photos2()
            {
                Images2 = "Assets/Images/image (12).jpg"
            });
            photos2.Add(new Photos2()
            {
                Images2 = "Assets/Images/image (13).jpg"
            });
            photos2.Add(new Photos2()
            {
                Images2 = "Assets/Images/image (14).jpg"
            });
            photos2.Add(new Photos2()
            {
                Images2 = "Assets/Images/image (15).jpg"
            });
            photos2.Add(new Photos2()
            {
                Images2 = "Assets/Images/image (16).jpg"
            });
            photos2.Add(new Photos2()
            {
                Images2 = "Assets/Images/image (17).jpg"
            });
            ImagesGrid2.ItemsSource = photos2;
        }

        public class Photos
        {
            public string Images { get; set; }
        }

        public class Photos2
        {
            public string Images2 { get; set; }
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AppBarButton_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private async void AppBarButton_Click_2(object sender, RoutedEventArgs e)
        {
            ContentDialogResult result = await DeleteDialog.ShowAsync();
            
        }


        private void ImagesGrid2_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {
            FlyoutShowOptions myOption = new FlyoutShowOptions();
            myOption.ShowMode = FlyoutShowMode.Transient;
            myOption.Position = e.GetPosition((FrameworkElement)sender);
            RightClickMenu.ShowAt(sender as FrameworkElement, myOption);
        }

        private void ImagesGrid_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {
            FlyoutShowOptions myOption = new FlyoutShowOptions();
            myOption.ShowMode = FlyoutShowMode.Transient;
            myOption.Position = e.GetPosition((FrameworkElement)sender);
            RightClickMenu.ShowAt(sender as FrameworkElement, myOption);
        }

        private void DeleteDialog_Opened(ContentDialog sender, ContentDialogOpenedEventArgs args)
        {

        }

        private void ImagesGrid_Loaded(object sender, RoutedEventArgs e)
        {
            
            
        }

        

        private async void FolderClick_Click(object sender, RoutedEventArgs e)
        {
            ContentDialogResult result = await FoldeDialog.ShowAsync();
        }
    }
}
