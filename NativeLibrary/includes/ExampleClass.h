#pragma once

#include "ExportAPI.h"

class EXPORT_API ExampleClass
{
public:
   ExampleClass();

   void Increment();
   void Decrement();
   int GetCount() const;

private:
   int _count = 0;
};