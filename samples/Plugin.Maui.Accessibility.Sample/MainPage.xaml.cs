namespace Plugin.Maui.Accessibility.Sample;

public partial class MainPage : ContentPage
{
	readonly IFeature feature;

	public MainPage(IFeature feature)
	{
		this.feature = feature;

		this.BindingContext = this.feature;

		InitializeComponent();
	}
}
