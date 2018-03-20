using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWPToolKitControls.ControlPages;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPToolKitControls
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            PageCollection = new ObservableCollection<Page>();
            PageCollection.Add(new MasterDetailsView() { Name=nameof(MasterDetailsView) });
            PageCollection.Add(new CarouselPage() { Name = nameof(CarouselPage) });
            PageCollection.Add(new CarouselPageChangeContainerStyle() { Name = nameof(CarouselPageChangeContainerStyle) });

        }

        ObservableCollection<Page> PageCollection;

        private void PageListLB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var listBox=sender as ListBox;
            var selectPage = listBox.SelectedItem.GetType();
            ContentFrame.Navigate(selectPage);
        }
    }


}
