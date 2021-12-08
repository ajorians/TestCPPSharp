using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using NativeLibrary;

namespace WpfCoreApplication
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
