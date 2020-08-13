// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Windows.Foundation.Collections;

namespace Microsoft.Toolkit.Uwp.Input.GazeInteraction
{
    // Every filter must provide an Wpdate method which transforms sample data
    // and returns filtered output
    internal interface IGazeFilter
    {
        GazeFilterArgs Update(GazeFilterArgs args);

        void LoadSettings(ValueSet settings);
    }
}