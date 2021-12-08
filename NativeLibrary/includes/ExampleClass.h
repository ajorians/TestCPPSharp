#pragma once

class ExampleClass
{
public:
   void Increment();
   void Decrement();
   int GetCount() const;

private:
   int _count = 0;
};