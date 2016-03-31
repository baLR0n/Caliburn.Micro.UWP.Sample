using System;
using Windows.UI.Xaml.Controls;
using Caliburn.Micro.HelloUWP.Messages;

namespace Caliburn.Micro.HelloUWP.ViewModels
{
    public class ShellViewModel : Screen, IHandle<ResumeStateMessage>, IHandle<SuspendStateMessage>
    {
        /// <summary>
        /// The container
        /// </summary>
        private readonly WinRTContainer container;

        /// <summary>
        /// The event aggregator
        /// </summary>
        private readonly IEventAggregator eventAggregator;

        /// <summary>
        /// The navigation service
        /// </summary>
        private INavigationService navigationService;

        /// <summary>
        /// The resume
        /// </summary>
        private bool resume;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShellViewModel"/> class.
        /// </summary>
        /// <param name="container">The container.</param>
        /// <param name="eventAggregator">The event aggregator.</param>
        public ShellViewModel(WinRTContainer container, IEventAggregator eventAggregator)
        {
            this.container = container;
            this.eventAggregator = eventAggregator;
        }

        /// <summary>
        /// Called when activating.
        /// </summary>
        protected override void OnActivate()
        {
            this.eventAggregator.Subscribe(this);
        }

        /// <summary>
        /// Called when deactivating.
        /// </summary>
        /// <param name="close">Inidicates whether this instance will be closed.</param>
        protected override void OnDeactivate(bool close)
        {
            this.eventAggregator.Unsubscribe(this);
        }

        /// <summary>
        /// Setups the navigation service.
        /// </summary>
        /// <param name="frame">The frame.</param>
        public void SetupNavigationService(Frame frame)
        {
            this.navigationService = this.container.RegisterNavigationService(frame);

            if (this.resume)
                this.navigationService.ResumeState();
        }

        /// <summary>
        /// Shows the devices.
        /// </summary>
        public void ShowDevices()
        {
            this.navigationService.For<DeviceViewModel>().Navigate();
        }

        /// <summary>
        /// Handles a suspend message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Handle(SuspendStateMessage message)
        {
            this.navigationService.SuspendState();
        }

        /// <summary>
        /// Handles a resume message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Handle(ResumeStateMessage message)
        {
            this.resume = true;
        }
    }
}
