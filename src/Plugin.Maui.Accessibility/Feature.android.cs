using Android.Provider;

namespace Plugin.Maui.Accessibility;

partial class FeatureImplementation : IFeature
{
	public PossiblyUnknownBool UseReducedMotion
	{
		get
		{
			try
			{
				var resolver = global::Android.App.Application.Context?.ContentResolver;
				if (resolver == null)
				{
					return PossiblyUnknownBool.Unknown;
				}

				// Values may not be set so default to "on" if not set
				var duration = Settings.Global.GetFloat(resolver, Settings.Global.AnimatorDurationScale, 1.0f);
				var transition = Settings.Global.GetFloat(resolver, Settings.Global.TransitionAnimationScale, 1.0f);

				// Both will be zero if animation is disabled
				if (duration < 0.01 && transition < 0.01)
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

	// TODO: Implement your Android specific code
	public double TextScaleFactor { get; }
}
