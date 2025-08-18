using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace RegistrationForm
{
    public partial class Form1 : Form {

        private ErrorProvider errorProvider = new ErrorProvider();

        public Form1() {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e) {
            if (!IsAComponentEmpty()) {
            }

        }

        private bool IsAComponentEmpty() {
            if (!ValidateTextBox(textBoxFirstName) ||
                !ValidateTextBox(textBoxMiddleName) ||
                !ValidateTextBox(textBoxLastName) ||
                !ValidateTextBox(textBoxPlaceOfBirth) ||
                !ValidateTextBox(textBoxNationality) ||
                !ValidateTextBox(textBoxAddress) ||
                !ValidateTextBox(textBoxCity) ||
                !ValidateTextBox(textBoxZipCode) ||
                !ValidateTextBox(textBoxCountry) ||
                !ValidateTextBox(textBoxPhone) ||
                !ValidateTextBox(textBoxEmail)) {
                return false;
            }
            if (!ValidateTextBoxDateOfBirth()) {
                return false;
            } else if (!ValidateNationalIdNumber()) {
                return false;
            } else if (!ValidateAddress()) {
                return false;
            } else if (!ValidateCity()) {
                return false;
            } else if (!ValidatePhone()) {
                return false;
            } else if (!ValidateCountry()) {
                return false;
            } else if (!ValidateEmail()) {
                return false;
            } else if (!ValidateNationality()) {
                return false;
            }

            return true;
        }

        private bool ValidateTextBox(TextBox textBox) {
            if (string.IsNullOrEmpty(textBox.Text)) {
                errorProvider.SetError(textBox, "This field can´t be blank.");
                return false;
            } else {
                errorProvider.SetError(textBox, "");
                return true;
            }
        }

        private bool ValidateTextBoxName(TextBox textBox) {
            if (new Regex(@"[A-Za-z").IsMatch(textBox.Text)) {
                return true;
            }
            return false;
        }
        private bool ValidateTextBoxDateOfBirth() {
            String date = textBoxDateOfBirth.Text;
            var formats = new[] { "dd/MM/yyyy", "d/MM/yyyy", "d/M/yyyy", "dd/M/yyyy", "dd/MM/yy", "d/M/yy" };

            return DateTime.TryParseExact(textBoxDateOfBirth.Text,
                                            formats,
                                            CultureInfo.InvariantCulture,
                                            DateTimeStyles.None,
                                            out _
                                            );
        }

        private bool ValidateNationalIdNumber() {
            String nationalIdNumber = textBoxNationalIdNo.Text;
            String pattern = @"[A-Za-z]{1,3}?[0-9]{6,8}";

            if (Regex.IsMatch(nationalIdNumber, pattern)) {
                return true;
            }
            errorProvider.SetError(textBoxNationalIdNo, "Format mus be 1- 3 Letter[optional] + 6 - 8 Digits");
            return false;
        }

        private bool ValidateAddress() {
            String address = textBoxAddress.Text;
            String pattern = @"[A-Za-z0-9 .ß/-]";

            if (Regex.IsMatch(address, pattern)) {
                return true;
            }
            errorProvider.SetError(textBoxAddress, "Only Letter A - Z, Digits and -, /, . are allowed");
            return false;
        }

        private bool ValidateCity() {
            String city = textBoxCity.Text;
            String pattern = @"^[A-Za-zß./\s\-]+$";

            if (Regex.IsMatch(city, pattern)) {
                return true;
            }
            errorProvider.SetError(textBoxCity, "Only Letter A - Z and -, /, . are allowed");
            return false;
        }

        private bool ValidatePhone() {
            String phone = textBoxPhone.Text;
            String pattern = @"^[0-9]{4}[- ]?[0-9]{3}[- ]?[0-9]{3}$";

            if (Regex.IsMatch(phone, pattern)) {
                return true;
            }
            errorProvider.SetError(textBoxPhone, "Only Formats like '+43664987654', '0664987654' are allowed");
            return false;
        }

        private bool ValidateCountry() {
            String country = textBoxCountry.Text;
            var countries = new[] { "United States", "Canada", "Afghanistan", "Albania", "Algeria", "American Samoa", "Andorra", "Angola", "Anguilla", "Antarctica", "Antigua and/or Barbuda", "Argentina", "Armenia", "Aruba", "Australia", "Austria", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bermuda", "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Bouvet Island", "Brazil", "British Indian Ocean Territory", "Brunei Darussalam", "Bulgaria", "Burkina Faso", "Burundi", "Cambodia", "Cameroon", "Cape Verde", "Cayman Islands", "Central African Republic", "Chad", "Chile", "China", "Christmas Island", "Cocos (Keeling) Islands", "Colombia", "Comoros", "Congo", "Cook Islands", "Costa Rica", "Croatia (Hrvatska)", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "East Timor", "Ecudaor", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Falkland Islands (Malvinas)", "Faroe Islands", "Fiji", "Finland", "France", "France, Metropolitan", "French Guiana", "French Polynesia", "French Southern Territories", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Gibraltar", "Greece", "Greenland", "Grenada", "Guadeloupe", "Guam", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Heard and Mc Donald Islands", "Honduras", "Hong Kong", "Hungary", "Iceland", "India", "Indonesia", "Iran (Islamic Republic of)", "Iraq", "Ireland", "Israel", "Italy", "Ivory Coast", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea, Democratic People's Republic of", "Korea, Republic of", "Kosovo", "Kuwait", "Kyrgyzstan", "Lao People's Democratic Republic", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libyan Arab Jamahiriya", "Liechtenstein", "Lithuania", "Luxembourg", "Macau", "Macedonia", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Martinique", "Mauritania", "Mauritius", "Mayotte", "Mexico", "Micronesia, Federated States of", "Moldova, Republic of", "Monaco", "Mongolia", "Montserrat", "Morocco", "Mozambique", "Myanmar", "Namibia", "Nauru", "Nepal", "Netherlands", "Netherlands Antilles", "New Caledonia", "New Zealand", "Nicaragua", "Niger", "Nigeria", "Niue", "Norfork Island", "Northern Mariana Islands", "Norway", "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Pitcairn", "Poland", "Portugal", "Puerto Rico", "Qatar", "Reunion", "Romania", "Russian Federation", "Rwanda", "Saint Kitts and Nevis", "Saint Lucia", "Saint Vincent and the Grenadines", "Samoa", "San Marino", "Sao Tome and Principe", "Saudi Arabia", "Senegal", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "South Georgia South Sandwich Islands", "South Sudan", "Spain", "Sri Lanka", "St. Helena", "St. Pierre and Miquelon", "Sudan", "Suriname", "Svalbarn and Jan Mayen Islands", "Swaziland", "Sweden", "Switzerland", "Syrian Arab Republic", "Taiwan", "Tajikistan", "Tanzania, United Republic of", "Thailand", "Togo", "Tokelau", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Turks and Caicos Islands", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States minor outlying islands", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City State", "Venezuela", "Vietnam", "Virigan Islands (British)", "Virgin Islands (U.S.)", "Wallis and Futuna Islands", "Western Sahara", "Yemen", "Yugoslavia", "Zaire", "Zambia", "Zimbabwe" };

            if (countries.Contains(country, StringComparer.OrdinalIgnoreCase)) {
                return true;
            }
            errorProvider.SetError(textBoxCountry, "Unknown country");
            return false;
        }

        private bool ValidateEmail() {
            string email = textBoxEmail.Text;
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase)) {
                return true;
            }

            errorProvider.SetError(textBoxEmail, "Please provide a valid e-mail address (e.g. user@windows.com)");
            return false;
        }


        private bool ValidateNationality() {
            String nationality = textBoxNationality.Text;

            if (UtilityNationality.GetNationalities().Contains(nationality)) {
                return true;
            }

            errorProvider.SetError(textBoxNationality, "Unknown country");
            return false;
        }

        private void labelZipCode_Click(object sender, EventArgs e) {

        }

        private void labelDate_Click(object sender, EventArgs e) {

        }

        private void labelPhone_Click(object sender, EventArgs e) {

        }

        private void textBoxNationalIdNo_TextChanged(object sender, EventArgs e) {

        }

        private void labelCountry_Click(object sender, EventArgs e) {

        }

        // TODO Regex schreiben
        // TODO Logik für Checkbox


    }
}
