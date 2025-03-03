﻿---
title: Blazor Card Component
description: BootstrapBootstrap's cards provide a flexible and extensible content container with multiple variants and options.
image: https://i.imgur.com/RhytwPa.png

sidebar_label: Card
sidebar_position: 7
---

# Blazor Card

BootstrapBootstrap's cards provide a flexible and extensible content container with multiple variants and options.

<img src="https://i.imgur.com/RhytwPa.png" alt="Blazor Bootstrap: Card component" />

## About

A card is a flexible and extensible content container. It includes options for headers and footers, a wide variety of content, contextual background colors, and powerful display options.

## Parameters

### Card Parameters

| Name | Type | Description | Required | Default | Added Version |
|:--|:--|:--|:--|:--|:--|
| ChildContent | RenderFragment | Specifies the content to be rendered inside this. | ✔️ | | 1.10.0 |
| Color | `CardColor` | Gets or sets the card color. | | `CardColor.None` | 1.10.0 |
| TextAlignment | `Alignment` | Gets or sets the text alignment of the card. | | `Alignment.None` | 1.10.0 |

### CardBody Parameters

| Name | Type | Description | Required | Default | Added Version |
|:--|:--|:--|:--|:--|:--|
| ChildContent | RenderFragment | Specifies the content to be rendered inside this. | ✔️ | | 1.10.0 |

### CardFooter Parameters

| Name | Type | Description | Required | Default | Added Version |
|:--|:--|:--|:--|:--|:--|
| ChildContent | RenderFragment | Specifies the content to be rendered inside this. | ✔️ | | 1.10.0 |

### CardGroup Parameters

| Name | Type | Description | Required | Default | Added Version |
|:--|:--|:--|:--|:--|:--|
| ChildContent | RenderFragment | Specifies the content to be rendered inside this. | ✔️ | | 1.10.0 |

### CardHeader Parameters

| Name | Type | Description | Required | Default | Added Version |
|:--|:--|:--|:--|:--|:--|
| ChildContent | RenderFragment | Specifies the content to be rendered inside this. | ✔️ | | 1.10.0 |

### CardLink Parameters

| Name | Type | Description | Required | Default | Added Version |
|:--|:--|:--|:--|:--|:--|
| ChildContent | RenderFragment | Specifies the content to be rendered inside this. | ✔️ | | 1.10.0 |
| Disabled | bool | When set to 'true', disables the component's functionality and places it in a disabled state. | | | 1.10.0 |
| To | `string?` | Gets or sets the target route. | ✔️ | | 1.10.0 |
| Target | `Target` | The target attribute specifies where to open the linked document. | | `Target.None` | 1.10.0 |
| TabIndex | `int?` | If defined, indicates that its element can be focused and can participates in sequential keyboard navigation. | | | 1.10.0 |

### CardSubTitle Parameters

| Name | Type | Description | Required | Default | Added Version |
|:--|:--|:--|:--|:--|:--|
| ChildContent | RenderFragment | Specifies the content to be rendered inside this. | ✔️ | | 1.10.0 |
| Size | `HeadingSize` | Gets or sets the heading size. | | `HeadingSize.H6` | 1.10.0 |

### CardText Parameters

| Name | Type | Description | Required | Default | Added Version |
|:--|:--|:--|:--|:--|:--|
| ChildContent | RenderFragment | Specifies the content to be rendered inside this. | ✔️ | | 1.10.0 |

### CardTitle Parameters

| Name | Type | Description | Required | Default | Added Version |
|:--|:--|:--|:--|:--|:--|
| ChildContent | RenderFragment | Specifies the content to be rendered inside this. | ✔️ | | 1.10.0 |
| Size | `HeadingSize` | Gets or sets the heading size. | | `HeadingSize.H5` | 1.10.0 |

## Examples

### Card

Below is an example of a basic card with mixed content and a fixed width. Cards have no fixed width to start, so they'll naturally fill the full width of its parent element.

<img src="https://i.imgur.com/wT0LXMG.png" alt="Blazor Bootstrap: Card Component - Examples" />

```cshtml {} showLineNumbers
<Card Style="width:18rem;">
    <CardBody>
        <CardTitle>Card title</CardTitle>
        <CardText>Some quick example text to build on the card title and make up the bulk of the card's content.</CardText>
        <Button Color="ButtonColor.Primary" To="#" Type="ButtonType.Link">Go somewhere</Button>
    </CardBody>
</Card>
```

