namespace Caliburn.Micro.HelloUWP.ViewModels
{
    /// <summary>
    /// Class DeviceViewModel.
    /// </summary>
    public class DeviceViewModel : Screen
    {
        /// <summary>
        /// Tests this instance.
        /// </summary>
        public void Test()
        {
            this.Title = "Button was clicked";
            this.NotifyOfPropertyChange(() => this.Title);
        }

        /// <summary>
        /// Gets or sets the test text.
        /// </summary>
        /// <value>The test text.</value>
        public string Title { get; set; } = "Default Device View";
    }
}
