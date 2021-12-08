#include "ExampleClass.h"

void ExampleClass::Increment()
{
   _count++;
}

void ExampleClass::Decrement()
{
   _count--;
}

int ExampleClass::GetCount() const
{
   return _count;
}