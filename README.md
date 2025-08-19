# Windows Forms Registration Page

A simple **Windows Forms** application for user registration.  
The app includes input validation for all required fields and buttons to display **Terms of Service** and **Privacy Policy**.

## Features
- Registration form with validation:
  - First name, middle name, last name, date of birth
  - Address, city, ZIP code, country
  - Phone number, email
  - Nationality, national ID, passport number
- Validations:
  - Required fields highlighted with ErrorProvider
  - Regex validation (email, phone number, passport number, ZIP code, etc.)
  - Date validation using `DateTime.TryParseExact`
- Integration of **Terms of Service** and **Privacy Policy** (PDF viewer or dialog)
- ErrorProvider for inline error messages
- Easily extendable
