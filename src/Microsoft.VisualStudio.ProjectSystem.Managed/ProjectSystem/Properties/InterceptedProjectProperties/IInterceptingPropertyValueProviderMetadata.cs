﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

namespace Microsoft.VisualStudio.ProjectSystem.Properties
{
    /// <summary>
    /// Metadata mapping interface for the <see cref="ExportInterceptingPropertyValueProviderAttribute"/>.
    /// </summary>
    internal interface IInterceptingPropertyValueProviderMetadata
    {
        string PropertyName { get; }
    }
}