using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Input.Inking;
using Windows.UI.Core;
using Windows.UI;
using Windows.Storage;
using Windows.AI.MachineLearning;
using Windows.Storage.Streams;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MNIST.Client.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private mnistModel modelGen;
        private mnistInput mnistInput = new mnistInput();
        private mnistOutput mnistOutput;
        //private LearningModelSession    session;
        private Helper helper = new Helper();
        RenderTargetBitmap renderBitmap = new RenderTargetBitmap();

        public MainPage()
        {
            this.InitializeComponent();

            // Set supported inking device types.
            inkCanvas.InkPresenter.InputDeviceTypes = Windows.UI.Core.CoreInputDeviceTypes.Mouse | Windows.UI.Core.CoreInputDeviceTypes.Pen | Windows.UI.Core.CoreInputDeviceTypes.Touch;
            inkCanvas.InkPresenter.UpdateDefaultDrawingAttributes(
                new Windows.UI.Input.Inking.InkDrawingAttributes()
                {
                    Color = Windows.UI.Colors.White,
                    Size = new Size(22, 22),
                    IgnorePressure = true,
                    IgnoreTilt = true,
                }
            );
            LoadModelAsync();
        }

        private async Task LoadModelAsync()
        {
            //Load a machine learning model
            StorageFile modelFile = await StorageFile.GetFileFromApplicationUriAsync(new Uri($"ms-appx:///mnist.onnx"));
            modelGen = await mnistModel.CreateFromStreamAsync(modelFile as IRandomAccessStreamReference);
        }

        private async void recognizeButton_Click(object sender, RoutedEventArgs e)
        {
            //Bind model input with contents from InkCanvas
            VideoFrame vf = await helper.GetHandWrittenImage(inkGrid);
            mnistInput.Input3 = ImageFeatureValue.CreateFromVideoFrame(vf);

            //Evaluate the model
            mnistOutput = await modelGen.EvaluateAsync(mnistInput);

            //Convert output to datatype
            IReadOnlyList<float> vectorImage = mnistOutput.Plus214_Output_0.GetAsVectorView();
            IList<float> imageList = vectorImage.ToList();

            //LINQ query to check for highest probability digit
            var maxIndex = imageList.IndexOf(imageList.Max());

            //Display the results
            numberLabel.Text = maxIndex.ToString();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas.InkPresenter.StrokeContainer.Clear();
            numberLabel.Text = "";
        }
    }
}
