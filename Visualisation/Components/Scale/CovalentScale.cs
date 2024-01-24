// Copyright (c) Intangible Realities Lab. All rights reserved.
// Licensed under the GPL. See License.txt in the project root for license information.

using NanoVer.Visualisation.Node.Scale;

namespace NanoVer.Visualisation.Components.Scale
{
    /// <inheritdoc cref="CovalentScaleNode" />
    public sealed class CovalentScale : VisualisationComponent<CovalentScaleNode>
    {
        protected override void OnEnable()
        {
            base.OnEnable();
            node.Refresh();
        }

        private void Update()
        {
            node.Refresh();
        }
    }
}