namespace Plugin.Maui.Accessibility.Sample;

public partial class MainPage : ContentPage
{
	readonly IFeature feature;

	public MainPage(IFeature feature)
	{
		InitializeComponent();

		this.feature = feature;
	}
}
