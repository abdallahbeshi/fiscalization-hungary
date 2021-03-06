﻿namespace Mews.Fiscalization.Hungary.Models
{
    public sealed class Region : ValidatedString
    {
        private static readonly string regexValidation = ".*[^\\s].*";

        public Region(string value)
            : base(value, 1, 50, regexValidation, isNullable: true)
        {
        }

        public static bool IsValid(string value)
        {
            return IsValid(value, 1, 50, regexValidation, isNullable: true);
        }
    }
}
