using Liskov_Substitution.LSPBad;
using Liskov_Substitution.LSPGood;

// Bad way
/*
BasePhone phone;

phone = new Iphone();
phone.Call();
phone.TakePhoto(); // Success

phone = new Nokia3310();
phone.Call();
phone.TakePhoto(); // Exception
*/

// Good way
BasePhone2 phone;

phone = new Iphone2();
phone.Call();
((ITakePhoto)phone).TakePhoto(); // Success

phone = new Nokia33102();
phone.Call();

