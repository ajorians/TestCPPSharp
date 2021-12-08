#pragma once

#include "ExportAPI.h"

class EXPORT_API IExampleClass
{
public:
   virtual ~IExampleClass() = default;

   virtual void Increment() = 0;
   virtual void Decrement() = 0;
   virtual int GetCount() const = 0;
};