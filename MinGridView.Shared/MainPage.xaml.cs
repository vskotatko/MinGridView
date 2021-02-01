using System.Collections.ObjectModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MinGridView
{
  /// <summary>
  /// An empty page that can be used on its own or navigated to within a Frame.
  /// </summary>
  public sealed partial class MainPage : Page
  {
    public class Pic
    {
      public string FileName { get; set; }
    }
    public ObservableCollection<Pic> DetailGridItems = new ObservableCollection<Pic>();
    public MainPage ()
    {
      this.InitializeComponent();

      DetailGridItems.Add(new Pic
      {
        FileName = "ms-appx:///Assets/pictures/beach.jpg",
      });
      DetailGridItems.Add(new Pic
      {
        FileName = "ms-appx:///Assets/pictures/covid_wedding.jpg",
      });
      DetailGridItems.Add(new Pic
      {
        FileName = "ms-appx:///Assets/pictures/image_chair_pk.jpg",
      });
      DetailGridItems.Add(new Pic
      {
        FileName = "ms-appx:///Assets/pictures/image_chanty.jpg",
      });
      DetailGridItems.Add(new Pic
      {
        FileName = "ms-appx:///Assets/pictures/sidekick.png",
      });
      DetailGridItems.Add(new Pic
      {
        FileName = "ms-appx:///Assets/pictures/smoke.jpg",
      });
    }

    //-----------------------------------------------------------------------------
    private void OnSizeChanged(object sender, SizeChangedEventArgs e)
    {
      GridView gridView = (GridView)sender;
      ItemsWrapGrid panel = ((ItemsWrapGrid)gridView.ItemsPanelRoot);

      const int minColWidth = 250;
      var columns = System.Math.Ceiling(ActualWidth / minColWidth);
      double newWidth = e.NewSize.Width / columns;
      panel.ItemWidth = newWidth;
      panel.ItemHeight = newWidth;
    }
  }
}
