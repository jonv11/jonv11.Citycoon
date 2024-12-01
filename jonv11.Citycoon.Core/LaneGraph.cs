namespace jonv11.Citycoon.Core
{
	/// <summary>
	/// Represents a graph of lanes, containing edges and vertices.
	/// </summary>
	public class LaneGraph
	{
		/// <summary>
		/// Gets or sets the collection of edges in the lane graph.
		/// </summary>
		private HashSet<LaneEdge> edges = new HashSet<LaneEdge>();

		/// <summary>
		/// Gets or sets the collection of vertices in the lane graph.
		/// </summary>
		private HashSet<LaneVertex> vertices = new HashSet<LaneVertex>();
	}
}
