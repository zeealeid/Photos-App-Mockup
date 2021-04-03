using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Mail_Mockup
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class days : Page
    {
        public days()
        {
            this.InitializeComponent();
            ObservableCollection<DaysGrid> daysGrids = new ObservableCollection<DaysGrid>();

            daysGrids.Add(new DaysGrid()
            {
                BackGround = "Assets/Images/image (1).jpg",
                MainHeading = "Thursday - Tuesday",
                SubHeading = "25 - 30 March",
                ImageNumber = "5"
            });
            daysGrids.Add(new DaysGrid()
            {
                BackGround = "Assets/Images/image (4).jpg",
                MainHeading = "10 - 22 March",
                SubHeading = "3 weeks ago",
                ImageNumber = "3"
            });
            daysGrids.Add(new DaysGrid()
            {
                BackGround = "Assets/Images/image (11).jpg",
                MainHeading = "17 - 28 February",
                SubHeading = "Last month",
                ImageNumber = "6"
            });
            daysGrids.Add(new DaysGrid()
            {
                BackGround = "Assets/Images/image (13).jpg",
                MainHeading = "4 February - 16 February",
                SubHeading = "Last month",
                ImageNumber = "4"
            });
            DaysGridView.ItemsSource = daysGrids;
        }

        public class DaysGrid
        {
            public string BackGround { get; set; }
            public string MainHeading { get; set; }
            public string SubHeading { get; set; }
            public string ImageNumber { get; set; }

        }

        private void DaysGridView_Tapped(object sender, TappedRoutedEventArgs e)
        {
            
        }

        private void DaysGridView_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        

        void PrepareAnimationWithItem(DaysGrid daysGrid)
        {
            
        }

        private void test_Click(object sender, RoutedEventArgs e)
        {
            
        }

       

        

    }
}
