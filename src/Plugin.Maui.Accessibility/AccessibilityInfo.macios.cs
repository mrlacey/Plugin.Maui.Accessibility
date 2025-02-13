using UIKit;

namespace Plugin.Maui.Accessibility;

partial class AccessibilityInfoImplementation : IAccessibilityInfo
{
	// TODO Implement your macOS/iOS specific code
	public PossiblyUnknownBool UseReducedMotion
	{
		get
		{
			try
			{
				return UIKit.UIAccessibility.IsReduceMotionEnabled.ToPossiblyUnknownBool();
			}
			catch (Exception exc)
			{
				System.Diagnostics.Debug.WriteLine(exc);
			}

			return PossiblyUnknownBool.Unknown;
		}
	}

	public double TextScaleFactor
	{
		get
		{
			try
			{
				var preferredContentSize = UIKit.UIApplication.SharedApplication.GetPreferredContentSizeCategory();

				return ContentSizeCategoryToDouble(preferredContentSize);
			}
			catch (Exception exc)
			{
				System.Diagnostics.Debug.WriteLine(exc);
			}

			return AccessibilityInfo.DefaultTextScaleFactor;
		}
	}

	// Based on https://stackoverflow.com/a/70673182
	private static double ContentSizeCategoryToDouble(UIContentSizeCategory sizeCategory) => sizeCategory switch
	{
		UIContentSizeCategory.ExtraSmall => 0.882758620689655,
		UIContentSizeCategory.Small => 0.937931034482759,
		UIContentSizeCategory.Large => 1.0448275862069,
		UIContentSizeCategory.ExtraLarge => 1.16551724137931,
		UIContentSizeCategory.ExtraExtraLarge => 1.24827586206897,
		UIContentSizeCategory.ExtraExtraExtraLarge => 1.36551724137931,
		UIContentSizeCategory.AccessibilityMedium => 1.64137931034483,
		UIContentSizeCategory.AccessibilityLarge => 1.93793103448276,
		UIContentSizeCategory.AccessibilityExtraLarge => 2.33793103448276,
		UIContentSizeCategory.AccessibilityExtraExtraLarge => 2.77931034482759,
		UIContentSizeCategory.AccessibilityExtraExtraExtraLarge => 2.99310344827586,
		_ => AccessibilityInfo.DefaultTextScaleFactor,
	};
}
