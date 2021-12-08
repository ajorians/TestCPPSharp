#include "Master.h"

#include "ExampleClass.h"

Master* g_Master = nullptr;

Master::Master()
   : _exampleClass( new ExampleClass() )
{
   g_Master = this;
}

std::shared_ptr<ExampleClass> Master::GetExampleClass() const
{
   return _exampleClass;
}