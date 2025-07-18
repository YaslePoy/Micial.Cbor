// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Diagnostics;

namespace Micial.Cbor.Reader
{
    public partial class CborReader
    {
        /// <summary>Reads the contents of the next value, discarding the result and advancing the reader.</summary>
        /// <param name="disableConformanceModeChecks"><see langword="true" /> to disable conformance mode validation for the skipped values, equivalent to using <see cref="CborConformanceMode.Lax" />; otherwise, <see langword="false" />.</param>
        /// <exception cref="InvalidOperationException">The reader is not at the start of new value.</exception>
        /// <exception cref="CborContentException"><para>The next value has an invalid CBOR encoding.</para>
        /// <para>-or-</para>
        /// <para>There was an unexpected end of CBOR encoding data.</para>
        /// <para>-or-</para>
        /// <para>The next value uses a CBOR encoding that is not valid under the current conformance mode.</para></exception>
        public void SkipValue(bool disableConformanceModeChecks = false)
        {
            SkipToAncestor(0, disableConformanceModeChecks);
        }

        /// <summary>Reads the remaining contents of the current value context, discarding results and advancing the reader to the next value in the parent context.</summary>
        /// <param name="disableConformanceModeChecks"><see langword="true" /> to disable conformance mode validation for the skipped values, equivalent to using <see cref="CborConformanceMode.Lax" />; otherwise, <see langword="false" />.</param>
        /// <exception cref="InvalidOperationException">The reader is at the root context</exception>
        /// <exception cref="CborContentException"><para>The next value has an invalid CBOR encoding.</para>
        /// <para>-or-</para>
        /// <para>There was an unexpected end of CBOR encoding data.</para>
        /// <para>-or-</para>
        /// <para>The next value uses a CBOR encoding that is not valid under the current conformance mode.</para></exception>
        public void SkipToParent(bool disableConformanceModeChecks = false)
        {
            if (_currentMajorType is null)
            {
                throw new InvalidOperationException(MSR.Cbor_Reader_IsAtRootContext);
            }

            SkipToAncestor(1, disableConformanceModeChecks);
        }

        private void SkipToAncestor(int depth, bool disableConformanceModeChecks)
        {
            Debug.Assert(0 <= depth && depth <= CurrentDepth);
            Checkpoint checkpoint = CreateCheckpoint();
            _isConformanceModeCheckEnabled = !disableConformanceModeChecks;

            try
            {
                do
                {
                    SkipNextNode(ref depth);
                } while (depth > 0);
            }
            catch
            {
                RestoreCheckpoint(in checkpoint);
                throw;
            }
            finally
            {
                _isConformanceModeCheckEnabled = true;
            }
        }

        private void SkipNextNode(ref int depth)
        {
            CborReaderState state;

            // peek, skipping any tags we might encounter
            while ((state = PeekStateCore()) == CborReaderState.Tag)
            {
                ReadTag();
            }

            switch (state)
            {
                case CborReaderState.UnsignedInteger:
                    ReadUInt64();
                    break;

                case CborReaderState.NegativeInteger:
                    ReadCborNegativeIntegerRepresentation();
                    break;

                case CborReaderState.ByteString:
                    SkipString(type: CborMajorType.ByteString);
                    break;

                case CborReaderState.TextString:
                    SkipString(type: CborMajorType.TextString);
                    break;

                case CborReaderState.StartIndefiniteLengthByteString:
                    ReadStartIndefiniteLengthByteString();
                    depth++;
                    break;

                case CborReaderState.EndIndefiniteLengthByteString:
                    ValidatePop(state, depth);
                    ReadEndIndefiniteLengthByteString();
                    depth--;
                    break;

                case CborReaderState.StartIndefiniteLengthTextString:
                    ReadStartIndefiniteLengthTextString();
                    depth++;
                    break;

                case CborReaderState.EndIndefiniteLengthTextString:
                    ValidatePop(state, depth);
                    ReadEndIndefiniteLengthTextString();
                    depth--;
                    break;

                case CborReaderState.StartArray:
                    ReadStartArray();
                    depth++;
                    break;

                case CborReaderState.EndArray:
                    ValidatePop(state, depth);
                    ReadEndArray();
                    depth--;
                    break;

                case CborReaderState.StartMap:
                    ReadStartMap();
                    depth++;
                    break;

                case CborReaderState.EndMap:
                    ValidatePop(state, depth);
                    ReadEndMap();
                    depth--;
                    break;

                case CborReaderState.HalfPrecisionFloat:
                case CborReaderState.SinglePrecisionFloat:
                case CborReaderState.DoublePrecisionFloat:
                    ReadDouble();
                    break;

                case CborReaderState.Null:
                case CborReaderState.Boolean:
                case CborReaderState.SimpleValue:
                    ReadSimpleValue();
                    break;

                default:
                    throw new InvalidOperationException(MSR.Format(MSR.Cbor_Reader_Skip_InvalidState, state));
            }

            // guards against cases where the caller attempts to skip when reader is not positioned at the start of a value
            static void ValidatePop(CborReaderState state, int depth)
            {
                if (depth == 0)
                {
                    throw new InvalidOperationException(MSR.Format(MSR.Cbor_Reader_Skip_InvalidState, state));
                }
            }
        }
    }
}
