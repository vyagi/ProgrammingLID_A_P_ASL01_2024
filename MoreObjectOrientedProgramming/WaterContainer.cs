namespace MoreObjectOrientedProgramming;

public class WaterContainer : Container
{
	public bool IsTransparent { get; protected set; }

	public WaterContainer(int capacity, bool isTransparent) : base(capacity)
	{
		IsTransparent = isTransparent;
	}
}
