using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public sealed partial class MasterDetailsView : Page
    {
        public MasterDetailsView()
        {
            this.InitializeComponent();
            fooList = new ObservableCollection<Foo>();
            fooList.Add(new Foo { Brush = new SolidColorBrush(Colors.Red) });

            fooList.Add(new Foo { Brush = new SolidColorBrush(Colors.Green) });
            fooList.Add(new Foo { Brush = new SolidColorBrush(Colors.Blue) });
            //this.DataContext = fooList;
            this.Loaded += MasterDetailsView_Loaded;
           
        }

        private void MasterDetailsView_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

        public ObservableCollection<Foo> fooList { get; set; }

        private void MasterDetailsViewControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i < MasterDetailsViewControl.Items.Count; i++)
            {

                var item = MasterDetailsViewControl.ContainerFromIndex(i);
                //item.Background = fooList[i].Brush;
            }
        }
    }

    public class Foo
    {
        public SolidColorBrush Brush { get; set; }
    }
}
