using System.Diagnostics;
using Xamarin.Forms;

namespace BackgroundVideo
{
	public partial class BackgroundVideoPage : ContentPage
	{
		public BackgroundVideoPage()
		{
			InitializeComponent();
			video.OnFinishedPlaying = () => { Debug.WriteLine("Video Finished"); };
		}
	}
}
