#pragma once

namespace CTutorial01MoveServo {

  using namespace System;
  using namespace System::ComponentModel;
  using namespace System::Collections;
  using namespace System::Windows::Forms;
  using namespace System::Data;
  using namespace System::Drawing;
  using namespace EZ_B;

  /// <summary>
  /// Summary for FormMain
  /// </summary>
  public ref class FormMain : public System::Windows::Forms::Form {
  public:
    FormMain(void) {
      InitializeComponent();
      //
      //TODO: Add the constructor code here
      //
    }

  protected:
    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    ~FormMain() {
      if (components) {
        delete components;
      }
    }
  public: EZ_B::UCEZB_Connect^  ezB_Connect1;
  private: System::Windows::Forms::ComboBox^  comboBox1;
  public:
  private: System::Windows::Forms::TrackBar^  trackBar1;
  protected:

  protected:
  private: System::ComponentModel::IContainer^  components;

  private:
    /// <summary>
    /// Required designer variable.
    /// </summary>


#pragma region Windows Form Designer generated code
    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    void InitializeComponent(void) {
      this->components = (gcnew System::ComponentModel::Container());
      this->ezB_Connect1 = (gcnew EZ_B::UCEZB_Connect());
      this->comboBox1 = (gcnew System::Windows::Forms::ComboBox());
      this->trackBar1 = (gcnew System::Windows::Forms::TrackBar());
      (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->trackBar1))->BeginInit();
      this->SuspendLayout();
      // 
      // ezB_Connect1
      // 
      this->ezB_Connect1->Location = System::Drawing::Point(12, 12);
      this->ezB_Connect1->Name = L"ezB_Connect1";
      this->ezB_Connect1->Port = L"COM7";
      this->ezB_Connect1->ShowDebugButton = true;
      this->ezB_Connect1->Size = System::Drawing::Size(283, 31);
      this->ezB_Connect1->TabIndex = 0;
      this->ezB_Connect1->TCPPassword = nullptr;
      // 
      // comboBox1
      // 
      this->comboBox1->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(224)), static_cast<System::Int32>(static_cast<System::Byte>(224)),
                                                                    static_cast<System::Int32>(static_cast<System::Byte>(224)));
      this->comboBox1->DropDownStyle = System::Windows::Forms::ComboBoxStyle::DropDownList;
      this->comboBox1->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
      this->comboBox1->FormattingEnabled = true;
      this->comboBox1->Location = System::Drawing::Point(4, 66);
      this->comboBox1->Name = L"comboBox1";
      this->comboBox1->Size = System::Drawing::Size(121, 21);
      this->comboBox1->TabIndex = 1;
      // 
      // trackBar1
      // 
      this->trackBar1->Location = System::Drawing::Point(4, 93);
      this->trackBar1->Name = L"trackBar1";
      this->trackBar1->Size = System::Drawing::Size(303, 45);
      this->trackBar1->TabIndex = 2;
      this->trackBar1->Scroll += gcnew System::EventHandler(this, &FormMain::trackBar1_Scroll);
      // 
      // FormMain
      // 
      this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
      this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
      this->BackColor = System::Drawing::Color::White;
      this->ClientSize = System::Drawing::Size(311, 294);
      this->Controls->Add(this->trackBar1);
      this->Controls->Add(this->comboBox1);
      this->Controls->Add(this->ezB_Connect1);
      this->Name = L"FormMain";
      this->Text = L"FormMain";
      this->Load += gcnew System::EventHandler(this, &FormMain::FormMain_Load);
      (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->trackBar1))->EndInit();
      this->ResumeLayout(false);
      this->PerformLayout();

    }
#pragma endregion

  private: System::Void FormMain_Load(System::Object^  sender, System::EventArgs^  e) {

    comboBox1->Items->Clear();

    for each(Servo::ServoPortEnum item in Enum::GetValues(Servo::ServoPortEnum::typeid))
      comboBox1->Items->Add(item);
  }

  private: System::Void ezB_Connect1_OnConnection() {

    trackBar1->Minimum = ezB_Connect1->EZB->Servo->SERVO_MIN;
    trackBar1->Maximum = ezB_Connect1->EZB->Servo->SERVO_MAX;
    trackBar1->Value = ezB_Connect1->EZB->Servo->SERVO_MIN;
  }

  private: System::Void trackBar1_Scroll(System::Object^  sender, System::EventArgs^  e) {

    if (comboBox1->SelectedIndex == -1)
      return;

    ezB_Connect1->EZB->Servo->SetServoPosition((Servo::ServoPortEnum)comboBox1->SelectedItem, trackBar1->Value);
  }
};
}
