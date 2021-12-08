using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using InteropDependencies;

namespace WPFApplication
{
   public class VM : INotifyPropertyChanged
   {
      public event PropertyChangedEventHandler PropertyChanged;

      private ICommand _decrementClicked;
      private ICommand _incrementClicked;
      private IExampleGate _exampleGate;

      public VM( IExampleGate exampleGate )
      {
         _exampleGate = exampleGate ?? throw new ArgumentNullException( nameof( exampleGate ) );

         _decrementClicked = new RelayCommand( () =>
         {
            _exampleGate.DecrementCount();
            PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( nameof( CountStr ) ) );
         } );
         _incrementClicked = new RelayCommand( () =>
         {
            _exampleGate.IncrementCount();
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
