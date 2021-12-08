#pragma once

class Master;

public ref class InteropManager
{
public:
   InteropManager();
   ~InteropManager();
   !InteropManager();

   void Initialize();//Creates the native side and the gates

   InteropDependencies::IExampleGate^ GetExampleGate();

private:
   bool _isDisposed = false;

   Master* _master;

   InteropDependencies::IExampleGate^ _exampleGate;
};