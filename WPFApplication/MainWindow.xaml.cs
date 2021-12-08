using System.Windows;

namespace WPFApplication
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      private InteropManager _interopManager = new InteropManager();

      public MainWindow()
      {
         _interopManager.Initialize();

         InitializeComponent();
         DataContext = new VM( _interopManager.GetExampleGate() );
      }
   }
}
