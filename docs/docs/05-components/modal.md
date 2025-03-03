﻿---
title: Blazor Modal Component
description: Use Blazor Bootstrap modal component to add dialogs to your site for lightboxes, user notifications, or completely custom content.
image: https://i.imgur.com/tLiaEs6.jpg

sidebar_label: Modal
sidebar_position: 13
---

# Blazor Modal

Use Blazor Bootstrap modal component to add dialogs to your site for lightboxes, user notifications, or completely custom content.

## Parameters

| Name | Type | Description | Required | Default | Added Version |
|--|--|--|--|--|--|
| BodyCssClass | string | Additional body CSS class. | | | 1.0.0 |
| BodyTemplate | RenderFragment | Body template. | ✔️ | | 1.0.0 |
| ChildContent | RenderFragment | Specifies the content to be rendered inside the alert. | | | 1.0.0 |
| CloseOnEscape | bool | Indicates whether the modal closes when escape key is pressed. | | true | 1.0.0 |
| DialogCssClass | string | Additional CSS class for the dialog (div.modal-dialog element). | | | 1.0.0 |
| FooterCssClass | string | Footer css class. | | | 1.0.0 |
| FooterTemplate | RenderFragment | Footer template. | ✔️ | | 1.0.0 |
| Fullscreen | `ModalFullscreen` | Fullscreen behavior of the modal. | | `ModalFullscreen.Disabled` | 1.0.0 |
| HeaderTemplate | RenderFragment | Header template. | ✔️ | | 1.0.0 |
| HeaderCssClass | string | Additional header CSS class. | | | 1.0.0 |
| IsScrollable | bool | Allows modal body scroll. | | false | 1.0.0 |
| IsServiceModal | bool | Indicates whether the modal is related to a modal service or not. | | false | 1.9.4 |
| IsVerticallyCentered | bool | Shows the modal vertically in the center. | | false | 1.0.0 |
| ModalType | `ModalType` | Gets or sets the modal type. | | `ModalType.Light` | 1.9.5 |
| Size | `ModalSize` | Size of the modal. | | `ModalSize.Regular` | 1.0.0 |
| ShowCloseButton | bool | Indicates whether the modal shows close button in header. | | true | 1.0.0 |
| TabIndex | int | Gets or sets the tab index. | | -1 | 1.6.0 |
| Title | string | | ✔️ | | 1.0.0 |
| UseStaticBackdrop | bool | Indicates whether the modal uses a static backdrop. | | false | 1.0.0 |

## Methods

| Name | Description | Added Version |
|--|--|--|
| ShowAsync | Opens a modal. | 1.0.0 |
| ShowAsync<T\>(string title, Dictionary<string, object\> parameters = null) | Opens a modal. T is component. | 1.4.1 |
| HideAsync | Hides a modal. | 1.0.0 |

:::danger Asynchronous methods and transitions

All API methods are **asynchronous** and start a **transition**. They return to the caller as soon as the transition is started but **before it ends**. In addition, a method call on a **transitioning component will be ignored**.

:::

## Callback Events

| Event | Description | 
|--|--|
| OnShowing | This event fires immediately when the show instance method is called. |
| OnShown | This event is fired when an offcanvas element has been made visible to the user (will wait for CSS transitions to complete). |
| OnHiding | This event is fired immediately when the hide method has been called. |
| OnHidden | This event is fired when an offcanvas element has been hidden from the user (will wait for CSS transitions to complete). |
| OnHidePrevented | This event is fired when the modal is shown, its backdrop is static and a click outside the modal or an escape key press is performed with the keyboard option or data-bs-keyboard set to false. |

## How it works

Before getting started with BlazorBootstrap's modal component, be sure to read the following as our menu options have recently changed.

- Modals are built with HTML, CSS, and JavaScript. They're positioned over everything else in the document and remove scroll from the `<body>` so that modal content scrolls instead.
- Clicking on the modal "backdrop" will automatically close the modal.
- BlazorBootstrap only supports one modal window at a time. Nested modals aren't supported as we believe them to be poor user experiences.

## Examples

