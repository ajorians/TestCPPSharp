#pragma once

#include <memory>

class ExampleClass;

class Master
{
public:
   Master();

   std::shared_ptr<ExampleClass> GetExampleClass() const;

private:
   std::shared_ptr<ExampleClass> _exampleClass;
};