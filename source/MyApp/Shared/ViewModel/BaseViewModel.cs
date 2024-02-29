using MyApp.Utils.Constants;
using PropertyChanged;
using Refit;

namespace MyApp.Shared.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class BaseViewModel
    {
        public string Title { get; set; }
        public bool IsBusy { get; set; }

        private string _error;

        public BaseViewModel(){ }

        protected async Task InitDelayedAsync(params Func<Task>[] asyncFuncs)
        {
            try
            {
                IsBusy = true;

                await Task.Delay(SharedConstant.InitDelayTime);

                var tasks = asyncFuncs.Select(af => af());

                await Task.WhenAll(tasks);

                await AfterInit();
            }
            finally
            {
                IsBusy = false;

                await Task.Delay(1);
            }
        }

        protected async Task InitAsync(params Func<Task>[] asyncFuncs)
        {
            IsBusy = true;

            var tasks = asyncFuncs.Select(af => af());

            await Task.WhenAll(tasks).ContinueWith(t =>
            {
                Device.BeginInvokeOnMainThread(() => IsBusy = false);
            });
        }

        protected async Task LoadAsync(params Func<Task>[] asyncFuncs)
        {
            var tasks = asyncFuncs.Select(af => af());

            await Task.WhenAll(tasks);
        }

        protected virtual async Task AfterInit()
        {

        }

        public bool HasErrorApi => !string.IsNullOrEmpty(_error);

        public void SetErrorApi(ApiException exception)
        {}

        public string GetErrorApi()
        {
            var error = _error;
            _error = string.Empty;
            return error;
        }
    }

    [AddINotifyPropertyChangedInterface]
    public class BaseViewModel<T> : BaseViewModel
    {
        public T Model { get; set; } = Activator.CreateInstance<T>();
    }
}
