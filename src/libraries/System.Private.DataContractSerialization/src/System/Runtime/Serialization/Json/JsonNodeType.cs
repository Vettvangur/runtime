// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Runtime.Serialization.Json
{
    internal enum JsonNodeType
    {
        None,
        Object,
        Element,
        EndElement,
        QuotedText,
        StandaloneText,
        Collection
    }
}
