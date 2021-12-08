#pragma once

class Master;

public ref class ExampleGate : public InteropDependencies::IExampleGate
{
public:
   ExampleGate( Master* master );

   virtual void DecrementCount(); /*override*/
   virtual void IncrementCount(); /*override*/
   virtual int GetCount(); /*override*/

private:
   Master* _master;
};