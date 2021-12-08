#pragma once

#include <ExportAPI.h>

class EXPORT_API Foo
{
public:

   int a;
   float b;
};

EXPORT_API int FooAdd( Foo* foo );