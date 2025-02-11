using System.Runtime.InteropServices;

namespace Plugin.Maui.Accessibility;

partial class FeatureImplementation : IFeature
{
	public PossiblyUnknownBool UseReducedMotion
	{
		get
		{
			try
			{
				int isAnimationEnabled = 0;
				NativeMethods.SystemParametersInfo(NativeMethods.SPI_GETCLIENTAREAANIMATION, 0, ref isAnimationEnabled, 0);

				// Not that UseReducedMotion is the opposite of using animation (or having it enabled)
				if (isAnimationEnabled == 0)
				{
					return PossiblyUnknownBool.True;
				}
				else
				{
					return PossiblyUnknownBool.False;
				}
			}
			catch (Exception)
			{
				return PossiblyUnknownBool.Unknown;
			}
		}
	}

	public double TextScaleFactor
	{
		get
		{
			var uiSettings = new Windows.UI.ViewManagement.UISettings();

			return uiSettings.TextScaleFactor;
		}
	}
}

public static class NativeMethods
{
	public const int SPI_GETCLIENTAREAANIMATION = 0x1042;

	[DllImport("user32.dll", EntryPoint = "SystemParametersInfo")]
	internal static extern bool SystemParametersInfo(int uiAction, int uiParam, ref int pvParam, int fWinIni);
}
