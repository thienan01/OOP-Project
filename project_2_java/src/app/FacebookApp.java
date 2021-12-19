package app;

public class FacebookApp implements IAndroidCompatible
{
	private String appName = "Facebook for android";
	private String version = "12.3";

	public final String downloading()
	{
		return "Downloading " + toString();
	}

	public final String getOSCompatible()
	{
		return "Android";
	}

	@Override
	public String toString()
	{
		return "app name: " + appName + ", Version: " + version;
	}

	public final boolean check(String os)
	{
		if (this.getOSCompatible().equals(os))
		{
			return true;
		}
		return false;
	}
}
