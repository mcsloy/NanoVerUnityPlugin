// Copyright (c) Intangible Realities Lab. All rights reserved.
// Licensed under the GPL. See License.txt in the project root for license information.

using NanoVer.Frame;
using NanoVer.Visualisation.Node.Adaptor;

namespace NanoVer.Visualisation.Components.Adaptor
{
    /// <inheritdoc cref="FrameAdaptorNode" />
    public sealed class FrameAdaptor : FrameAdaptorComponent<FrameAdaptorNode>, IFrameConsumer
    {
        /// <inheritdoc cref="IFrameConsumer.FrameSource" />
        public ITrajectorySnapshot FrameSource
        {
            set => node.FrameSource = value;
        }
        
        protected override void OnDisable()
        {
            base.OnDisable();
            
            // Unlink the adaptor, preventing memory leaks
            node.FrameSource = null;
            node.Refresh();
        }
    }
}