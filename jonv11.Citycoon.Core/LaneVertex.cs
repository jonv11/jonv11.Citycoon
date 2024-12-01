namespace jonv11.Citycoon.Core
{
	/// <summary>
	/// Represents a vertex in a lane with 3D coordinates and a heading direction in radians.
	/// </summary>
	public class LaneVertex
	{
		/// <summary>
		/// Gets the X coordinate of the vertex.
		/// </summary>
		public readonly float X;

		/// <summary>
		/// Gets the Y coordinate of the vertex.
		/// </summary>
		public readonly float Y;

		/// <summary>
		/// Gets the Z coordinate of the vertex.
		/// </summary>
		public readonly float Z;

		/// <summary>
		/// Gets the heading direction in radians.
		/// </summary>
		public readonly float HeadingRadians;

		/// <summary>
		/// Gets or sets the collection of incoming lane edges.
		/// </summary>
		private HashSet<LaneEdge> inputs = new HashSet<LaneEdge>();

		/// <summary>
		/// Gets or sets the collection of outgoing lane edges.
		/// </summary>
		private HashSet<LaneEdge> outputs = new HashSet<LaneEdge>();

		/// <summary>
		/// Initializes a new instance of the <see cref="LaneVertex"/> class with specified coordinates and heading.
		/// </summary>
		/// <param name="x">The X coordinate of the vertex.</param>
		/// <param name="y">The Y coordinate of the vertex.</param>
		/// <param name="z">The Z coordinate of the vertex.</param>
		/// <param name="headingRadians">The heading direction in radians.</param>
		public LaneVertex(float x, float y, float z, float headingRadians)
		{
			X = x;
			Y = y;
			Z = z;
			HeadingRadians = headingRadians;
		}

		/// <summary>
		/// Adds a lane edge to the input edges.
		/// </summary>
		/// <param name="edge">The lane edge to add.</param>
		/// <returns>True if the edge was added; otherwise, false.</returns>
		/// <exception cref="ArgumentNullException">Thrown when the edge is null.</exception>
		/// <exception cref="InvalidOperationException">Thrown when the edge's output is not this vertex.</exception>
		public bool AddInput(LaneEdge edge)
		{
			ArgumentNullException.ThrowIfNull(edge);
			if (edge.Output != this)
				throw new InvalidOperationException("Invalid edge.Output value");
			return inputs.Add(edge);
		}

		/// <summary>
		/// Removes a lane edge from the input edges.
		/// </summary>
		/// <param name="edge">The lane edge to remove.</param>
		/// <returns>True if the edge was removed; otherwise, false.</returns>
		public bool RemoveInput(LaneEdge edge)
		{
			return inputs.Remove(edge);
		}

		/// <summary>
		/// Adds a lane edge to the output edges.
		/// </summary>
		/// <param name="edge">The lane edge to add.</param>
		/// <returns>True if the edge was added; otherwise, false.</returns>
		/// <exception cref="ArgumentNullException">Thrown when the edge is null.</exception>
		/// <exception cref="InvalidOperationException">Thrown when the edge's input is not this vertex.</exception>
		public bool AddOutput(LaneEdge edge)
		{
			ArgumentNullException.ThrowIfNull(edge);
			if (edge.Input != this)
				throw new InvalidOperationException("Invalid edge.Input value");
			return outputs.Add(edge);
		}

		/// <summary>
		/// Removes a lane edge from the output edges.
		/// </summary>
		/// <param name="edge">The lane edge to remove.</param>
		/// <returns>True if the edge was removed; otherwise, false.</returns>
		public bool RemoveOutput(LaneEdge edge)
		{
			return outputs.Remove(edge);
		}
	}
}
