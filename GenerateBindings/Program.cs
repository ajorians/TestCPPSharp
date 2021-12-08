using CppSharp;

namespace GenerateBindings
{
   class Program
   {
      static void Main( string[] args )
      {
         ConsoleDriver.Run( new SampleLibraryGeneration() );
      }
   }
}
