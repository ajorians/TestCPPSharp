#include "ExampleGate.h"

#include <Master.h>
#include <ExampleClass.h>

ExampleGate::ExampleGate( Master* master )
   : _master( master )
{

}

void ExampleGate::DecrementCount()
{
   _master->GetExampleClass()->Decrement();
}

void ExampleGate::IncrementCount()
{
   _master->GetExampleClass()->Increment();
}

int ExampleGate::GetCount()
{
   return _master->GetExampleClass()->GetCount();
}