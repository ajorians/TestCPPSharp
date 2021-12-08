using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using NativeLibrary;

namespace WPFApplication
{
   public class VM : INotifyPropertyChanged
   {
      public event PropertyChangedEventHandler PropertyChanged;

      private readonly ICommand _decrementClicked;
      private readonly ICommand _incrementClicked;
      private readonly ExampleClass _exampleClass;

      public VM( ExampleClass exampleClass )
      {
         _exampleClass = exampleClass ?? throw new ArgumentNullException( nameof( exampleClass ) );

         _decrementClicked = new RelayCommand( () =>
         {
            _exampleClass.Decrement();
            PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( nameof( CountStr ) ) );
         } );
         _incrementClicked = new RelayCommand( () =>
         {
            _exampleClass.Increment();
            PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( nameof( CountStr ) ) );
         } );
      }
      public ICommand DecrementClicked => _decrementClicked;
      public ICommand IncrementClicked => _incrementClicked;
      public int Count
      {
         get => _exampleClass.Count;
      }

      public string CountStr => Count.ToString();
   }
}