[See the demo here.](https://demos.blazorbootstrap.com/card#examples)

### Content types

Cards support a wide variety of content, including images, text, list groups, links, and more. Below are examples of what’s supported.

### Body

The building block of a card is the CardBody. Use it whenever you need a padded section within a card.

<img src="https://i.imgur.com/jkWQdNr.png" alt="Blazor Bootstrap: Card Component - Body" />

```cshtml {} showLineNumbers
<Card>
    <CardBody>
        This is some text within a card body.
    </CardBody>
</Card>
```

[See the demo here.](https://demos.blazorbootstrap.com/card#body)

### Titles, text, and links

<img src="https://i.imgur.com/9ezoKyR.png" alt="Blazor Bootstrap: Card Component - Titles, text, and links" />

```cshtml {} showLineNumbers
<Card Style="width:18rem;">
    <CardBody>
        <CardTitle>Card title</CardTitle>
        <CardSubTitle Class="mb-2 text-muted">Card subtitle</CardSubTitle>
        <CardText>Some quick example text to build on the card title and make up the bulk of the card's content.</CardText>
        <CardLink To="#">Card link</CardLink>
        <CardLink To="#">Another link</CardLink>
    </CardBody>
</Card>
```

[See the demo here.](https://demos.blazorbootstrap.com/card#titles-text-and-links)

### Images

<img src="https://i.imgur.com/LpUuK6C.png" alt="Blazor Bootstrap: Card Component - Images" />

```cshtml {} showLineNumbers
<Card Class="mb-4" Style="width:18rem;">
    <img class="rounded-top" src="/images/placeholder.png" alt="placeholder" />
    <CardBody>
        <CardTitle>Card title</CardTitle>
        <CardSubTitle Class="mb-2 text-muted">Card subtitle</CardSubTitle>
        <CardText>Some quick example text to build on the card title and make up the bulk of the card's content.</CardText>
        <Button Color="ButtonColor.Primary" To="#" Type="ButtonType.Link">Go somewhere</Button>
    </CardBody>
</Card>

<Card Style="width:18rem;">
    <CardBody>
        <CardTitle>Card title</CardTitle>
        <CardSubTitle Class="mb-2 text-muted">Card subtitle</CardSubTitle>
        <CardText>Some quick example text to build on the card title and make up the bulk of the card's content.</CardText>
        <Button Color="ButtonColor.Primary" To="#" Type="ButtonType.Link">Go somewhere</Button>
    </CardBody>
    <img class="rounded-bottom" src="/images/placeholder.png" alt="placeholder" />
</Card>
```

[See the demo here.](https://demos.blazorbootstrap.com/card#images)

### List groups

Create lists of content in a card with a flush list group.

<img src="https://i.imgur.com/cxLiBhE.png" alt="Blazor Bootstrap: Card Component - List groups" />

```cshtml {} showLineNumbers
<Card Style="width:18rem;">
    <ul class="list-group list-group-flush">
        <li class="list-group-item">An item</li>
        <li class="list-group-item">A second item</li>
        <li class="list-group-item">A third item</li>
    </ul>
</Card>
```

[See the demo here.](https://demos.blazorbootstrap.com/card#list-groups)

### Kitchen sink

Mix and match multiple content types to create the card you need, or throw everything in there. 
Shown below are image styles, blocks, text styles, and a list group—all wrapped in a fixed-width card.

<img src="https://i.imgur.com/zsfdUnC.png" alt="Blazor Bootstrap: Card Component - Kitchen sink" />

```cshtml {} showLineNumbers
<Card Style="width:18rem;">
    <img class="rounded-top" src="/images/placeholder.png" alt="placeholder" />
    <CardBody>
        <CardTitle>Card title</CardTitle>
        <CardText>Some quick example text to build on the card title and make up the bulk of the card's content.</CardText>
    </CardBody>
    <ul class="list-group list-group-flush">
        <li class="list-group-item">An item</li>
        <li class="list-group-item">A second item</li>
        <li class="list-group-item">A third item</li>
    </ul>
    <CardBody>
        <CardLink To="#">Card link</CardLink>
        <CardLink To="#">Another link</CardLink>
    </CardBody>
</Card>
```

[See the demo here.](https://demos.blazorbootstrap.com/card#kitchen-sink)

### Header and footer

Add an optional header and/or footer within a card.

<img src="https://i.imgur.com/lNWvitv.png" alt="Blazor Bootstrap: Card Component - Header and footer" />

```cshtml {} showLineNumbers
<Card Style="width:18rem;">
    <CardHeader>
        Featured
    </CardHeader>
    <CardBody>
        <CardTitle>Special title treatment</CardTitle>
        <CardText>With supporting text below as a natural lead-in to additional content.</CardText>
        <Button Color="ButtonColor.Primary" To="#" Type="ButtonType.Link">Go somewhere</Button>
    </CardBody>
</Card>
```

[See the demo here.](https://demos.blazorbootstrap.com/card#header-and-footer)

### Sizing

Cards assume no specific width to start, so they’ll be 100% wide unless otherwise stated. 
You can change this as needed with custom CSS, grid classes, grid Sass mixins, or utilities.

<img src="https://i.imgur.com/AszIQT5.png" alt="Blazor Bootstrap: Card Component - Sizing" />

```cshtml {} showLineNumbers
<div class="row">
    <div class="col-sm-6">
        <Card>
            <CardBody>
                <CardTitle>Special title treatment</CardTitle>
                <CardText>With supporting text below as a natural lead-in to additional content.</CardText>
                <Button Color="ButtonColor.Primary" To="#" Type="ButtonType.Link">Go somewhere</Button>
            </CardBody>
        </Card>
    </div>
    <div class="col-sm-6">
        <Card>
            <CardBody>
                <CardTitle>Special title treatment</CardTitle>
                <CardText>With supporting text below as a natural lead-in to additional content.</CardText>
                <Button Color="ButtonColor.Primary" To="#" Type="ButtonType.Link">Go somewhere</Button>
            </CardBody>
        </Card>
    </div>
</div>
```

[See the demo here.](https://demos.blazorbootstrap.com/card#sizing)

### Text alignment

You can quickly change the text alignment of any card—in its entirety or specific parts—with our TextAlignment parameter.

<img src="https://i.imgur.com/tJdeAKt.png" alt="Blazor Bootstrap: Card Component - Text alignment" />

```cshtml {} showLineNumbers
<Card Class="mb-4" Style="width:18rem;">
    <CardBody>
        <CardTitle>Special title treatment</CardTitle>
        <CardText>With supporting text below as a natural lead-in to additional content.</CardText>
        <Button Color="ButtonColor.Primary" To="#" Type="ButtonType.Link">Go somewhere</Button>
    </CardBody>
</Card>

<Card TextAlignment="Alignment.Center" Class="mb-4" Style="width:18rem;">
    <CardBody>
        <CardTitle>Special title treatment</CardTitle>
        <CardText>With supporting text below as a natural lead-in to additional content.</CardText>
        <Button Color="ButtonColor.Primary" To="#" Type="ButtonType.Link">Go somewhere</Button>
    </CardBody>
</Card>

<Card TextAlignment="Alignment.End" Class="mb-4" Style="width:18rem;">
    <CardBody>
        <CardTitle>Special title treatment</CardTitle>
        <CardText>With supporting text below as a natural lead-in to additional content.</CardText>
        <Button Color="ButtonColor.Primary" To="#" Type="ButtonType.Link">Go somewhere</Button>
    </CardBody>
</Card>
```

[See the demo here.](https://demos.blazorbootstrap.com/card#text-alignment)

### Background and color

<img src="https://i.imgur.com/FH7aQPS.png" alt="Blazor Bootstrap: Card Component - Background and color - Primary, Secondary, Success" />

<img src="https://i.imgur.com/1ukTnup.png" alt="Blazor Bootstrap: Card Component - Background and color - Danger, Warning, Info" />

<img src="https://i.imgur.com/uCvHXXp.png" alt="Blazor Bootstrap: Card Component - Background and color - Light, Dark" />

```cshtml {} showLineNumbers
<Card Color="CardColor.Primary" Class="mb-4" Style="width:18rem;">
    <CardHeader>Header</CardHeader>
    <CardBody>
        <CardTitle>Primary card title</CardTitle>
        <CardText>Some quick example text to build on the card title and make up the bulk of the card's content.</CardText>
    </CardBody>
</Card>

<Card Color="CardColor.Secondary" Class="mb-4" Style="width:18rem;">
    <CardHeader>Header</CardHeader>
    <CardBody>
        <CardTitle>Secondary card title</CardTitle>
        <CardText>Some quick example text to build on the card title and make up the bulk of the card's content.</CardText>
    </CardBody>
</Card>

<Card Color="CardColor.Success" Class="mb-4" Style="width:18rem;">
    <CardHeader>Header</CardHeader>
    <CardBody>
        <CardTitle>Success card title</CardTitle>
        <CardText>Some quick example text to build on the card title and make up the bulk of the card's content.</CardText>
    </CardBody>
</Card>

<Card Color="CardColor.Danger" Class="mb-4" Style="width:18rem;">
    <CardHeader>Header</CardHeader>
    <CardBody>
        <CardTitle>Danger card title</CardTitle>
        <CardText>Some quick example text to build on the card title and make up the bulk of the card's content.</CardText>
    </CardBody>
</Card>

<Card Color="CardColor.Warning" Class="mb-4" Style="width:18rem;">
    <CardHeader>Header</CardHeader>
    <CardBody>
        <CardTitle>Warning card title</CardTitle>
        <CardText>Some quick example text to build on the card title and make up the bulk of the card's content.</CardText>
    </CardBody>
</Card>

<Card Color="CardColor.Info" Class="mb-4" Style="width:18rem;">
    <CardHeader>Header</CardHeader>
    <CardBody>
        <CardTitle>Info card title</CardTitle>
        <CardText>Some quick example text to build on the card title and make up the bulk of the card's content.</CardText>
    </CardBody>
</Card>

<Card Color="CardColor.Light" Class="mb-4" Style="width:18rem;">
    <CardHeader>Header</CardHeader>
    <CardBody>
        <CardTitle>Light card title</CardTitle>
        <CardText>Some quick example text to build on the card title and make up the bulk of the card's content.</CardText>
    </CardBody>
</Card>

<Card Color="CardColor.Dark" Class="mb-4" Style="width:18rem;">
    <CardHeader>Header</CardHeader>
    <CardBody>
        <CardTitle>Dark card title</CardTitle>
        <CardText>Some quick example text to build on the card title and make up the bulk of the card's content.</CardText>
    </CardBody>
</Card>
```
[See the demo here.](https://demos.blazorbootstrap.com/card#background-and-color)

### Card groups

Use card groups to render cards as a single, attached element with equal width and height columns. 
Card groups start off stacked and use display: flex; to become attached with uniform dimensions starting at the sm breakpoint.

<img src="https://i.imgur.com/dtYEkBB.png" alt="Blazor Bootstrap: Card Component - Card groups" />

```cshtml {} showLineNumbers
<CardGroup>
    <Card Class="mb-4" Style="width:18rem;">
        <img src="/images/placeholder.png" alt="placeholder" />
        <CardBody>
            <CardTitle>Card title</CardTitle>
            <CardText>This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</CardText>
            <CardText Class="text-muted">Last updated 3 mins ago</CardText>
        </CardBody>
    </Card>
    <Card Class="mb-4" Style="width:18rem;">
        <img src="/images/placeholder.png" alt="placeholder" />
        <CardBody>
            <CardTitle>Card title</CardTitle>
            <CardText>This card has supporting text below as a natural lead-in to additional content.</CardText>
            <CardText Class="text-muted">Last updated 3 mins ago</CardText>
        </CardBody>
    </Card>
    <Card Class="mb-4" Style="width:18rem;">
        <img src="/images/placeholder.png" alt="placeholder" />
        <CardBody>
            <CardTitle>Card title</CardTitle>
            <CardText>This is a wider card with supporting text below as a natural lead-in to additional content. This card has even longer content than the first to show that equal height action.</CardText>
            <CardText Class="text-muted">Last updated 3 mins ago</CardText>
        </CardBody>
    </Card>
</CardGroup>
```

[See the demo here.](https://demos.blazorbootstrap.com/card#card-groups)

### Card groups with footer

When using card groups with footers, their content will automatically line up.

<img src="https://i.imgur.com/URxKosx.png" alt="Blazor Bootstrap: Card Component - Card groups with footer" />

```cshtml {} showLineNumbers
<CardGroup>
    <Card Class="mb-4" Style="width:18rem;">
        <img src="/images/placeholder.png" alt="placeholder" />
        <CardBody>
            <CardTitle>Card title</CardTitle>
            <CardText>This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</CardText>
        </CardBody>
        <CardFooter>
            <small class="text-muted">Last updated 3 mins ago</small>
        </CardFooter>
    </Card>
    <Card Class="mb-4" Style="width:18rem;">
        <img src="/images/placeholder.png" alt="placeholder" />
        <CardBody>
            <CardTitle>Card title</CardTitle>
            <CardText>This card has supporting text below as a natural lead-in to additional content.</CardText>
        </CardBody>
        <CardFooter>
            <small class="text-muted">Last updated 3 mins ago</small>
        </CardFooter>
    </Card>
    <Card Class="mb-4" Style="width:18rem;">
        <img src="/images/placeholder.png" alt="placeholder" />
        <CardBody>
            <CardTitle>Card title</CardTitle>
            <CardText>This is a wider card with supporting text below as a natural lead-in to additional content. This card has even longer content than the first to show that equal height action.</CardText>
        </CardBody>
        <CardFooter>
            <small class="text-muted">Last updated 3 mins ago</small>
        </CardFooter>
    </Card>
</CardGroup>
```

[See the demo here.](https://demos.blazorbootstrap.com/card#card-groups-with-footer)
