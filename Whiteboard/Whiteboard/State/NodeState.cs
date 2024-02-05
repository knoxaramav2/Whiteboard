using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whiteboard.State
{
    public class NodeState(
        Guid guid,
        string text, 
        Size size, 
        Point loc,
        Point offset,
        List<NodeState> connections)
    {
        public Guid Id { get; set; } = guid;
        public string Text { get; private set; } = text;
        public Size Size { get; private set; } = size;
        public Point Loc { get; private set; } = loc;
        public Point Offset { get; private set; } = offset;
        public List<NodeState> Connected = connections;
    }

    public class NodeFlow
    {
        public List<NodeState> Nodes;
        public Point Origin;

        public NodeFlow()
        {
            Nodes = [];
            Origin = new();
        }

        public NodeFlow(
            List<NodeState> nodes,
            Point origin
            )
        {
            Nodes = nodes;
            Origin = origin;
        }
    }
}
