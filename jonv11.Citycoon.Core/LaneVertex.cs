namespace jonv11.Citycoon.Core
{
	public class LaneVertex
	{
		public readonly float X;
		public readonly float Y;
		public readonly float Z;
		public readonly float HeadingRadians;

		public LaneVertex(float x, float y, float z, float headingRadians)
		{
			X = x;
			Y = y;
			Z = z;
			HeadingRadians = headingRadians;
		}
	}
}
