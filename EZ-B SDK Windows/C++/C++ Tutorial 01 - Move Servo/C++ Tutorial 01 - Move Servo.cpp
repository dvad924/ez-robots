#include "stdafx.h"
#include "FormMain.h"

using namespace System;
using namespace System::Windows::Forms;

[STAThreadAttribute]
int main(array<System::String ^> ^args) {

  Application::EnableVisualStyles();
  Application::SetCompatibleTextRenderingDefault(false); 
  Application::Run(gcnew CTutorial01MoveServo::FormMain());

  return 0;
}
