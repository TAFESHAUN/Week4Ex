using Microsoft.Maui;

namespace Week4.Controls;

public partial class Card : ContentView
{


    //PROP PATHS FOR CUSTOM UI
    public static readonly BindableProperty CardTitleProperty = BindableProperty.Create(nameof(CardTitle), typeof(string), typeof(Card), string.Empty);
    public static readonly BindableProperty BorderColorProperty = BindableProperty.Create(nameof(BorderColor), typeof(Color), typeof(Card), defaultValue: Colors.Coral);//TAKING THE FALL
    public static readonly BindableProperty CardDescriptionProperty = BindableProperty.Create(nameof(CardDescription), typeof(string), typeof(Card), string.Empty);
    public static readonly BindableProperty CardColorProperty = BindableProperty.Create(nameof(CardColor), typeof(Color), typeof(Card), defaultValue: Colors.Beige);//TAKING THE FALLBACK
    public static readonly BindableProperty IconImageSourceProperty = BindableProperty.Create(nameof(IconImageSource), typeof(string), typeof(Card), string.Empty);
    public static readonly BindableProperty IconBackgroundColorProperty = BindableProperty.Create(nameof(IconBackgroundColor), typeof(Color), typeof(Card), defaultValue: Colors.Grey);//TAKING THE FALL

    //Overide the fallback property -> set my property path and then set the defualt to this on the called property PATH
    //public static readonly BindableProperty FallBackProperty = BindableProperty.Create(nameof(FallBackColor), typeof(Color), typeof(Card), defaultValue: Colors.Grey);
    //public Color FallBackColor
    //{
    //    get => (Color)GetValue(Card.FallBackProperty);
    //    set => SetValue(Card.FallBackProperty, value);
    //}
    //PROPS
    public string CardTitle
    {
        get => (string)GetValue(Card.CardTitleProperty);
        set => SetValue(Card.CardTitleProperty, value);
    }

    public Color BorderColor
    {
        get => (Color)GetValue(Card.BorderColorProperty);
        set => SetValue(Card.BorderColorProperty, value);
    }

    public string CardDescription
    {
        get => (string)GetValue(Card.CardDescriptionProperty);
        set => SetValue(Card.CardDescriptionProperty, value);
    }

    public Color CardColor
    {
        get => (Color)GetValue(Card.CardColorProperty);
        set => SetValue(Card.CardColorProperty, value);
    }

    public string IconImageSource
    {
        get => (string)GetValue(Card.IconImageSourceProperty);
        set => SetValue(Card.IconImageSourceProperty, value);
    }
    
    public Color IconBackgroundColor
    {
        get => (Color)GetValue(Card.IconBackgroundColorProperty);
        set => SetValue(Card.IconBackgroundColorProperty, value);
    }

    public Card()
    {
        InitializeComponent();
    }
}