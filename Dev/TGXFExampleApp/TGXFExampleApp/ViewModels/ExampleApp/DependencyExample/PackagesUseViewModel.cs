using System;
using System.Windows.Input;
using Plugin.Media;
using Plugin.Media.Abstractions;
using TGXFExampleApp.ViewModels.Shared;
using Xamarin.Forms;

namespace TGXFExampleApp.ViewModels.ExampleApp.DependencyExample
{
    public class PackagesUseViewModel : BaseViewModel
    {
        private ImageSource _varSource;

        public ICommand PhotoCommand { get; private set; }
        public ICommand SelectCommand { get; private set; }
        public ICommand VideoCommand { get; private set; }

        public ImageSource VarSource
        {
            get
            {
                return _varSource;
            }
            set
            {
                SetObservableProperty(ref _varSource, value);
            }
        }

        public PackagesUseViewModel()
        {
            VarSource = null;

            PhotoCommand = new Command(PhotoCommandExecute);
            SelectCommand = new Command(SelectCommandExecute);
            VideoCommand = new Command(VideoCommandExecute);
        }

        private async void VideoCommandExecute(object obj)
        {
            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakeVideoSupported)
            {
                DisplayAlert("No Camera", ":( No camera avaialble.", "OK");
                return;
            }

            var file = await CrossMedia.Current.TakeVideoAsync(new StoreVideoOptions
            {
                Name = "video.mp4",
                Directory = "DefaultVideos",
            });

            if (file == null)
                return;

            DisplayAlert("Video Recorded", "Location: " + file.Path, "OK");

            file.Dispose();
        }

        private async  void SelectCommandExecute(object obj)
        {
            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                DisplayAlert("Photos Not Supported", ":( Permission not granted to photos.", "OK");
                return;
            }
            var file = await CrossMedia.Current.PickPhotoAsync(new PickMediaOptions
            {
                PhotoSize = PhotoSize.Medium,

            });


            if (file == null)
                return;

            VarSource = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                file.Dispose();
                return stream;
            });
        }

        private async void PhotoCommandExecute(object obj)
        {
            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                DisplayAlert("No Camera", ":( No camera available.", "OK");
                return;
            }

            var file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
            {
                Directory = "Test",
                SaveToAlbum = true,
                CompressionQuality = 75,
                CustomPhotoSize = 50,
                PhotoSize = PhotoSize.MaxWidthHeight,
                MaxWidthHeight = 2000,
                DefaultCamera = CameraDevice.Front
            });

            if (file == null)
                return;

            VarSource = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                file.Dispose();
                return stream;
            });
        }
    }
}