### Modal

Clicking the **Show Modal** button below, the modal will slide down and fade in from the top of the page.

<img src="https://i.imgur.com/aWbURjD.jpg" alt="Blazor Modal Component" />

```cshtml showLineNumbers
<Modal @ref="modal" Title="Modal title">
    <BodyTemplate>
        Modal body text goes here.
    </BodyTemplate>
    <FooterTemplate>
        <Button Color="ButtonColor.Secondary" @onclick="OnHideModalClick">Close</Button>
        <Button Color="ButtonColor.Primary">Save changes</Button>
    </FooterTemplate>
</Modal>

<Button Color="ButtonColor.Primary" @onclick="OnShowModalClick">Show Modal</Button>
```

```cs {2,6,11} showLineNumbers
@code {
    private Modal modal;

    private async Task OnShowModalClick()
    {
        await modal?.ShowAsync();
    }

    private async Task OnHideModalClick()
    {
        await modal?.HideAsync();
    }
}
```

[See demo here.](https://demos.blazorbootstrap.com/modals#examples)

### Dynamic component as modal

Render different components dynamically within the modal without iterating through possible types or using conditional logic.
If dynamically-rendered components have component parameters, pass them as an `IDictionary`. The `string` is the parameter's name, and the `object` is the parameter's value.

<img src="https://i.imgur.com/pzO4jaE.png" alt="Blazor Modal Component - Dynamic component as modal" />

```cshtml {1,11-13} showLineNumbers
<Modal @ref="modal" />

<Button Color="ButtonColor.Primary" @onclick="OnShowModalClick">Show Employee Component</Button>

@code {
    private Modal modal = default!;
    private string? message;

    private async Task OnShowModalClick()
    {
        var parameters = new Dictionary<string, object>();
        parameters.Add("EmployeeId", 321);
        await modal.ShowAsync<EmployeeDemoComponent1>(title: "Employee Details", parameters: parameters);
    }
}
```

**EmployeeDemoComponent1.razor**

```cshtml {} showLineNumbers
<div class="row">
    <div class="col-5 col-md-3 text-end">Employee Id :</div>
    <div class="col-7 col-md-9">@EmployeeId</div>
</div>
<div class="row">
    <div class="col-5 col-md-3 text-end">First Name :</div>
    <div class="col-7 col-md-9">@employee.FirstName</div>
</div>
<div class="row">
    <div class="col-5 col-md-3 text-end">Last Name :</div>
    <div class="col-7 col-md-9">@employee.LastName</div>
</div>

@code {
    private Employee employee;

    [Parameter] public int EmployeeId { get; set; }

    protected override void OnInitialized()
    {
        // get employee with {EmployeeId} from DB

        employee = new Employee { FirstName = "Vikram", LastName = "Reddy" };

        base.OnInitialized();
    }
}
```

[See demo here.](https://demos.blazorbootstrap.com/modals#dynamic-component-as-modal)

### Pass event callbacks to a dynamic component

Event callbacks `(EventCallback)` can be passed in its parameter dictionary.
In the following parent component example, the `ShowDTMessage` method assigns a string with the current time to `message`, and the value of `message` is rendered. The parent component passes the callback method, `ShowDTMessage` in the parameter dictionary:
- The `string` key is the callback method's name, `OnClickCallback`.
- The `object` value is created by `EventCallbackFactory.Create` for the parent callback method, `ShowDTMessage`.

<img src="https://i.imgur.com/dQMxYxw.png" alt="Blazor Modal Component - Pass event callbacks to a dynamic component" />

```cshtml {} showLineNumbers
<Modal @ref="modal" />

<Button Color="ButtonColor.Primary" @onclick="OnShowModalClick">Show Employee Component</Button>

<div class="mt-3">
    @message
</div>

@code {
    private Modal modal = default!;
    private string? message;

    private async Task OnShowModalClick()
    {
        var parameters = new Dictionary<string, object>();
        parameters.Add("EmployeeId", 322);
        parameters.Add("OnclickCallback", EventCallback.Factory.Create<MouseEventArgs>(this, ShowDTMessage));
        await modal.ShowAsync<EmployeeDemoComponent2>(title: "Employee Details", parameters: parameters);
    }

    private void ShowDTMessage(MouseEventArgs e) => message = $"The current DT is: {DateTime.Now}.";
}
```

**EmployeeDemoComponent2.razor**

```cshtml {} showLineNumbers
<div class="row">
    <div class="col-5 col-md-3 text-end">Employee Id :</div>
    <div class="col-7 col-md-9">@EmployeeId</div>
</div>
<div class="row">
    <div class="col-5 col-md-3 text-end">First Name :</div>
    <div class="col-7 col-md-9">@employee.FirstName</div>
</div>
<div class="row">
    <div class="col-5 col-md-3 text-end">Last Name :</div>
    <div class="col-7 col-md-9">@employee.LastName</div>
</div>

<Button class="mt-3" Color="ButtonColor.Success" Type="ButtonType.Button" @onclick="OnClickCallback">
    Trigger a Parent component method
</Button>

@code {
    private Employee employee;

    [Parameter] public int EmployeeId { get; set; }

    [Parameter] public EventCallback<MouseEventArgs> OnClickCallback { get; set; }

    protected override void OnInitialized()
    {
        // get employee with {EmployeeId} from DB

        employee = new Employee { FirstName = "Sagar", LastName = "Reddy" };

        base.OnInitialized();
    }
}
```

[See demo here.](https://demos.blazorbootstrap.com/modals#pass-event-callbacks-to-a-dynamic-component)

### Static backdrop

When `UseStaticBackdrop` is set to `true`, the modal will not close when clicking outside it. Click the button below to try it.

<img src="https://i.imgur.com/NeSfMIn.jpg" alt="Blazor Modal Component - Static backdrop" />

```cshtml {1} showLineNumbers
<Modal @ref="modal" title="Modal title" UseStaticBackdrop="true">
    <BodyTemplate>
        I will not close if you click outside me. Don't even try to press escape key.
    </BodyTemplate>
    <FooterTemplate>
        <Button Color="ButtonColor.Secondary" @onclick="OnHideModalClick">Close</Button>
        <Button Color="ButtonColor.Primary">Understood</Button>
    </FooterTemplate>
</Modal>

<Button Color="ButtonColor.Primary" @onclick="OnShowModalClick">Launch static backdrop modal</Button>
```

```cs showLineNumbers
@code {
    private Modal modal;

    private async Task OnShowModalClick()
    {
        await modal?.ShowAsync();
    }

    private async Task OnHideModalClick()
    {
        await modal?.HideAsync();
    }
}
```

[See demo here.](https://demos.blazorbootstrap.com/modals#static-backdrop)

### Scrolling long content

When modals become too long for the user’s viewport or device, they scroll independent of the page itself. Try the demo below to see what we mean.

<img src="https://i.imgur.com/7lrxeON.jpg" alt="Blazor Modal Component - Scrolling long content" />

```cshtml {1} showLineNumbers
<Modal @ref="modal" title="Modal title" IsScrollable="true">
    <BodyTemplate>
        <p style="margin-bottom: 100vh;">This is some placeholder content to show the scrolling behavior for modals. Instead of repeating the text the modal, we use an inline style set a minimum height, thereby extending the length of the overall modal and demonstrating the overflow scrolling. When content becomes longer than the height of the viewport, scrolling will move the modal as needed.</p>
        <p>This content should appear at the bottom after you scroll.</p>
    </BodyTemplate>
    <FooterTemplate>
        <Button Color="ButtonColor.Secondary" @onclick="OnHideModalClick">Close</Button>
        <Button Color="ButtonColor.Primary">Save changes</Button>
    </FooterTemplate>
</Modal>

<Button Color="ButtonColor.Primary" @onclick="OnShowModalClick">Launch demo modal</Button>
```

```cs showLineNumbers
@code {
    private Modal modal;

    private async Task OnShowModalClick()
    {
        await modal?.ShowAsync();
    }

    private async Task OnHideModalClick()
    {
        await modal?.HideAsync();
    }
}
```

[See demo here.](https://demos.blazorbootstrap.com/modals#scrolling-long-content)

### Vertically centered

Add `IsVerticallyCentered="true"` to vertically center the modal.

<img src="https://i.imgur.com/tLiaEs6.jpg" alt="Blazor Modal Component - Vertically centered" />

```cshtml {1} showLineNumbers
<Modal @ref="modal" title="Modal title" IsVerticallyCentered="true">
    <BodyTemplate>
        This is a vertically centered modal.
    </BodyTemplate>
    <FooterTemplate>
        <Button Color="ButtonColor.Secondary" @onclick="OnHideModalClick">Close</Button>
        <Button Color="ButtonColor.Primary">Save changes</Button>
    </FooterTemplate>
</Modal>

<Button Color="ButtonColor.Primary" @onclick="OnShowModalClick">Vertically centered modal</Button>
```

```cs showLineNumbers
@code {
    private Modal modal;

    private async Task OnShowModalClick()
    {
        await modal?.ShowAsync();
    }

    private async Task OnHideModalClick()
    {
        await modal?.HideAsync();
    }
}
```

[See demo here.](https://demos.blazorbootstrap.com/modals#vertically-centered)

### Vertically centered and scrollable

<img src="https://i.imgur.com/n0m4Fhq.jpg" alt="Blazor Modal Component - Vertically centered and scrollable" />

```cshtml {1} showLineNumbers
<Modal @ref="modal" title="Modal title" IsVerticallyCentered="true" IsScrollable="true">
    <BodyTemplate>
        <p style="margin-bottom: 100vh;">This is some placeholder content to show the scrolling behavior for modals. Instead of repeating the text the modal, we use an inline style set a minimum height, thereby extending the length of the overall modal and demonstrating the overflow scrolling. When content becomes longer than the height of the viewport, scrolling will move the modal as needed.</p>
        <p>This content should appear at the bottom after you scroll.</p>
    </BodyTemplate>
    <FooterTemplate>
        <Button Color="ButtonColor.Secondary" @onclick="OnHideModalClick">Close</Button>
        <Button Color="ButtonColor.Primary">Save changes</Button>
    </FooterTemplate>
</Modal>

<Button Color="ButtonColor.Primary" @onclick="OnShowModalClick">Vertically centered scrollable modal</Button>
```

```cs showLineNumbers
@code {
    private Modal modal;

    private async Task OnShowModalClick()
    {
        await modal?.ShowAsync();
    }

    private async Task OnHideModalClick()
    {
        await modal?.HideAsync();
    }
}
```

[See demo here.](https://demos.blazorbootstrap.com/modals#vertically-centered)

### Optional sizes

Modals have three optional sizes. These sizes kick in at certain breakpoints to avoid horizontal scrollbars on narrower viewports.

<img src="https://i.imgur.com/5vKfJQC.jpg" alt="Blazor Modal Component - Optional sizes" />

```cshtml {1,4,7} showLineNumbers
<Modal @ref="xlModal" title="Extra large modal" Size="ModalSize.ExtraLarge">
    <BodyTemplate>...</BodyTemplate>
</Modal>
<Modal @ref="lgModal" title="Large modal" Size="ModalSize.Large">
    <BodyTemplate>...</BodyTemplate>
</Modal>
<Modal @ref="smModal" title="Small modal" Size="ModalSize.Small">
    <BodyTemplate>...</BodyTemplate>
</Modal>

<Button Color="ButtonColor.Primary" @onclick="() => xlModal?.ShowAsync()">Extra large modal</Button>
<Button Color="ButtonColor.Primary" @onclick="() => lgModal?.ShowAsync()">Large modal</Button>
<Button Color="ButtonColor.Primary" @onclick="() => smModal?.ShowAsync()">Small modal</Button>
```

```cs showLineNumbers
@code {
    private Modal xlModal;
    private Modal lgModal;
    private Modal smModal;
}
```

[See demo here.](https://demos.blazorbootstrap.com/modals#optional-sizes)

### Fullscreen Modal

<img src="https://i.imgur.com/3dFUzMz.jpg" alt="Blazor Modal Component - Fullscreen Modal" />

```cshtml {1,4,7,10,13,16} showLineNumbers
<Modal @ref="modal" title="Full screen" Fullscreen="ModalFullscreen.Always">
    <BodyTemplate>...</BodyTemplate>
</Modal>
<Modal @ref="smModal" title="Full screen below sm" Fullscreen="ModalFullscreen.SmallDown">
    <BodyTemplate>...</BodyTemplate>
</Modal>
<Modal @ref="mdModal" title="Full screen below md" Fullscreen="ModalFullscreen.MediumDown">
    <BodyTemplate>...</BodyTemplate>
</Modal>
<Modal @ref="lgModal" title="Full screen below lg" Fullscreen="ModalFullscreen.LargeDown">
    <BodyTemplate>...</BodyTemplate>
</Modal>
<Modal @ref="xlModal" title="Full screen below xl" Fullscreen="ModalFullscreen.ExtraLargeDown">
    <BodyTemplate>...</BodyTemplate>
</Modal>
<Modal @ref="xxlModal" title="Full screen below xxl" Fullscreen="ModalFullscreen.ExtraExtraLargeDown">
    <BodyTemplate>...</BodyTemplate>
</Modal>

<Button Color="ButtonColor.Primary" @onclick="() => modal?.ShowAsync()">Full screen</Button>
<Button Color="ButtonColor.Primary" @onclick="() => smModal?.ShowAsync()">Full screen below sm</Button>
<Button Color="ButtonColor.Primary" @onclick="() => mdModal?.ShowAsync()">Full screen below md</Button>
<Button Color="ButtonColor.Primary" @onclick="() => lgModal?.ShowAsync()">Full screen below lg</Button>
<Button Color="ButtonColor.Primary" @onclick="() => xlModal?.ShowAsync()">Full screen below xl</Button>
<Button Color="ButtonColor.Primary" @onclick="() => xxlModal?.ShowAsync()">Full screen below xxl</Button>
```

```cs showLineNumbers
@code {
    private Modal modal;
    private Modal smModal;
    private Modal mdModal;
    private Modal lgModal;
    private Modal xlModal;
    private Modal xxlModal;
}
```

[See demo here.](https://demos.blazorbootstrap.com/modals#fullscreen-modal)

### Callback Events

BlazorBootstrap's modal class exposes a few events for hooking into modal functionality.

```cshtml {3-7} showLineNumbers
<Modal @ref="modal"
       title="Modal title"
       OnShowing="OnModalShowingAsync"
       OnShown="OnModalShownAsync"
       OnHiding="OnModalHidingAsync"
       OnHidden="OnModalHiddenAsync"
       OnHidePrevented="OnModalHidePreventedAsync">

    <BodyTemplate>
        Modal body text goes here.
    </BodyTemplate>

    <FooterTemplate>
        <Button Color="ButtonColor.Secondary" @onclick="OnHideModalClick">Close</Button>
        <Button Color="ButtonColor.Primary">Save changes</Button>
    </FooterTemplate>

</Modal>

<Button Color="ButtonColor.Primary" @onclick="OnShowModalClick">Show Modal</Button>
```

```cs showLineNumbers
@code {
    private Modal modal;

    private async Task OnModalShowingAsync()
    {
        await Task.Run(() => { Console.WriteLine("Event: Showing"); });
    }

    private async Task OnModalShownAsync()
    {
        await Task.Run(() => { Console.WriteLine("Event: Show"); });
    }

    private async Task OnModalHidingAsync()
    {
        await Task.Run(() => { Console.WriteLine("Event: Hiding"); });
    }

    private async Task OnModalHiddenAsync()
    {
        await Task.Run(() => { Console.WriteLine("Event: Hide"); });
    }

    private async Task OnModalHidePreventedAsync()
    {
        await Task.Run(() => { Console.WriteLine("Event: Hide Prevented"); });
    }
}
```

[See demo here.](https://demos.blazorbootstrap.com/modals#events)