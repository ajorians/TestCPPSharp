using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using InteropDependencies;
using NativeLibrary;

namespace WpfCoreApplication
{
   public class VM : INotifyPropertyChanged
   {
      public event PropertyChangedEventHandler PropertyChanged;

      private readonly ICommand _decrementClicked;
      private readonly ICommand _incrementClicked;
      private readonly IExampleGate _exampleGate;
      private readonly ExampleClass _exampleClass;

      public VM( IExampleGate exampleGate, ExampleClass exampleClass )
      {
         _exampleGate = exampleGate ?? throw new ArgumentNullException( nameof( exampleGate ) );
         _exampleClass = exampleClass ?? throw new ArgumentNullException( nameof( exampleClass ) );

         _decrementClicked = new RelayCommand( () =>
         {
            _exampleGate.DecrementCount();
            PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( nameof( CountStr ) ) );
         } );
         _incrementClicked = new RelayCommand( () =>
         {
            //_exampleGate.IncrementCount();
            _exampleClass.Increment();
            PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( nameof( CountStr ) ) );
         } );
      }
      public ICommand DecrementClicked => _decrementClicked;
      public ICommand IncrementClicked => _incrementClicked;
      public int Count
      {
         get => _exampleGate.GetCount();
      }

      public string CountStr => Count.ToString();
   }
}
