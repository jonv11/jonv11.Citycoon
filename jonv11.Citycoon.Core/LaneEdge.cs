namespace jonv11.Citycoon.Core
{
	public class LaneEdge
	{
		public readonly LaneVertex Input;
		public readonly LaneVertex Output;
		public readonly float Length;

		public LaneEdge(LaneVertex input, LaneVertex output, float length)
		{
			Input = input;
			Output = output;
			Length = length;
		}
	}
}
