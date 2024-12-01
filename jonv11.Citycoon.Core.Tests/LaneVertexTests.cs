namespace jonv11.Citycoon.Core.Tests
{
	public class LaneVertexTests
	{
		[Test]
		public void LaneVertexInitializationShouldSetProperties()
		{
			// Arrange
			float x = 1.0f;
			float y = 2.0f;
			float z = 3.0f;
			float headingRadians = 0.5f;

			// Act
			LaneVertex vertex = new LaneVertex(x, y, z, headingRadians);

			// Assert
			Assert.That(vertex.X, Is.EqualTo(x));
			Assert.That(vertex.Y, Is.EqualTo(y));
			Assert.That(vertex.Z, Is.EqualTo(z));
			Assert.That(vertex.HeadingRadians, Is.EqualTo(headingRadians));
		}

		[Test]
		public void AddInputValidEdgeShouldAddEdge()
		{
			// Arrange
			LaneVertex vertex = new LaneVertex(0, 0, 0, 0);
			LaneVertex otherVertex = new LaneVertex(1, 1, 1, 1);
			LaneEdge edge = new LaneEdge(otherVertex, vertex, 5);

			// Act
			bool result = vertex.AddInput(edge);

			// Assert
			Assert.IsTrue(result);
		}

		[Test]
		public void AddOutputValidEdgeShouldAddEdge()
		{
			// Arrange
			LaneVertex vertex = new LaneVertex(0, 0, 0, 0);
			LaneVertex otherVertex = new LaneVertex(1, 1, 1, 1);
			LaneEdge edge = new LaneEdge(vertex, otherVertex, 5);

			// Act
			bool result = vertex.AddOutput(edge);

			// Assert
			Assert.IsTrue(result);
		}
	}
}
