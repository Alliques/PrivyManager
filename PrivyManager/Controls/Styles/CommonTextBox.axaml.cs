using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;
using Avalonia.Media;
using Avalonia.Styling;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Windows.Input;
using TextCopy;

namespace PrivyManager.Controls.Styles;

public class CommonTextBox : TextBox, IStyleable
{
    public bool? CopyIcon
    {
        get => GetValue(CopyIconProperty);
        set => SetValue(CopyIconProperty, value);
    }

    public static StyledProperty<bool> CopyIconProperty =
        AvaloniaProperty.Register<CommonTextBox, bool>(nameof(CopyIcon), defaultValue: true);

    public bool? RevealPasswordIcon
    {
        get => GetValue(RevealPasswordIconProperty);
        set => SetValue(RevealPasswordIconProperty, value);
    }

    public static StyledProperty<bool> RevealPasswordIconProperty =
        AvaloniaProperty.Register<CommonTextBox, bool>(nameof(RevealPasswordIcon), defaultValue: false);

    public Geometry? Icon
    {
        get => (Geometry?)GetValue(IconProperty);
        set => SetValue(IconProperty, value);
    }

    public static StyledProperty<Geometry> IconProperty =
        AvaloniaProperty.Register<CommonTextBox, Geometry>(nameof(Icon));

    public Brush? IconColor
    {
        get => (Brush)GetValue(IconColorProperty);
        set => SetValue(IconColorProperty, value);
    }

    public static StyledProperty<Brush> IconColorProperty =
        AvaloniaProperty.Register<CommonTextBox, Brush>(nameof(IconColor));


    public static readonly AvaloniaProperty<ICommand?> CopyCommandProperty =
     AvaloniaProperty.Register<CommonTextBox, ICommand?>(nameof(CopyCommand));

    public ICommand? CopyCommand
    {
        get => (ICommand)GetValue(CopyCommandProperty);
        set => SetValue(CopyCommandProperty, value);
    }

    public static readonly AvaloniaProperty<ICommand?> RevealPasswordCommandProperty =
        AvaloniaProperty.Register<CommonTextBox, ICommand?>(nameof(RevealPasswordCommand));

    public ICommand? RevealPasswordCommand
    {
        get => (ICommand)GetValue(RevealPasswordCommandProperty);
        set => SetValue(RevealPasswordCommandProperty, value);
    }

    public CommonTextBox()
    {
        CopyCommand = new RelayCommand(ExecuteCopyCommand);
        RevealPasswordCommand = new RelayCommand(ExecuteShowPasswordCommand);
    }

    private void ExecuteCopyCommand()
    {
        ClipboardService.SetText(Text);
    }

    private void ExecuteShowPasswordCommand()
    {
        RevealPassword = !RevealPassword;
    }
}