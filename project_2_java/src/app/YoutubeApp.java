package app;

public class YoutubeApp implements IAppleCompatible
{
	private String appName = "Youtube for IOS";
	private String version = "15.2";

	public final String downloading()
	{
		return "Downloading " + toString();
	}
	public final String getOSCompatible()
	{
		return "IOS";
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
