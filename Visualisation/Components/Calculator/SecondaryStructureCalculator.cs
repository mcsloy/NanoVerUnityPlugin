using Narupa.Visualisation.Node.Calculator;

namespace Narupa.Visualisation.Components.Calculator
{
    /// <inheritdoc cref="SecondaryStructureNode" />
    public class
        SecondaryStructureCalculator : VisualisationComponent<
            Node.Calculator.SecondaryStructureNode>
    {
        private void Update()
        {
            node.Refresh();
        }
    }
}