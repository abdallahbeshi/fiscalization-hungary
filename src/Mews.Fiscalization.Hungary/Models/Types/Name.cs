﻿namespace Mews.Fiscalization.Hungary.Models
{
    public sealed class Name : ValidatedString
    {
        private static readonly string regexValidation = ".*[^\\s].*";

        public Name(string value)
            : base(value, 1, 512, regexValidation)
        {
        }

        public static bool IsValid(string value)
        {
            return IsValid(value, 1, 512, regexValidation);
        }
    }
}
