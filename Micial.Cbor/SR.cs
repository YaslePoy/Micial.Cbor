using System.Resources;

namespace System.Formats.Cbor
{
    internal static partial class MSR
    {
        /// <summary>The destination is too small to hold the encoded value.</summary>
        internal static string @Argument_EncodeDestinationTooSmall =>
            GetResourceString("Argument_EncodeDestinationTooSmall");

        /// <summary>Cannot perform the requested operation, the current major type context is '{0}'.</summary>
        internal static string @Cbor_PopMajorTypeMismatch => GetResourceString("Cbor_PopMajorTypeMismatch");

        /// <summary>Not at end of the definite-length data item.</summary>
        internal static string @Cbor_NotAtEndOfDefiniteLengthDataItem =>
            GetResourceString("Cbor_NotAtEndOfDefiniteLengthDataItem");

        /// <summary>Not at end of the indefinite-length data item.</summary>
        internal static string @Cbor_NotAtEndOfIndefiniteLengthDataItem =>
            GetResourceString("Cbor_NotAtEndOfIndefiniteLengthDataItem");

        /// <summary>CBOR Conformance mode '{0}' does not support indefinite-length data items.</summary>
        internal static string @Cbor_ConformanceMode_IndefiniteLengthItemsNotSupported =>
            GetResourceString("Cbor_ConformanceMode_IndefiniteLengthItemsNotSupported");

        /// <summary>CBOR Conformance mode '{0}' does not support non-canonical integer representations.</summary>
        internal static string @Cbor_ConformanceMode_NonCanonicalIntegerRepresentation =>
            GetResourceString("Cbor_ConformanceMode_NonCanonicalIntegerRepresentation");

        /// <summary>CBOR Conformance mode '{0}' does not support indefinite-length items.</summary>
        internal static string @Cbor_ConformanceMode_RequiresDefiniteLengthItems =>
            GetResourceString("Cbor_ConformanceMode_RequiresDefiniteLengthItems");

        /// <summary>CBOR Conformance mode '{0}' does not support duplicate keys.</summary>
        internal static string @Cbor_ConformanceMode_ContainsDuplicateKeys =>
            GetResourceString("Cbor_ConformanceMode_ContainsDuplicateKeys");

        /// <summary>CBOR keys not sorted in accordance with conformance mode '{0}'.</summary>
        internal static string @Cbor_ConformanceMode_KeysNotInSortedOrder =>
            GetResourceString("Cbor_ConformanceMode_KeysNotInSortedOrder");

        /// <summary>CBOR Conformance mode '{0}' does not support tagged values.</summary>
        internal static string @Cbor_ConformanceMode_TagsNotSupported =>
            GetResourceString("Cbor_ConformanceMode_TagsNotSupported");

        /// <summary>Declared definite length of CBOR data item exceeds available buffer size.</summary>
        internal static string @Cbor_Reader_DefiniteLengthExceedsBufferSize =>
            GetResourceString("Cbor_Reader_DefiniteLengthExceedsBufferSize");

        /// <summary>No more CBOR data items to read in the current context.</summary>
        internal static string @Cbor_Reader_NoMoreDataItemsToRead =>
            GetResourceString("Cbor_Reader_NoMoreDataItemsToRead");

        /// <summary>Unexpected end of CBOR encoding data.</summary>
        internal static string @Cbor_Reader_InvalidCbor_UnexpectedEndOfBuffer =>
            GetResourceString("Cbor_Reader_InvalidCbor_UnexpectedEndOfBuffer");

        /// <summary>Indefinite-length CBOR string nests an invalid data item of major type {0}.</summary>
        internal static string @Cbor_Reader_InvalidCbor_IndefiniteLengthStringContainsInvalidDataItem =>
            GetResourceString("Cbor_Reader_InvalidCbor_IndefiniteLengthStringContainsInvalidDataItem");

        /// <summary>Cannot perform the requested operation, the next CBOR data item is of major type '{0}'.</summary>
        internal static string @Cbor_Reader_MajorTypeMismatch => GetResourceString("Cbor_Reader_MajorTypeMismatch");

        /// <summary>CBOR reader is already at the root data item context.</summary>
        internal static string @Cbor_Reader_IsAtRootContext => GetResourceString("Cbor_Reader_IsAtRootContext");

        /// <summary>A CBOR tag should always be followed by a data item.</summary>
        internal static string @Cbor_Reader_InvalidCbor_TagNotFollowedByValue =>
            GetResourceString("Cbor_Reader_InvalidCbor_TagNotFollowedByValue");

