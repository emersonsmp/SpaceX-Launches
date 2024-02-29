namespace MyApp.Shared.Components;

public partial class EntryComponent : ContentView
{
    public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string), typeof(EntryComponent), default(string), defaultBindingMode: BindingMode.TwoWay);

    public EntryComponent()
    {
        InitializeComponent();
        myEntry.BindingContext = this;
        frame.BindingContext = this;
    }

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    protected override void OnPropertyChanged(string propertyName = null)
    {
        if (propertyName == nameof(Text))
            return;
    }
}