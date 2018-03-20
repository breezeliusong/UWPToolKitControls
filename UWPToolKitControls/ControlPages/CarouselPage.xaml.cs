using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPToolKitControls.ControlPages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CarouselPage : Page
    {
        public CarouselPage()
        {
            this.InitializeComponent();
            this.Loaded += MainPage_Loaded;
            OperateItems = new List<Bilder>();
        }



        List<Bilder> OperateItems;

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            //these two lines code could be deleted if you don't set the default selected item
            Carousel.SelectedIndex = 0;
            ((Bilder)Carousel.SelectedItem).BorderColor = new SolidColorBrush(Colors.Gray);
        }

        private void Carousel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            OperateItems.Clear();
            foreach (Bilder item in e.AddedItems)
            {
                OperateItems.Add(item);
            }
            foreach (Bilder item in e.RemovedItems)
            {
                OperateItems.Add(item);
            }

            foreach (Bilder item in Carousel.Items)
            {
                if (OperateItems.Contains(item))
                {
                    item.BorderColor = new SolidColorBrush(Colors.Gray);
                }
                else
                {
                    item.BorderColor = new SolidColorBrush(Colors.Transparent);
                }
            }
        }

        private void Carousel_ManipulationStarted(object sender, ManipulationStartedRoutedEventArgs e)
        {

        }

        private void Carousel_PointerPressed(object sender, PointerRoutedEventArgs e)
        {

        }

    }

    public class ViewModel
    {
        public ObservableCollection<Bilder> list { get; set; }
        public ViewModel()
        {
            list = new ObservableCollection<Bilder>();
            list.Add(new Bilder() { Bild = "ms-appx:///Assets/Image.png" });
            list.Add(new Bilder() { Bild = "ms-appx:///Assets/Image.png" });
            list.Add(new Bilder() { Bild = "ms-appx:///Assets/Image.png" });
            list.Add(new Bilder() { Bild = "ms-appx:///Assets/Image.png" });
            list.Add(new Bilder() { Bild = "ms-appx:///Assets/Image.png" });
            list.Add(new Bilder() { Bild = "ms-appx:///Assets/Image.png" });
        }
    }

    public class Bilder : INotifyPropertyChanged
    {
        public string Bild { get; set; }
        private SolidColorBrush borderBrush;
        public SolidColorBrush BorderColor
        {
            get { return borderBrush; }
            set
            {
                borderBrush = value;
                OnPropertyChanged(nameof(BorderColor));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }

}
