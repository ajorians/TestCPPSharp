using System.IO;
using System.Reflection;
using System;
using CppSharp;
using CppSharp.AST;
using CppSharp.Generators;

namespace GenerateBindings
{
   class SampleLibraryGeneration : ILibrary
   {
      public static string AssemblyDirectory
      {
         get
         {
            string codeBase = Assembly.GetExecutingAssembly().Location;
            UriBuilder uri = new UriBuilder(codeBase);
            string path = Uri.UnescapeDataString(uri.Path);
            return Path.GetDirectoryName( path );
         }
      }
      public void Postprocess( Driver driver, ASTContext ctx )
      {
      }
      public void Preprocess( Driver driver, ASTContext ctx )
      {

      }
      public void Setup( Driver driver )
      {
         var options = driver.Options;
         options.GeneratorKind = GeneratorKind.CSharp;

         string assemblyDirectory = AssemblyDirectory;

         string solutionDirectory = Path.GetFullPath( assemblyDirectory + @"..\..\..\..\..\" );

         string outputDirectory = Path.GetFullPath( solutionDirectory + @"x64\Debug" );

         var module = options.AddModule("NativeLibrary");
         module.IncludeDirs.Add( solutionDirectory + @"NativeLibrary\includes" );

         //TODO: Programmatically grab all headers from this include path
         module.Headers.Add( "ExampleClass.h" );

         module.LibraryDirs.Add( outputDirectory );
         module.Libraries.Add( "NativeLibrary.lib" );
      }
      public void SetupPasses( Driver driver )
      {

      }
   }
}
