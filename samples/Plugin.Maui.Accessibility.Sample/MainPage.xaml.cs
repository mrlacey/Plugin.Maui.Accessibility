namespace Plugin.Maui.Accessibility.Sample;

public partial class MainPage : ContentPage
{
	readonly IAccessibilityInfo feature;

	public MainPage(IAccessibilityInfo feature)
	{
		this.feature = feature;

		this.BindingContext = this.feature;

		InitializeComponent();
	}
}
