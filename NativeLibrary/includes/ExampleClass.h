#pragma once

#include "ExportAPI.h"
#include "IExampleClass.h"

class EXPORT_API ExampleClass : public IExampleClass
{
public:
   ExampleClass();

   void Increment() override;
   void Decrement() override;
   int GetCount() const override;

private:
   int _count = 0;
};