// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.Extensions.Primitives;

namespace Microsoft.Extensions.OptionsModel
{
    public interface IOptionsChangeTracker<out TOptions>
    {
        IChangeToken GetChangeToken();
        void Changed();
    }
}