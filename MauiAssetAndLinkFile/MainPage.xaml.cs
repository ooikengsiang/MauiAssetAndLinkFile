namespace MauiAssetAndLinkFile;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

		_ = Load();
    }

	public async Task Load()
	{
        var isAboutAssetsFound = await FileSystem.Current.AppPackageFileExistsAsync("AboutAssets.txt");
        AboutAssetsResultLabel.Text = isAboutAssetsFound.ToString();

        var isDontReadMeFound = await FileSystem.Current.AppPackageFileExistsAsync("DontReadMe.txt");
        DontReadMeResultLabel.Text = isDontReadMeFound.ToString();
    }
}
