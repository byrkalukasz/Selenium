using System;

namespace POM
{
    public static class Config
    {
        public static string BaseUrl = "http://testing.todvachev.com/";

        public static class Credentials
        {
            public static class Valid
            {
                public static string username = "ValidUser";
                public static string password = "Sdqa1234";
                public static string repeatPassword = "Sdqa1234";
                public static string email = "example@egxample.egxample";
            }
            public static class Invalid
            {
                public static class Username
                {
                    public static string FourChar = "asdf";
                    public static string ThirteenChar = "asdfghasdfgasd";

                }
                public static class Password
                {
                    public static string LessThan5Characters = "1";
                    public static string MoreThan12Chharacters = "1245125478541";
                }
                public static class Email
                {
                    public static string WrongEmail = "esawe";
                }
            }
        }
        public static class AlertMassage
        {
            public static string SuccesLogin = "Succesful login!";
            public static string InvalidUsername = "User Id should not be empty / length be between 5 to 12";
            public static string InvalidPassword = "Password should not be empty / length be between 5 to 12";

        }
    }
}
