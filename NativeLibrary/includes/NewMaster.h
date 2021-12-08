#pragma once

#include "ExportAPI.h"

#include <memory>

class ExampleClass;

class EXPORT_API NewMaster
{
public:
   int GetTest() const;
   std::shared_ptr<ExampleClass> GetExampleClass() const;
   ExampleClass* GetRawExampleClass() const;
};
