using PropertyChanged;
using System.Text;

namespace MyApp.Shared.Models
{
    [AddINotifyPropertyChangedInterface]
    public class BaseModel
    {
        public virtual bool IsValid { get; }

        [DoNotNotify]
        public StringBuilder Errors { get; } = new StringBuilder();

        public virtual void ResetError() => Errors.Clear();
    }
}
