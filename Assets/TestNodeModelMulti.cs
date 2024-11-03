using Dunward.GraphView.Runtime;

public class TestNodeModelMulti : NodeModel
{
    private Node node;

    public override void Initialize(Node node)
    {
        this.node = node;

        // Add input port
        node.AddPort(Port.Direction.Input, Port.Capacity.Multi);
        node.AddPort(Port.Direction.Output, Port.Capacity.Multi);
        node.AddPort(Port.Direction.Input, Port.Capacity.Multi);
        node.AddPort(Port.Direction.Output, Port.Capacity.Multi);
    }
}