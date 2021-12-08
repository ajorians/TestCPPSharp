#include "NewMaster.h"
#include "Master.h"

#include <cassert>

extern Master* g_Master;//Master was created; and this wants to reference the same Master.
// This is how I did it.

int NewMaster::GetTest() const
{
   return 43;
}

std::shared_ptr<ExampleClass> NewMaster::GetExampleClass() const
{
   assert( g_Master );
   return g_Master->GetExampleClass();
}

ExampleClass* NewMaster::GetRawExampleClass() const
{
   assert( g_Master );
   auto exampleClass = g_Master->GetExampleClass();
   return exampleClass.get();
}