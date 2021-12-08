using CppSharp;
using CppSharp.AST;
using CppSharp.Generators;

namespace GenerateBindings
{
   class SampleLibraryGeneration : ILibrary
   {
      public override void Postprocess( Driver driver, ASTContext ctx )
      {
      }
      public override void Preprocess( Driver driver, ASTContext ctx )
      {

      }
      public override void Setup( Driver driver )
      {
         var options = driver.Options;
         options.GeneratorKind = GeneratorKind.CSharp;

         var module = options.AddModule("NativeLibrary");
         module.IncludeDirs.Add( @"C:\git\TestCPPSharp\NativeLibrary\includes" );
         module.IncludeDirs.Add( @"C:\git\TestCPPSharp\ExistingInterop" );

         //TODO: Programmatically grab all headers from this include path
         module.Headers.Add( "IExampleClass.h" );
         module.Headers.Add( "ExampleClass.h" );
         module.Headers.Add( "NewMaster.h" );
         module.Headers.Add( "Sample.h" );

         module.LibraryDirs.Add( @"C:\git\TestCPPSharp\x64\Debug" );
         //module.Libraries.Add( "NativeLibrary.lib" );
         module.Libraries.Add( "ExistingInterop.lib" );

         //module.LibraryName = "ExistingInterop.dll";
         //module.ReferencedAssemblies.Add( "ExistingInterop.dll" );
         module.SharedLibraryName = "ExistingInterop.dll";
      }
      public override void SetupPasses( Driver driver )
      {

      }
   }
}
