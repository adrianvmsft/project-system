﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

namespace Microsoft.VisualStudio.ProjectSystem
{
    internal static class CommonConstants
    {
        /// <summary>
        /// Single, static instance of an array that contains a comma ',', which is used to split strings.
        /// </summary>
        internal static readonly char[] CommaDelimiter = new char[] { ',' };

        /// <summary>
        /// Single, static instance of an array that contains a period '.', which is used to split strings.
        /// </summary>
        internal static readonly char[] PeriodDelimiter = new char[] { '.' };

        /// <summary>
        /// Single, static instance of an array that contains a semi-colon ';', which is used to split strings.
        /// </summary>
        internal static readonly char[] SemicolonDelimiter = new char[] { ';' };

        /// <summary>
        /// Single, static instance of an array that contains a forward slash '/', which is used to split strings.
        /// </summary>
        internal static readonly char[] FowardSlashDelimiter = new char[] { '/' };

        /// <summary>
        /// Single, static instance of an array that contains a back slash '\', which is used to split strings.
        /// </summary>
        internal static readonly char[] BackSlashDelimiter = new char[] { '\\' };
    }
}
