#include "ExampleClass.h"

ExampleClass::ExampleClass()
{

}

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