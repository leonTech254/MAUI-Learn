namespace MauiApp1.Screens;

public partial class MediaScreen : ContentPage
{
    public MediaScreen()
    {
        InitializeComponent();
    }

    private async void TakePhoto(object sender, EventArgs e)
    {
        // Capture a photo
        FileResult photo = await MediaPicker.Default.CapturePhotoAsync();

        if (photo != null)
        {
            // Getting the file result information
            using Stream sourceStream = await photo.OpenReadAsync();

            // Saving the file in your local storage
            string localFilePath = Path.Combine(FileSystem.CacheDirectory, photo.FileName);

            using FileStream fileStream = File.OpenWrite(localFilePath);
            await sourceStream.CopyToAsync(fileStream);

            // Make sure the stream is closed after the copy operation
            fileStream.Close();

            // Display the image by setting the Source property of the Image control
            myImage.Source = ImageSource.FromFile(localFilePath);
        }
    }
}
