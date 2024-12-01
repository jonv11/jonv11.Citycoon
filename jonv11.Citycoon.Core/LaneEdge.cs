namespace jonv11.Citycoon.Core
{
	/// <summary>
	/// Represents an edge in a lane, connecting two vertices with a specified length.
	/// </summary>
	public class LaneEdge
	{
		/// <summary>
		/// Gets the starting vertex of the lane edge.
		/// </summary>
		public readonly LaneVertex Input;

		/// <summary>
		/// Gets the ending vertex of the lane edge.
		/// </summary>
		public readonly LaneVertex Output;

		/// <summary>
		/// Gets the length of the lane edge.
		/// </summary>
		public readonly float Length;

		/// <summary>
		/// Initializes a new instance of the <see cref="LaneEdge"/> class with specified vertices and length.
		/// </summary>
		/// <param name="input">The starting vertex of the lane edge.</param>
		/// <param name="output">The ending vertex of the lane edge.</param>
		/// <param name="length">The length of the lane edge.</param>
		public LaneEdge(LaneVertex input, LaneVertex output, float length)
		{
			ArgumentNullException.ThrowIfNull(input);
			ArgumentNullException.ThrowIfNull(output);
			ArgumentOutOfRangeException.ThrowIfNegativeOrZero(length);
			Input = input;
			Output = output;
			Length = length;
		}
	}
}
