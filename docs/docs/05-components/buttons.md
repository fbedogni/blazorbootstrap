﻿---
title: Blazor Button Component
description: Use Blazor Bootstrap button styles for actions in forms, dialogs, and more with support for multiple sizes, states, etc.
image: https://i.imgur.com/Ne7FJ5H.jpg

sidebar_label: Buttons
sidebar_position: 5
---

# Blazor Buttons

Use Blazor Bootstrap button styles for actions in forms, dialogs, and more with support for multiple sizes, states, etc.

## Parameters

| Name | Type | Description | Required | Default | Added Version |
|:--|:--|:--|:--|:--|:--|
| Active | bool | When set to `true`, places the component in the active state with active styling. | | false | 1.0.0 |
| Block | bool | Makes the button to span the full width of a parent. | | false | 1.0.0 |
| ChildContent | RenderFragment | Specifies the content to be rendered inside this `Button`. | | | 1.0.0 |
| Color | `ButtonColor` | Gets or sets the button color. | ✔️ | | 1.0.0 |
| Disabled | bool | When set to `true`, disables the component's functionality and places it in a disabled state. | | false | 1.0.0 |
| Loading | bool | Shows the loading spinner or a `LoadingTemplate`. | | false | 1.0.0 |
| LoadingTemplate | RenderFragment | Gets or sets the component loading template. | | | 1.0.0 |
| LoadingText | string | Gets or sets the loadgin text. | | `Loading...` | 1.0.0 |
| Outline | bool | Makes the button to have the outlines. | | false | 1.0.0 |
| Position | `Position` | Gets or sets the position. | | | 1.7.0 |
| Size | `Size` | Changes the size of a button. | | | 1.0.0 |
| TabIndex | int? | If defined, indicates that its element can be focused and can participates in sequential keyboard navigation. | | | 1.0.0 |
| Target | `Target` | The target attribute specifies where to open the linked document for a `ButtonType.Link`. | | `Target.None` | 1.0.0 |
| To | string | Denotes the target route of the `ButtonType.Link` button. | | | 1.0.0 |
| TooltipPlacement | `TooltipPlacement` | Tooltip placement | | `TooltipPlacement.Top` | 1.0.0 |
| TooltipTitle | string | Displays informative text when users hover, focus, or tap an element. | | | 1.0.0 |
| TooltipColor | `TooltipColor` | Gets or sets the tooltip color. | | `TooltipColor.None` | 1.10.0 |
| Type | `ButtonType` | Defines the button type. | | `ButtonType.Button` | 1.0.0 |

## Methods

| Name | Description |
|--|--|
| ShowLoading | Shows the loading state and disables the button. |
| HideLoading | Hides the loading state and enables the button. |

## Examples

### Buttons

Blazor Bootstrap includes several predefined button styles, each serving its own semantic purpose, with a few extras thrown in for more control.

<img src="https://i.imgur.com/Ne7FJ5H.jpg" alt="Blazor Bootstrap: Button Component" />

```cshtml showLineNumbers
<p>
    <Button Color="ButtonColor.Primary"> Primary </Button>
    <Button Color="ButtonColor.Secondary"> Secondary </Button>
    <Button Color="ButtonColor.Success"> Success </Button>
    <Button Color="ButtonColor.Danger"> Danger </Button>
    <Button Color="ButtonColor.Warning"> Warning </Button>
    <Button Color="ButtonColor.Info"> Info </Button>
    <Button Color="ButtonColor.Light"> Light </Button>
    <Button Color="ButtonColor.Dark"> Dark </Button>
    <Button Color="ButtonColor.Link"> Link </Button>
</p>
```

