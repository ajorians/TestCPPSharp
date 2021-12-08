#include "InteropManager.h"

#include "ExampleGate.h"

#include <Master.h>

InteropManager::InteropManager()
{

}

InteropManager::~InteropManager()
{
   if( _isDisposed )
      return;

   // dispose managed data here
   this->!InteropManager(); // call finalizer
   _isDisposed = true;
}

InteropManager::!InteropManager()
{
   // free unmanaged data here
   delete _master;
}

void InteropManager::Initialize()
{
   _master = new Master();

   _exampleGate = gcnew ExampleGate( _master );
}

InteropDependencies::IExampleGate^ InteropManager::GetExampleGate()
{
   return _exampleGate;
}