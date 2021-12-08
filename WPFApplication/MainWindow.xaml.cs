using System.Windows;
using NativeLibrary;

namespace WPFApplication
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      private InteropManager _interopManager = new InteropManager();
      private NewMaster _newMaster = new NewMaster();

      public MainWindow()
      {
         _interopManager.Initialize();

         InitializeComponent();
         DataContext = new VM( _interopManager.GetExampleGate(), _newMaster.RawExampleClass );
      }
   }
}
