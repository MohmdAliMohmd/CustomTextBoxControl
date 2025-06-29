# 📝 Clearable Textbox WPF Control

//https://www.youtube.com/watch?v=V86kaIBBcRk&t=383s

This WPF custom control provides an enhanced textbox with **placeholder text** and a **clear button** functionality.

## ✨ Features
- 🔍 Placeholder text that disappears when typing
- ❌ Clear button (X) to instantly reset content
- 🎨 Fully customizable styling
- ⚡ Real-time text change tracking
- 🖱️ Automatic focus management

## 🛠️ Installation
1. Add the `ClearableTextbox` control to your WPF project
2. Include the namespace in your XAML:
```xml
xmlns:custom="clr-namespace:CustomTextBoxControl.View.UserControls"
```

## 💻 Usage
**Basic implementation:**
```xml
<custom:ClearableTextbox 
    Placeholder="Enter your text here..."
    Width="250"
    Height="40"/>
```

**Custom properties:**
```xml
<custom:ClearableTextbox
    Placeholder="Search items..."
    FontSize="14"
    Foreground="Navy"
    ClearButtonForeground="Red"
    Margin="10"/>
```

## 🧩 Properties
| Property | Type | Description | Default |
|----------|------|-------------|---------|
| `Placeholder` | string | Hint text displayed when empty | "" |
| `Text` | string | Gets/sets the text content | "" |
| `PlaceholderForeground` | Brush | Color of placeholder text | DarkGray |
| `ClearButtonForeground` | Brush | Color of clear button | LightGray |
| `IsClearButtonVisible` | bool | Show/hide clear button | true |

## 🧾 Code Behind
The control handles text changes and button clicks automatically:
```csharp
private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
{
    tbPlaceholder.Visibility = string.IsNullOrEmpty(txtInput.Text) 
        ? Visibility.Visible 
        : Visibility.Hidden;
}

private void btnClear_Click(object sender, RoutedEventArgs e)
{
    txtInput.Clear();
    txtInput.Focus();
}
```

## 🎨 Customization Tips
**Change clear button appearance:**
```xml
<Style TargetType="{x:Type Button}" x:Key="CustomClearButton">
    <Setter Property="Content" Value="✕"/>
    <Setter Property="Foreground" Value="#FF5555"/>
    <Setter Property="FontWeight" Value="Bold"/>
</Style>
```

**Modify textbox styling:**
```xml
<custom:ClearableTextbox>
    <TextBox x:Name="txtInput" Background="#F5F5F5" 
             BorderBrush="#CCCCCC" BorderThickness="0 0 0 1"/>
</custom:ClearableTextbox>
```

## 🤝 Contributing
Pull requests are welcome! For major changes, please open an issue first to discuss proposed changes.

## 📄 License
[MIT](https://choosealicense.com/licenses/mit/)

---

**Happy coding!** 💻🚀
