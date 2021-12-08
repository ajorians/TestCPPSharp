#include "Master.h"

#include "ExampleClass.h"

Master::Master()
   : _exampleClass( new ExampleClass() )
{

}

std::shared_ptr<ExampleClass> Master::GetExampleClass() const
{
   return _exampleClass;
}