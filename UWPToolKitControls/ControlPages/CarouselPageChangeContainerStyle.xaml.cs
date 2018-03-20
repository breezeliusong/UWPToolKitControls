using Microsoft.Toolkit.Uwp.UI.Controls;
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

namespace UWPToolKitControls.ControlPages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CarouselPageChangeContainerStyle : Page
    {
        public CarouselPageChangeContainerStyle()
        {
            this.InitializeComponent();
        }

        private void Carousel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
                for (int i = 0; i < Carousel.Items.Count; i++)
                {
                    var item1 = Carousel.ContainerFromIndex(i);
                    var lvi = item1 as CarouselItem;
                    lvi.ContentTemplate = (DataTemplate)this.Resources["ItemWithoutBorder"];
                }
                var item = Carousel.ContainerFromIndex(Carousel.SelectedIndex);
                var _lvi = item as CarouselItem;
                _lvi.ContentTemplate = (DataTemplate)this.Resources["ItemWithBorder"];
        }
    }
}