        /// <summary>CBOR initial byte contains invalid integer encoding</summary>
        internal static string @Cbor_Reader_InvalidCbor_InvalidIntegerEncoding =>
            GetResourceString("Cbor_Reader_InvalidCbor_InvalidIntegerEncoding");

        /// <summary>The current CBOR map contains an incomplete key/value pair.</summary>
        internal static string @Cbor_Reader_InvalidCbor_KeyMissingValue =>
            GetResourceString("Cbor_Reader_InvalidCbor_KeyMissingValue");

        /// <summary>Data item does not encode a floating point number.</summary>
        internal static string @Cbor_Reader_NotAFloatEncoding => GetResourceString("Cbor_Reader_NotAFloatEncoding");

        /// <summary>Attempting to read floating point encoding as a lower-precision value.</summary>
        internal static string @Cbor_Reader_ReadingAsLowerPrecision =>
            GetResourceString("Cbor_Reader_ReadingAsLowerPrecision");

        /// <summary>CBOR simple value does not encode a boolean value.</summary>
        internal static string @Cbor_Reader_NotABooleanEncoding => GetResourceString("Cbor_Reader_NotABooleanEncoding");

        /// <summary>CBOR data item does not encode a simple value.</summary>
        internal static string @Cbor_Reader_NotASimpleValueEncoding =>
            GetResourceString("Cbor_Reader_NotASimpleValueEncoding");

        /// <summary>CBOR simple value does not encode null.</summary>
        internal static string @Cbor_Reader_NotANullEncoding => GetResourceString("Cbor_Reader_NotANullEncoding");

        /// <summary>CBOR Conformance mode '{0}' does not support simple values in the range 24-31 and must be encoded as small as possible.</summary>
        internal static string @Cbor_ConformanceMode_InvalidSimpleValueEncoding =>
            GetResourceString("Cbor_ConformanceMode_InvalidSimpleValueEncoding");

        /// <summary>CBOR definite-length data items contains unexpected break byte.</summary>
        internal static string @Cbor_Reader_InvalidCbor_UnexpectedBreakByte =>
            GetResourceString("Cbor_Reader_InvalidCbor_UnexpectedBreakByte");

        /// <summary>Reader state '{0}' is not at the start of a data item.</summary>
        internal static string @Cbor_Reader_Skip_InvalidState => GetResourceString("Cbor_Reader_Skip_InvalidState");

        /// <summary>CBOR text string payload is not valid a UTF-8 encoding.</summary>
        internal static string @Cbor_Reader_InvalidCbor_InvalidUtf8StringEncoding =>
            GetResourceString("Cbor_Reader_InvalidCbor_InvalidUtf8StringEncoding");

        /// <summary>CBOR string is not of indefinite length.</summary>
        internal static string @Cbor_Reader_NotIndefiniteLengthString =>
            GetResourceString("Cbor_Reader_NotIndefiniteLengthString");

        /// <summary>CBOR tag does not match expected value.</summary>
        internal static string @Cbor_Reader_TagMismatch => GetResourceString("Cbor_Reader_TagMismatch");

        /// <summary>Not a valid tagged RFC3339 DateTime encoding.</summary>
        internal static string @Cbor_Reader_InvalidDateTimeEncoding =>
            GetResourceString("Cbor_Reader_InvalidDateTimeEncoding");

        /// <summary>Not a valid tagged unix time encoding.</summary>
        internal static string @Cbor_Reader_InvalidUnixTimeEncoding =>
            GetResourceString("Cbor_Reader_InvalidUnixTimeEncoding");

        /// <summary>Not a valid tagged bignum encoding.</summary>
        internal static string @Cbor_Reader_InvalidBigNumEncoding =>
            GetResourceString("Cbor_Reader_InvalidBigNumEncoding");

        /// <summary>Not a valid tagged decimal encoding.</summary>
        internal static string @Cbor_Reader_InvalidDecimalEncoding =>
            GetResourceString("Cbor_Reader_InvalidDecimalEncoding");

        /// <summary>Not a valid CBOR value encoding.</summary>
        internal static string @Cbor_Writer_PayloadIsNotValidCbor =>
            GetResourceString("Cbor_Writer_PayloadIsNotValidCbor");

        /// <summary>Writer contains an incomplete CBOR document.</summary>
        internal static string @Cbor_Writer_IncompleteCborDocument =>
            GetResourceString("Cbor_Writer_IncompleteCborDocument");

        /// <summary>Adding a CBOR data item to the current context exceeds its definite length.</summary>
        internal static string @Cbor_Writer_DefiniteLengthExceeded =>
            GetResourceString("Cbor_Writer_DefiniteLengthExceeded");

