namespace RegistrationForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            labelRegistration = new Label();
            labelDate = new Label();
            labelPersonalInformation = new Label();
            labelFormNo = new Label();
            labelFirstName = new Label();
            textBoxFirstName = new TextBox();
            labelMiddleName = new Label();
            textBoxMiddleName = new TextBox();
            labelLastName = new Label();
            textBoxLastName = new TextBox();
            labelDateOfBirth = new Label();
            textBoxDateOfBirth = new TextBox();
            labelPlaceOfBirth = new Label();
            textBoxPlaceOfBirth = new TextBox();
            labelResidenceStatus = new Label();
            checkBoxResidence = new CheckBox();
            checkBoxNonResidence = new CheckBox();
            labelNationality = new Label();
            textBoxNationality = new TextBox();
            labelMartialStatus = new Label();
            checkBoxSingle = new CheckBox();
            checkBoxMarried = new CheckBox();
            labelNationalIdNo = new Label();
            textBoxNationalIdNo = new TextBox();
            labelContactInformation = new Label();
            labelAddress = new Label();
            textBoxAddress = new TextBox();
            labelCity = new Label();
            textBoxCity = new TextBox();
            labelZipCode = new Label();
            textBoxZipCode = new TextBox();
            labelCountry = new Label();
            textBoxCountry = new TextBox();
            labelPhone = new Label();
            textBoxPhone = new TextBox();
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            x = new Panel();
            labelDay = new Label();
            checkBoxWidowed = new CheckBox();
            panel2 = new Panel();
            panel1 = new Panel();
            buttonSave = new Button();
            buttonDatenschutzinformation = new Button();
            buttonNutzungsbedingung = new Button();
            labelDatenschutzinformation = new Label();
            checkBoxNutzungsbedingung = new CheckBox();
            labelNutzungsbedingung = new Label();
            labelServiceInformation = new Label();
            panel3 = new Panel();
            labelFormNumber = new Label();
            labelForm = new Label();
            x.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // labelRegistration
            // 
            labelRegistration.AutoSize = true;
            labelRegistration.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRegistration.ForeColor = SystemColors.HotTrack;
            labelRegistration.Location = new Point(371, 13);
            labelRegistration.Name = "labelRegistration";
            labelRegistration.Size = new Size(234, 41);
            labelRegistration.TabIndex = 1;
            labelRegistration.Text = "REGISTRATION";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(313, 14);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(44, 20);
            labelDate.TabIndex = 4;
            labelDate.Text = "Date:";
            labelDate.Click += labelDate_Click;
            // 
            // labelPersonalInformation
            // 
            labelPersonalInformation.AutoSize = true;
            labelPersonalInformation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPersonalInformation.ForeColor = SystemColors.HotTrack;
            labelPersonalInformation.Location = new Point(23, 14);
            labelPersonalInformation.Name = "labelPersonalInformation";
            labelPersonalInformation.Size = new Size(197, 20);
            labelPersonalInformation.TabIndex = 5;
            labelPersonalInformation.Text = "PERSONAL INFORMATION";
            // 
            // labelFormNo
            // 
            labelFormNo.AutoSize = true;
            labelFormNo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFormNo.ForeColor = SystemColors.HotTrack;
            labelFormNo.Location = new Point(23, 71);
            labelFormNo.Name = "labelFormNo";
            labelFormNo.Size = new Size(0, 20);
            labelFormNo.TabIndex = 6;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(23, 54);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(91, 20);
            labelFirstName.TabIndex = 10;
            labelFirstName.Text = "FIRST NAME";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(168, 54);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(125, 27);
            textBoxFirstName.TabIndex = 11;
            // 
            // labelMiddleName
            // 
            labelMiddleName.AutoSize = true;
            labelMiddleName.Location = new Point(313, 54);
            labelMiddleName.Name = "labelMiddleName";
            labelMiddleName.Size = new Size(109, 20);
            labelMiddleName.TabIndex = 12;
            labelMiddleName.Text = "MIDDLE NAME";
            // 
            // textBoxMiddleName
            // 
            textBoxMiddleName.Location = new Point(436, 54);
            textBoxMiddleName.Name = "textBoxMiddleName";
            textBoxMiddleName.Size = new Size(125, 27);
            textBoxMiddleName.TabIndex = 13;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(23, 85);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(88, 20);
            labelLastName.TabIndex = 14;
            labelLastName.Text = "LAST NAME";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(168, 87);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(125, 27);
            textBoxLastName.TabIndex = 15;
            // 
            // labelDateOfBirth
            // 
            labelDateOfBirth.AutoSize = true;
            labelDateOfBirth.Location = new Point(23, 117);
            labelDateOfBirth.Name = "labelDateOfBirth";
            labelDateOfBirth.Size = new Size(111, 20);
            labelDateOfBirth.TabIndex = 16;
            labelDateOfBirth.Text = "DATE OF BIRTH";
            // 
            // textBoxDateOfBirth
            // 
            textBoxDateOfBirth.Location = new Point(168, 120);
            textBoxDateOfBirth.Name = "textBoxDateOfBirth";
            textBoxDateOfBirth.Size = new Size(125, 27);
            textBoxDateOfBirth.TabIndex = 17;
            // 
            // labelPlaceOfBirth
            // 
            labelPlaceOfBirth.AutoSize = true;
            labelPlaceOfBirth.Location = new Point(313, 117);
            labelPlaceOfBirth.Name = "labelPlaceOfBirth";
            labelPlaceOfBirth.Size = new Size(117, 20);
            labelPlaceOfBirth.TabIndex = 18;
            labelPlaceOfBirth.Text = "PLACE OF BIRTH";
            // 
            // textBoxPlaceOfBirth
            // 
            textBoxPlaceOfBirth.Location = new Point(436, 114);
            textBoxPlaceOfBirth.Name = "textBoxPlaceOfBirth";
            textBoxPlaceOfBirth.Size = new Size(125, 27);
            textBoxPlaceOfBirth.TabIndex = 19;
            // 
            // labelResidenceStatus
            // 
            labelResidenceStatus.AutoSize = true;
            labelResidenceStatus.Location = new Point(23, 190);
            labelResidenceStatus.Name = "labelResidenceStatus";
            labelResidenceStatus.Size = new Size(139, 20);
            labelResidenceStatus.TabIndex = 20;
            labelResidenceStatus.Text = "RESIDENCE STATUS";
            // 
            // checkBoxResidence
            // 
            checkBoxResidence.AutoSize = true;
            checkBoxResidence.Location = new Point(168, 189);
            checkBoxResidence.Name = "checkBoxResidence";
            checkBoxResidence.Size = new Size(98, 24);
            checkBoxResidence.TabIndex = 21;
            checkBoxResidence.Text = "Residence";
            checkBoxResidence.UseVisualStyleBackColor = true;
            // 
            // checkBoxNonResidence
            // 
            checkBoxNonResidence.AutoSize = true;
            checkBoxNonResidence.Location = new Point(313, 188);
            checkBoxNonResidence.Name = "checkBoxNonResidence";
            checkBoxNonResidence.Size = new Size(130, 24);
            checkBoxNonResidence.TabIndex = 22;
            checkBoxNonResidence.Text = "Non Residence";
            checkBoxNonResidence.UseVisualStyleBackColor = true;
            // 
            // labelNationality
            // 
            labelNationality.AutoSize = true;
            labelNationality.Location = new Point(23, 152);
            labelNationality.Name = "labelNationality";
            labelNationality.Size = new Size(100, 20);
            labelNationality.TabIndex = 23;
            labelNationality.Text = "NATIONALITY";
            // 
            // textBoxNationality
            // 
            textBoxNationality.Location = new Point(168, 152);
            textBoxNationality.Name = "textBoxNationality";
            textBoxNationality.Size = new Size(125, 27);
            textBoxNationality.TabIndex = 24;
            // 
            // labelMartialStatus
            // 
            labelMartialStatus.AutoSize = true;
            labelMartialStatus.Location = new Point(23, 222);
            labelMartialStatus.Name = "labelMartialStatus";
            labelMartialStatus.Size = new Size(123, 20);
            labelMartialStatus.TabIndex = 27;
            labelMartialStatus.Text = "MARTIAL STATUS";
            // 
            // checkBoxSingle
            // 
            checkBoxSingle.AutoSize = true;
            checkBoxSingle.Location = new Point(168, 221);
            checkBoxSingle.Name = "checkBoxSingle";
            checkBoxSingle.Size = new Size(72, 24);
            checkBoxSingle.TabIndex = 28;
            checkBoxSingle.Text = "Single";
            checkBoxSingle.UseVisualStyleBackColor = true;
            // 
            // checkBoxMarried
            // 
            checkBoxMarried.AutoSize = true;
            checkBoxMarried.Location = new Point(313, 221);
            checkBoxMarried.Name = "checkBoxMarried";
            checkBoxMarried.Size = new Size(83, 24);
            checkBoxMarried.TabIndex = 29;
            checkBoxMarried.Text = "Married";
            checkBoxMarried.UseVisualStyleBackColor = true;
            // 
            // labelNationalIdNo
            // 
            labelNationalIdNo.AutoSize = true;
            labelNationalIdNo.Location = new Point(22, 254);
            labelNationalIdNo.Name = "labelNationalIdNo";
            labelNationalIdNo.Size = new Size(125, 20);
            labelNationalIdNo.TabIndex = 30;
            labelNationalIdNo.Text = "NATIONAL ID NO";
            // 
            // textBoxNationalIdNo
            // 
            textBoxNationalIdNo.Location = new Point(168, 251);
            textBoxNationalIdNo.Name = "textBoxNationalIdNo";
            textBoxNationalIdNo.Size = new Size(125, 27);
            textBoxNationalIdNo.TabIndex = 31;
            textBoxNationalIdNo.TextChanged += textBoxNationalIdNo_TextChanged;
            // 
            // labelContactInformation
            // 
            labelContactInformation.AutoSize = true;
            labelContactInformation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelContactInformation.ForeColor = SystemColors.HotTrack;
            labelContactInformation.Location = new Point(23, 16);
            labelContactInformation.Name = "labelContactInformation";
            labelContactInformation.Size = new Size(189, 20);
            labelContactInformation.TabIndex = 32;
            labelContactInformation.Text = "CONTACT INFORMATION";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(23, 56);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(74, 20);
            labelAddress.TabIndex = 33;
            labelAddress.Text = "ADDRESS";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(168, 53);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(396, 27);
            textBoxAddress.TabIndex = 34;
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Location = new Point(23, 123);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(38, 20);
            labelCity.TabIndex = 35;
            labelCity.Text = "CITY";
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(168, 120);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(125, 27);
            textBoxCity.TabIndex = 36;
            // 
            // labelZipCode
            // 
            labelZipCode.AutoSize = true;
            labelZipCode.Location = new Point(23, 89);
            labelZipCode.Name = "labelZipCode";
            labelZipCode.Size = new Size(73, 20);
            labelZipCode.TabIndex = 39;
            labelZipCode.Text = "ZIP CODE";
            labelZipCode.Click += labelZipCode_Click;
            // 
            // textBoxZipCode
            // 
            textBoxZipCode.Location = new Point(168, 86);
            textBoxZipCode.Name = "textBoxZipCode";
            textBoxZipCode.Size = new Size(125, 27);
            textBoxZipCode.TabIndex = 40;
            // 
            // labelCountry
            // 
            labelCountry.AutoSize = true;
            labelCountry.Location = new Point(23, 156);
            labelCountry.Name = "labelCountry";
            labelCountry.Size = new Size(75, 20);
            labelCountry.TabIndex = 41;
            labelCountry.Text = "COUNTRY";
            labelCountry.Click += labelCountry_Click;
            // 
            // textBoxCountry
            // 
            textBoxCountry.Location = new Point(168, 153);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.Size = new Size(125, 27);
            textBoxCountry.TabIndex = 42;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(23, 189);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(58, 20);
            labelPhone.TabIndex = 43;
            labelPhone.Text = "PHONE";
            labelPhone.Click += labelPhone_Click;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(168, 186);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(125, 27);
            textBoxPhone.TabIndex = 44;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(23, 222);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(51, 20);
            labelEmail.TabIndex = 45;
            labelEmail.Text = "EMAIL";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(168, 219);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(262, 27);
            textBoxEmail.TabIndex = 46;
            // 
            // x
            // 
            x.Controls.Add(labelDay);
            x.Controls.Add(checkBoxWidowed);
            x.Controls.Add(labelPersonalInformation);
            x.Controls.Add(labelDate);
            x.Controls.Add(labelFirstName);
            x.Controls.Add(textBoxFirstName);
            x.Controls.Add(labelMiddleName);
            x.Controls.Add(textBoxMiddleName);
            x.Controls.Add(labelLastName);
            x.Controls.Add(textBoxLastName);
            x.Controls.Add(labelDateOfBirth);
            x.Controls.Add(textBoxDateOfBirth);
            x.Controls.Add(labelPlaceOfBirth);
            x.Controls.Add(textBoxNationalIdNo);
            x.Controls.Add(textBoxPlaceOfBirth);
            x.Controls.Add(labelNationalIdNo);
            x.Controls.Add(labelResidenceStatus);
            x.Controls.Add(checkBoxMarried);
            x.Controls.Add(checkBoxResidence);
            x.Controls.Add(checkBoxSingle);
            x.Controls.Add(checkBoxNonResidence);
            x.Controls.Add(labelMartialStatus);
            x.Controls.Add(labelNationality);
            x.Controls.Add(textBoxNationality);
            x.Location = new Point(3, 120);
            x.Name = "x";
            x.Size = new Size(652, 303);
            x.TabIndex = 50;
            // 
            // labelDay
            // 
            labelDay.AutoSize = true;
            labelDay.Location = new Point(436, 14);
            labelDay.Name = "labelDay";
            labelDay.Size = new Size(85, 20);
            labelDay.TabIndex = 51;
            labelDay.Text = "18/08/2025";
            // 
            // checkBoxWidowed
            // 
            checkBoxWidowed.AutoSize = true;
            checkBoxWidowed.Location = new Point(466, 221);
            checkBoxWidowed.Name = "checkBoxWidowed";
            checkBoxWidowed.Size = new Size(95, 24);
            checkBoxWidowed.TabIndex = 50;
            checkBoxWidowed.Text = "Widowed";
            checkBoxWidowed.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelContactInformation);
            panel2.Controls.Add(labelAddress);
            panel2.Controls.Add(textBoxEmail);
            panel2.Controls.Add(textBoxAddress);
            panel2.Controls.Add(labelEmail);
            panel2.Controls.Add(textBoxPhone);
            panel2.Controls.Add(labelCity);
            panel2.Controls.Add(textBoxCity);
            panel2.Controls.Add(labelPhone);
            panel2.Controls.Add(textBoxCountry);
            panel2.Controls.Add(labelCountry);
            panel2.Controls.Add(labelZipCode);
            panel2.Controls.Add(textBoxZipCode);
            panel2.Location = new Point(3, 429);
            panel2.Name = "panel2";
            panel2.Size = new Size(652, 261);
            panel2.TabIndex = 51;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonDatenschutzinformation);
            panel1.Controls.Add(buttonNutzungsbedingung);
            panel1.Controls.Add(labelDatenschutzinformation);
            panel1.Controls.Add(checkBoxNutzungsbedingung);
            panel1.Controls.Add(labelNutzungsbedingung);
            panel1.Controls.Add(labelServiceInformation);
            panel1.Location = new Point(3, 696);
            panel1.Name = "panel1";
            panel1.Size = new Size(652, 166);
            panel1.TabIndex = 52;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(436, 128);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 7;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDatenschutzinformation
            // 
            buttonDatenschutzinformation.Location = new Point(168, 89);
            buttonDatenschutzinformation.Name = "buttonDatenschutzinformation";
            buttonDatenschutzinformation.Size = new Size(94, 29);
            buttonDatenschutzinformation.TabIndex = 6;
            buttonDatenschutzinformation.Text = "button2";
            buttonDatenschutzinformation.UseVisualStyleBackColor = true;
            // 
            // buttonNutzungsbedingung
            // 
            buttonNutzungsbedingung.Location = new Point(168, 54);
            buttonNutzungsbedingung.Name = "buttonNutzungsbedingung";
            buttonNutzungsbedingung.Size = new Size(94, 29);
            buttonNutzungsbedingung.TabIndex = 5;
            buttonNutzungsbedingung.Text = "button1";
            buttonNutzungsbedingung.UseVisualStyleBackColor = true;
            // 
            // labelDatenschutzinformation
            // 
            labelDatenschutzinformation.AutoSize = true;
            labelDatenschutzinformation.Location = new Point(23, 93);
            labelDatenschutzinformation.Name = "labelDatenschutzinformation";
            labelDatenschutzinformation.Size = new Size(97, 20);
            labelDatenschutzinformation.TabIndex = 4;
            labelDatenschutzinformation.Text = "Privacy Policy";
            // 
            // checkBoxNutzungsbedingung
            // 
            checkBoxNutzungsbedingung.AutoSize = true;
            checkBoxNutzungsbedingung.ForeColor = Color.Red;
            checkBoxNutzungsbedingung.Location = new Point(268, 94);
            checkBoxNutzungsbedingung.Name = "checkBoxNutzungsbedingung";
            checkBoxNutzungsbedingung.Size = new Size(37, 24);
            checkBoxNutzungsbedingung.TabIndex = 3;
            checkBoxNutzungsbedingung.Text = "*";
            checkBoxNutzungsbedingung.UseVisualStyleBackColor = true;
            // 
            // labelNutzungsbedingung
            // 
            labelNutzungsbedingung.AutoSize = true;
            labelNutzungsbedingung.Location = new Point(23, 58);
            labelNutzungsbedingung.Name = "labelNutzungsbedingung";
            labelNutzungsbedingung.Size = new Size(117, 20);
            labelNutzungsbedingung.TabIndex = 1;
            labelNutzungsbedingung.Text = "Terms of Service";
            // 
            // labelServiceInformation
            // 
            labelServiceInformation.AutoSize = true;
            labelServiceInformation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelServiceInformation.ForeColor = SystemColors.HotTrack;
            labelServiceInformation.Location = new Point(23, 25);
            labelServiceInformation.Name = "labelServiceInformation";
            labelServiceInformation.Size = new Size(178, 20);
            labelServiceInformation.TabIndex = 0;
            labelServiceInformation.Text = "SERVICE INFORMATION";
            // 
            // panel3
            // 
            panel3.Controls.Add(labelFormNumber);
            panel3.Controls.Add(labelForm);
            panel3.Controls.Add(labelRegistration);
            panel3.Controls.Add(labelFormNo);
            panel3.Location = new Point(3, 9);
            panel3.Name = "panel3";
            panel3.Size = new Size(652, 105);
            panel3.TabIndex = 53;
            // 
            // labelFormNumber
            // 
            labelFormNumber.AutoSize = true;
            labelFormNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFormNumber.ForeColor = SystemColors.HotTrack;
            labelFormNumber.Location = new Point(23, 71);
            labelFormNumber.Name = "labelFormNumber";
            labelFormNumber.Size = new Size(0, 20);
            labelFormNumber.TabIndex = 7;
            // 
            // labelForm
            // 
            labelForm.AutoSize = true;
            labelForm.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelForm.ForeColor = SystemColors.HotTrack;
            labelForm.Location = new Point(498, 54);
            labelForm.Name = "labelForm";
            labelForm.Size = new Size(106, 41);
            labelForm.TabIndex = 2;
            labelForm.Text = "FORM";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(658, 865);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(x);
            Name = "Form1";
            Text = "Names";
            x.ResumeLayout(false);
            x.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        private string GenerateFromNumber() {
            Random random = new Random();
            String randomNumber = random.Next(0, 100000).ToString("D6");
            return randomNumber;
        }

        #endregion
        private Label labelRegistration;
        private Label labelDate;
        private Label labelPersonalInformation;
        private Label labelFormNo;
        private Label labelFirstName;
        private TextBox textBoxFirstName;
        private Label labelMiddleName;
        private TextBox textBoxMiddleName;
        private Label labelLastName;
        private TextBox textBoxLastName;
        private Label labelDateOfBirth;
        private TextBox textBoxDateOfBirth;
        private Label labelPlaceOfBirth;
        private TextBox textBoxPlaceOfBirth;
        private Label labelResidenceStatus;
        private CheckBox checkBoxResidence;
        private CheckBox checkBoxNonResidence;
        private Label labelNationality;
        private TextBox textBoxNationality;
        private Label labelMartialStatus;
        private CheckBox checkBoxSingle;
        private CheckBox checkBoxMarried;
        private Label labelNationalIdNo;
        private TextBox textBoxNationalIdNo;
        private Label labelContactInformation;
        private Label labelAddress;
        private TextBox textBoxAddress;
        private Label labelCity;
        private TextBox textBoxCity;
        private Label labelZipCode;
        private TextBox textBoxZipCode;
        private Label labelCountry;
        private TextBox textBoxCountry;
        private Label labelPhone;
        private TextBox textBoxPhone;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private Panel x;
        private CheckBox checkBoxWidowed;
        private Panel panel2;
        private Panel panel1;
        private Label labelNutzungsbedingung;
        private Label labelServiceInformation;
        private Button buttonSave;
        private Button buttonDatenschutzinformation;
        private Button buttonNutzungsbedingung;
        private Label labelDatenschutzinformation;
        private CheckBox checkBoxNutzungsbedingung;
        private Panel panel3;
        private Label labelForm;
        private Label labelFormNumber;
        private Label labelDay;
    }
}