[See buttons demo here.](https://demos.blazorbootstrap.com/buttons#examples)

### Button tags

<img src="https://i.imgur.com/ZscbcWh.jpg" alt="Blazor Bootstrap: Button Component - Button tags" />

```cshtml showLineNumbers
<p>
    <Button Type="ButtonType.Link" Color="ButtonColor.Primary" To="#"> Link </Button>
    <Button Type="ButtonType.Submit" Color="ButtonColor.Primary" To="#"> Button </Button>
</p>
```

[See button tags demo here.](https://demos.blazorbootstrap.com/buttons#button-tags)

### Outline Buttons

<img src="https://i.imgur.com/ta0Mgtk.jpg" alt="Blazor Bootstrap: Button Component - Outline Buttons" />

```cshtml showLineNumbers
<p>
    <Button Color="ButtonColor.Primary" Outline="true"> Primary </Button>
    <Button Color="ButtonColor.Secondary" Outline="true"> Secondary </Button>
    <Button Color="ButtonColor.Success" Outline="true"> Success </Button>
    <Button Color="ButtonColor.Danger" Outline="true"> Danger </Button>
    <Button Color="ButtonColor.Warning" Outline="true"> Warning </Button>
    <Button Color="ButtonColor.Info" Outline="true"> Info </Button>
    <Button Color="ButtonColor.Dark" Outline="true"> Dark </Button>
</p>
```

[See outline button demo here.](https://demos.blazorbootstrap.com/buttons#outline-buttons)

:::info
Some of the button styles use a relatively light foreground color, and should only be used on a dark background in order to have sufficient contrast.
:::

### Sizes

Fancy larger or smaller buttons? Add `Size="Size.Large"` or `Size="Size.Small"` for additional sizes.

<img src="https://i.imgur.com/Vdiyg6q.jpg" alt="Blazor Bootstrap: Button Component - Sizes" />

```cshtml showLineNumbers
<p>
    <Button Color="ButtonColor.Primary" Size="Size.Large"> Large button </Button>
    <Button Color="ButtonColor.Secondary" Size="Size.Large"> Large button </Button>
</p>
<p>
    <Button Color="ButtonColor.Primary" Size="Size.Small"> Small button </Button>
    <Button Color="ButtonColor.Secondary" Size="Size.Small"> Small button </Button>
</p>
```

[See buttons with different size demo here.](https://demos.blazorbootstrap.com/buttons#sizes)

### Disabled State

Make buttons look inactive by adding the `Disabled="true"` boolean parameter to any `<Button>` component. Disabled buttons have `pointer-events: none` applied to, preventing hover and active states from triggering.

:::info
Disabled buttons using the `Type="ButtonType.Link"` parameter behave a bit different.
:::

<img src="https://i.imgur.com/A0MlIha.jpg" alt="Blazor Bootstrap: Button Component - Disable State" />

```cshtml showLineNumbers
<p>
    <Button Color="ButtonColor.Primary" Size="Size.Large" Disabled="true"> Large button </Button>
    <Button Color="ButtonColor.Secondary" Size="Size.Large" Disabled="true"> Large button </Button>
</p>
<p>
    <Button Type="ButtonType.Link" Color="ButtonColor.Primary" Size="Size.Large" Disabled="true"> Primary link </Button>
    <Button Type="ButtonType.Link" Color="ButtonColor.Secondary" Size="Size.Large" Disabled="true"> Link </Button>
</p>
```

[See button disabled state demo here.](https://demos.blazorbootstrap.com/buttons#disabled-state)

### Disable and enable state dynamically

<img src="https://i.imgur.com/nKA9C8n.png" alt="Blazor Bootstrap: Button Component - Disable and enable state dynamically" />

```cshtml {} showLineNumbers
<Button Type="ButtonType.Link" Color="ButtonColor.Primary" Disabled="@disableButton" TooltipTitle="@tooltip">Link Button</Button>
<Button Type="ButtonType.Submit" Color="ButtonColor.Primary" Disabled="@disableButton" TooltipTitle="@tooltip">Submit Button</Button>
<Button Type="ButtonType.Button" Color="ButtonColor.Primary" Disabled="@disableButton" TooltipTitle="@tooltip">Button</Button>
<Button Type="ButtonType.Reset" Color="ButtonColor.Primary" Disabled="@disableButton" TooltipTitle="@tooltip">Reset Button</Button>

<Button Color="ButtonColor.Danger" @onclick="() => SwapDisable()">Swap Disable</Button>
```

```cshtml {} LineNumbers
@code
{
    bool disableButton = true;
    string tooltip = "";

    public void SwapDisable()
    {
        disableButton = !disableButton;
        tooltip = $"Updated at {DateTime.Now}";
    }
}
```

[See disable and enable state dynamically demo here.](https://demos.blazorbootstrap.com/buttons#disable-and-enable-state-dynamically)

### Block Buttons

Create responsive stacks of full-width, "block buttons" like those in Bootstrap 4 with a mix of our display and gap utilities. By using utilities instead of button specific classes, we have much greater control over spacing, alignment, and responsive behaviors.

<img src="https://i.imgur.com/jB7joKv.jpg" alt="Blazor Bootstrap: Button Component - Block Buttons" />

```cshtml showLineNumbers
<div class="d-grid gap-2">
    <Button Color="ButtonColor.Primary"> Button </Button>
    <Button Color="ButtonColor.Primary"> Button </Button>
</div>
```

<img src="https://i.imgur.com/iSsEMgi.jpg" alt="Blazor Bootstrap: Button Component - Block Buttons" />

```cshtml showLineNumbers
<div class="d-grid gap-2 d-md-block mt-2">
    <Button Color="ButtonColor.Primary"> Button </Button>
    <Button Color="ButtonColor.Primary"> Button </Button>
</div>
```

<img src="https://i.imgur.com/20LuzVC.jpg" alt="Blazor Bootstrap: Button Component - Block Buttons" />

```cshtml showLineNumbers
<div class="d-grid gap-2 col-6 mx-auto mt-2">
    <Button Color="ButtonColor.Primary"> Button </Button>
    <Button Color="ButtonColor.Primary"> Button </Button>
</div>
```

<img src="https://i.imgur.com/bJXgFkF.jpg" alt="Blazor Bootstrap: Button Component - Block Buttons" />

```cshtml showLineNumbers
<div class="d-grid gap-2 d-md-flex justify-content-md-end mt-2">
    <Button Color="ButtonColor.Primary"> Button </Button>
    <Button Color="ButtonColor.Primary"> Button </Button>
</div>
```

[See block buttons demo here.](https://demos.blazorbootstrap.com/buttons#block-buttons)

### Toogle States

If you''re pre-toggling a button, you must manually add the `Active="true"` parameter.

<img src="https://i.imgur.com/JH9SZxQ.jpg" alt="Blazor Bootstrap: Button Component - Button Toogle States" />

```cshtml showLineNumbers
<p>
    <Button Color="ButtonColor.Primary"> Toggle button </Button>
    <Button Color="ButtonColor.Primary" Active="true"> Active toggle button </Button>
    <Button Color="ButtonColor.Primary" Disabled="true"> Disabled toggle button </Button>
</p>
```

[See button toogle states demo here.](https://demos.blazorbootstrap.com/buttons#toggle-states)

### Loading spinner

Use spinners within buttons to indicate an action is currently processing or taking place. You may also swap the text out of the spinner element and utilize button text as needed.

<img src="https://i.imgur.com/ENKhcXR.jpg" alt="Blazor Bootstrap: Button Component - Button with Loading Spinner" />

```cshtml showLineNumbers
<p>
    <Button Color="ButtonColor.Primary" Loading="true" />
    <Button Color="ButtonColor.Primary" Loading="true" LoadingText="Saving..." />
    <Button Color="ButtonColor.Primary" Loading="true">
        <LoadingTemplate>
            <span class="spinner-grow spinner-grow-sm" role="status" aria-hidden="true"></span>
            Loading...
        </LoadingTemplate>
    </Button>
</p>
```

[See button with loading spinner demo here.](https://demos.blazorbootstrap.com/buttons#loading-spinner)

### Show/Hide loading spinner

Use `ShowLoading()` and `HideLoading()` methods to toggle the button state.

<img src="https://i.imgur.com/WDjEylB.png" alt="Blazor Bootstrap: Button Component - Show/Hide loading spinner" />

```cshtml showLineNumbers
<Button @ref="saveButton" Color="ButtonColor.Primary" @onclick="async () => await OnSaveClick()">Save</Button>
```

```csharp {2,6,10} showLineNumbers
@code {
    private Button saveButton;

    private async Task OnSaveClick()
    {
        saveButton?.ShowLoading("Saving details...");

        await Task.Delay(5000); // API call

        saveButton?.HideLoading();
    }
}
```

[See button with loading spinner demo here.](https://demos.blazorbootstrap.com/buttons#show-hide-loading-spinner)

### Show Tooltip

Hover over the buttons below to see the four tooltips directions: top, right, bottom, and left.

<img src="https://i.imgur.com/zp3G6pZ.jpg" alt="Blazor Bootstrap: Button Component - Buttons with Tooltip" />

```cshtml showLineNumbers
<p>
    <Button Color="ButtonColor.Primary" TooltipTitle="Tooltip text" TooltipPlacement="TooltipPlacement.Top"> Tooltip Top </Button>

    <Button Color="ButtonColor.Primary" TooltipTitle="Tooltip text" TooltipPlacement="TooltipPlacement.Right"> Tooltip Right </Button>

    <Button Color="ButtonColor.Primary" TooltipTitle="Tooltip text" TooltipPlacement="TooltipPlacement.Bottom"> Tooltip Bottom </Button>

    <Button Color="ButtonColor.Primary" TooltipTitle="Tooltip text" TooltipPlacement="TooltipPlacement.Left"> Tooltip Left </Button>
</p>
```

[See button with tooltip demo here.](https://demos.blazorbootstrap.com/buttons#tooltip)

:::caution NOTE
HTML tooltips not supported at this moment.
:::

### Dynamically update the tooltip text

```cshtml showLineNumbers
<div class="mb-3">
    <Button Color="ButtonColor.Primary" TooltipTitle="@text" TooltipPlacement="TooltipPlacement.Top"> Tooltip Top </Button>
</div>

<Button Type="ButtonType.Button" Color="ButtonColor.Primary" @onclick="ChangeTooltip">Change Tooltip</Button>
```
```csharp
@code {
    private string text = "Tooltip text";

    private void ChangeTooltip() => text = $"Updated {DateTime.Now.ToLongTimeString()}";
}
```

[See demo here.](https://demos.blazorbootstrap.com/buttons#dynamically-update-the-tooltip-text)

### Events

#### Click events

```cshtml showLineNumbers
<p>
    <Button Color="ButtonColor.Primary" @onclick="OnClick"> Click Event </Button>
</p>
```

```cs showLineNumbers
@code{

    protected void OnClick(EventArgs args)
    {
        Console.WriteLine("click event");
    }

}
```

#### Double click event

```cshtml showLineNumbers
<p>
    <Button Color="ButtonColor.Primary" @ondblclick="OnDoubleClick"> Double Click Event </Button>
</p>
```

```cs showLineNumbers
@code{

    protected void OnDoubleClick(EventArgs args)
    {
        Console.WriteLine("double click event");
    }

}
```

#### Click event with arguments

```cshtml showLineNumbers
<p>
    <Button Color="ButtonColor.Primary" @onclick="((args) => OnClickWithArgs(args, message))"> Click   Args </Button>
</p>
```

```cs showLineNumbers
@code{

    public string message = "Test message";

    protected void OnClickWithArgs(EventArgs args, string message)
    {
        Console.WriteLine($"message: {message}");
    }

}
```

[See button click events demo here.](https://demos.blazorbootstrap.com/buttons#click-events)