        /// <summary>Cannot nest data items in indefinite-length CBOR string contexts.</summary>
        internal static string @Cbor_Writer_CannotNestDataItemsInIndefiniteLengthStrings =>
            GetResourceString("Cbor_Writer_CannotNestDataItemsInIndefiniteLengthStrings");

        /// <summary>CBOR map incomplete; each key must be followed by a corresponding value.</summary>
        internal static string @Cbor_Writer_MapIncompleteKeyValuePair =>
            GetResourceString("Cbor_Writer_MapIncompleteKeyValuePair");

        /// <summary>Not a valid UTF-8 encoding.</summary>
        internal static string @Cbor_Writer_InvalidUtf8String => GetResourceString("Cbor_Writer_InvalidUtf8String");

        /// <summary>Value cannot be infinite or NaN.</summary>
        internal static string @Cbor_Writer_ValueCannotBeInfiniteOrNaN =>
            GetResourceString("Cbor_Writer_ValueCannotBeInfiniteOrNaN");

        /// <summary>Value was either too large or too small for a Decimal.</summary>
        internal static string @Cbor_Writer_DecimalOverflow => GetResourceString("Cbor_Writer_DecimalOverflow");

        /// <summary>The CBOR encoding is invalid.</summary>
        internal static string @CborContentException_DefaultMessage =>
            GetResourceString("CborContentException_DefaultMessage");

        private static readonly bool s_usingResourceKeys =
            AppContext.TryGetSwitch("System.Resources.UseSystemResourceKeys", out bool usingResourceKeys)
                ? usingResourceKeys
                : false;

        // This method is used to decide if we need to append the exception message parameters to the message when calling MSR.Format.
        // by default it returns the value of System.Resources.UseSystemResourceKeys AppContext switch or false if not specified.
        // Native code generators can replace the value this returns based on user input at the time of native code generation.
        // The Linker is also capable of replacing the value of this method when the application is being trimmed.
        private static bool UsingResourceKeys() => s_usingResourceKeys;

        internal static string GetResourceString(string resourceKey)
        {
            return resourceKey; // only null if missing resources
        }

        internal static string GetResourceString(string resourceKey, string defaultString)
        {
            string resourceString = GetResourceString(resourceKey);

            return resourceKey == resourceString || resourceString == null ? defaultString : resourceString;
        }

        internal static string Format(string resourceFormat, object? p1)
        {
            if (UsingResourceKeys())
            {
                return string.Join(", ", resourceFormat, p1);
            }

            return string.Format(resourceFormat, p1);
        }

        internal static string Format(string resourceFormat, object? p1, object? p2)
        {
            if (UsingResourceKeys())
            {
                return string.Join(", ", resourceFormat, p1, p2);
            }

            return string.Format(resourceFormat, p1, p2);
        }

        internal static string Format(string resourceFormat, object? p1, object? p2, object? p3)
        {
            if (UsingResourceKeys())
            {
                return string.Join(", ", resourceFormat, p1, p2, p3);
            }

            return string.Format(resourceFormat, p1, p2, p3);
        }

        internal static string Format(string resourceFormat, params object?[]? args)
        {
            if (args != null)
            {
                if (UsingResourceKeys())
                {
                    return resourceFormat + ", " + string.Join(", ", args);
                }

                return string.Format(resourceFormat, args);
            }

            return resourceFormat;
        }

        internal static string Format(IFormatProvider? provider, string resourceFormat, object? p1)
        {
            if (UsingResourceKeys())
            {
                return string.Join(", ", resourceFormat, p1);
            }

            return string.Format(provider, resourceFormat, p1);
        }

        internal static string Format(IFormatProvider? provider, string resourceFormat, object? p1, object? p2)
        {
            if (UsingResourceKeys())
            {
                return string.Join(", ", resourceFormat, p1, p2);
            }

            return string.Format(provider, resourceFormat, p1, p2);
        }

        internal static string Format(IFormatProvider? provider, string resourceFormat, object? p1, object? p2,
            object? p3)
        {
            if (UsingResourceKeys())
            {
                return string.Join(", ", resourceFormat, p1, p2, p3);
            }

            return string.Format(provider, resourceFormat, p1, p2, p3);
        }

        internal static string Format(IFormatProvider? provider, string resourceFormat, params object?[]? args)
        {
            if (args != null)
            {
                if (UsingResourceKeys())
                {
                    return resourceFormat + ", " + string.Join(", ", args);
                }

                return string.Format(provider, resourceFormat, args);
            }

            return resourceFormat;
        }
    }
}