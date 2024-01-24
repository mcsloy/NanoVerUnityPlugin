using NanoVer.Visualisation.Node.Renderer;
using UnityEngine;

namespace NanoVer.Visualisation.Components.Renderer
{
    public class CyclesRenderer : VisualisationComponentRenderer<CyclesRendererNode>
    {
        private void Start()
        {
            node.Transform = transform;
        }

        protected override void Render(Camera camera)
        {
            if (camera.name == "Preview Scene Camera")
                return;
            node.Render(camera);
        }
    }
}