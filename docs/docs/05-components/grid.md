﻿---
title: Blazor Grid Component
description: Use Blazor Bootstrap grid component to display tabular data from the data source. And it supports client-side and server-side paging & sorting.
image: https://i.imgur.com/kKNgo2I.png

sidebar_label: Grid
sidebar_position: 12
---

# Blazor Grid

Use Blazor Bootstrap grid component to display tabular data from the data source. And it supports client-side and server-side paging & sorting.

<img src="https://i.imgur.com/kKNgo2I.png" alt="Blazor Bootstrap: Grid Component" />

## Grid Parameters

| Name | Type | Default | Required | Description | Added Version |
|:--|:--|:--|:--|:--|:--|
| AllowFiltering | bool | false | | Gets or sets the grid filtering. | 1.0.0 |
| AllowPaging | bool | false | | Gets or sets the grid paging. | 1.0.0 |
| AllowRowClick | bool | false | | Gets or sets the allow row click. | 1.9.5 |
| AllowSelection | bool | false | | Gets or sets the grid selection. | 1.8.0 |
| AllowSorting | bool | false | | Gets or sets the grid sorting. | 1.0.0 |
| ChildContent | RenderFragment | | ✔️ | Specifies the content to be rendered inside the grid. | 1.0.0 |
| Data | `IEnumerable<TItem>` | | | Gets or sets the grid data. | 1.4.3 |
| DataProvider | `GridDataProviderDelegate<TItem>` | | | DataProvider is for items to render. The provider should always return an instance of `GridDataProviderResult`, and `null` is not allowed. | 1.0.0 |
| DisableAllRowsSelection | `Func<IEnumerable<TItem>, bool>?` | | | Enable or disable the header checkbox selection. | 1.8.0 |
| DisableRowSelection | `Func<TItem, bool>?` | | | Enable or disable the row level checkbox selection. | 1.8.0 |
| EmptyDataTemplate | RenderFragment | | ✔️ | Template to render when there are no rows to display. | 1.0.0 |
| EmptyText | string | No records to display | | Shows text on no records. | 1.0.0 |
| FiltersRowCssClass | string | | | Gets or sets the filters row css class. | 1.9.2 |
| FiltersTranslationProvider | `GridFiltersTranslationDelegate` | | | Filters transalation is for grid filters to render. The provider should always return a 'FilterOperatorInfo' collection, and 'null' is not allowed. | 1.10.0 |
| HeaderRowCssClass | string | | | Gets or sets the header row css class but not the thead tag class. | 1.9.2 |
| ItemsPerPageText | string | `Items per page` | ✔️ | Gets or sets the ItemsPerPageText. | 1.9.5 |
| PageSize | int | 10 | | Gets or sets the page size of the grid. | 1.0.0 |
| PageSizeSelectorItems | int[] | new int[] { 10, 20, 50 } | ✔️ | Gets or sets the page size selector items. | 1.8.0 |
| PageSizeSelectorVisible | bool | false | ✔️ | Gets or sets the page size selector visible. | 1.8.0 |
| PaginationItemsTextFormat | string | `{0} - {1} of {2} items` | ✔️ | Gets or sets the pagination items text format. | 1.8.0 |
| RowClass | Func<TItem, string>? | | | Gets or sets the row class. | 1.6.0 |
| Responsive | bool | false | | Gets or sets a value indicating whether Grid is responsive. | 1.0.0 |
| SelectionMode | `GridSelectionMode` | | | Gets or sets the grid selection mode. | 1.8.0 |
| SettingsProvider | `GridSettingsProviderDelegate` | | | Settings are for the grid to render. The provider should always return an instance of 'GridSettings', and 'null' is not allowed. | 1.0.0 |

:::note IMPORTANT
Grid requires either `Data` or `DataProvider` parameter, but not both.
:::

## Grid Callback Events

| Name | Type | Description | Added Version |
|:--|:--|:--|:--|
| GridSettingsChanged | `EventCallback<GridSettings>` | This event is fired when the grid state is changed. | 1.0.0 |
| OnRowClick | `EventCallback<GridRowEventArgs<TItem>>` | This event is triggered when the user clicks on the row. Set AllowRowClick to true to enable row clicking. | 1.9.5 |
| OnRowDoubleClick | `EventCallback<GridRowEventArgs<TItem>>` | This event is triggered when the user double clicks on the row. Set AllowRowClick to true to enable row double clicking. | 1.9.5 |
| SelectedItemsChanged | `EventCallback<HashSet<TItem>>` | This event is fired when the items selection changed. | 1.8.0 |

## Grid Methods
| Name | Return Type | Description | Added Version |
|:--|:--|:--|:--|
| GetFilters() | `IEnumerable<FilterItem>` | Get filters. | 1.0.0 |
| RefreshDataAsync(CancellationToken cancellationToken = default) | Task | Refresh the grid data. | 1.0.0 |
| ResetPageNumber() | ValueTask | Reset the page number to 1 and refresh the grid. | 1.4.3 |

## GridColumn Parameters

| Name | Type | Default | Required | Description | Added Version |
|:--|:--|:--|:--|:--|:--|
| ChildContent | RenderFragment | | ✔️ | Specifies the content to be rendered inside the grid column. | 1.0.0 |
| ColumnClass | Func<TItem, string>? | | | Gets or sets the column class. | 1.6.0 |
| Filterable | bool | true | | Enable or disable the filter on a specific column. The filter is enabled or disabled based on the grid `AllowFiltering` parameter. | 1.0.0 |
| FilterOperator | enum | Assigned based on the property type. | | Gets or sets the filter operator. | 1.0.0 |
| FilterTextboxWidth | int | | | Gets or sets the filter textbox width in pixels. | 1.0.0 |
| FilterValue | string | | | Gets or sets the filter value. | 1.0.0 |
| HeaderContent | RenderFragment | | | Specifies the content to be rendered inside the grid column header. | 1.7.3 |
| HeaderText | string | | ✔️ | Gets or sets the table column header. | 1.0.0 |
| HeaderTextAlignment | enum | `Alignment.Start` | | Gets or sets the header text alignment. Use `Alignment.Start` or `Alignment.Center` or `Alignment.End`. | 1.0.0 |
| IsDefaultSortColumn | bool | false | | Gets or sets the default sort column. | 1.0.0 |
| PropertyName | string | | | Gets or sets the property name. This is required when `AllowFiltering` is true. | 1.0.0 |
| Sortable | bool | false | | Enable or disable the sorting on a specific column. The sorting is enabled or disabled based on the grid `AllowSorting` parameter. | 1.0.0 |
| SortDirection | enum | `SortDirection.None` | | Gets or sets the default sort direction of a column. Use `SortDirection.Ascending` or `SortDirection.Descending` | 1.0.0 |
| SortKeySelector | `Expression<Func<TItem, IComparable>>` | | | Expression used for sorting. | 1.0.0 |
| SortString | string | | | Gets or sets the column sort string. This string is passed to the backend/API for sorting. And it is ignored for client-side sorting. | 1.0.0 |
| StringComparison | enum | `StringComparison.OrdinalIgnoreCase` | | Gets or sets the StringComparison. Use `StringComparison.CurrentCulture` or `StringComparison.CurrentCultureIgnoreCase` or `StringComparison.InvariantCulture` or `StringComparison.InvariantCultureIgnoreCase` or `StringComparison.Ordinal` or `StringComparison.OrdinalIgnoreCase`. | 1.0.0 |
| TextAlignment | `Alignment` | `Alignment.Start` | | Gets or sets the text alignment. Use `Alignment.Start` or `Alignment.Center` or `Alignment.End`. | 1.0.0 |
| TextNoWrap | bool | false | | Gets or sets text nowrap. | 1.0.0 |

## GridSettings Properties

| Name | Type | Default | Required | Description | Added Version |
|:--|:--|:--|:--|:--|:--|
| PageNumber | int | | | Page number. | 1.0.0 |
| PageSize | int | | | Size of the page. | 1.0.0 |
| Filters | `IEnumerable<FilterItem>` | | | Current filters. | 1.0.0 |

## Examples

### Client side filtering

For filtering, `AllowFiltering` and `PropertyName` parameters are required.
Add `AllowFiltering="true"` parameter to Grid and `PropertyName` parameter to all the GridColumns.

<img src="https://i.imgur.com/Clr8W11.png" alt="Blazor Bootstrap: Grid Component - Client side filtering" />

```cshtml {1,2,5,8,11,14} showLineNumbers
<Grid TItem="Employee1" class="table table-hover table-bordered table-striped" DataProvider="EmployeesDataProvider" AllowFiltering="true" Responsive="true">
    <GridColumn TItem="Employee1" HeaderText="Id" PropertyName="Id">
        @context.Id
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Employee Name" PropertyName="Name">
        @context.Name
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Designation" PropertyName="Designation">
        @context.Designation
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="DOJ" PropertyName="DOJ">
        @context.DOJ
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Active" PropertyName="IsActive">
        @context.IsActive
    </GridColumn>
</Grid>
```

```cs showLineNumbers
@code {
    private IEnumerable<Employee1> employees;

    protected override void OnInitialized()
    {
        employees = new List<Employee1>
        {
            new Employee1 { Id = 107, Name = "Alice", Designation = "AI Engineer", DOJ = new DateOnly(1998, 11, 17), IsActive = true },
            new Employee1 { Id = 103, Name = "Bob", Designation = "Senior DevOps Engineer", DOJ = new DateOnly(1985, 1, 5), IsActive = true },
            new Employee1 { Id = 106, Name = "John", Designation = "Data Engineer", DOJ = new DateOnly(1995, 4, 17), IsActive = true },
            new Employee1 { Id = 104, Name = "Pop", Designation = "Associate Architect", DOJ = new DateOnly(1985, 6, 8), IsActive = false },
            new Employee1 { Id = 105, Name = "Ronald", Designation = "Senior Data Engineer", DOJ = new DateOnly(1991, 8, 23), IsActive = true },
            new Employee1 { Id = 102, Name = "Line", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 101, Name = "Daniel", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 108, Name = "Zayne", Designation = "Data Analyst", DOJ = new DateOnly(1991, 1, 1), IsActive = true },
            new Employee1 { Id = 109, Name = "Isha", Designation = "App Maker", DOJ = new DateOnly(1996, 7, 1), IsActive = true },
        };
    }

    private async Task<GridDataProviderResult<Employee1>> EmployeesDataProvider(GridDataProviderRequest<Employee1> request)
    {
        return await Task.FromResult(request.ApplyTo(employees));
    }
}
```

[See demo here](https://demos.blazorbootstrap.com/grid#client-side-filtering)

### Client side filtering with string comparision

In the below example, `StringComparision.Ordinal` is used on the **Employee Name** column to make the filter case-sensitive.

<img src="https://i.imgur.com/yLzUB8I.png" alt="Blazor Bootstrap: Grid Component - Client side filtering with string comparision" />

```cshtml {5} showLineNumbers
<Grid TItem="Employee1" class="table table-hover table-bordered table-striped" DataProvider="EmployeesDataProvider" AllowFiltering="true" Responsive="true">
    <GridColumn TItem="Employee1" HeaderText="Id" PropertyName="Id">
        @context.Id
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Employee Name" PropertyName="Name" StringComparison="StringComparison.Ordinal">
        @context.Name
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Designation" PropertyName="Designation">
        @context.Designation
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="DOJ" PropertyName="DOJ">
        @context.DOJ
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Active" PropertyName="IsActive">
        @context.IsActive
    </GridColumn>
</Grid>
```

```cs showLineNumbers
@code {
    private IEnumerable<Employee1> employees;

    protected override void OnInitialized()
    {
        employees = new List<Employee1>
        {
            new Employee1 { Id = 107, Name = "Alice", Designation = "AI Engineer", DOJ = new DateOnly(1998, 11, 17), IsActive = true },
            new Employee1 { Id = 103, Name = "Bob", Designation = "Senior DevOps Engineer", DOJ = new DateOnly(1985, 1, 5), IsActive = true },
            new Employee1 { Id = 106, Name = "John", Designation = "Data Engineer", DOJ = new DateOnly(1995, 4, 17), IsActive = true },
            new Employee1 { Id = 104, Name = "Pop", Designation = "Associate Architect", DOJ = new DateOnly(1985, 6, 8), IsActive = false },
            new Employee1 { Id = 105, Name = "Ronald", Designation = "Senior Data Engineer", DOJ = new DateOnly(1991, 8, 23), IsActive = true },
            new Employee1 { Id = 102, Name = "Line", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 101, Name = "Daniel", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 108, Name = "Zayne", Designation = "Data Analyst", DOJ = new DateOnly(1991, 1, 1), IsActive = true },
            new Employee1 { Id = 109, Name = "Isha", Designation = "App Maker", DOJ = new DateOnly(1996, 7, 1), IsActive = true },
        };
    }

    private async Task<GridDataProviderResult<Employee1>> EmployeesDataProvider(GridDataProviderRequest<Employee1> request)
    {
        return await Task.FromResult(request.ApplyTo(employees));
    }
}
```

[See demo here](https://demos.blazorbootstrap.com/grid#client-side-filtering-with-string-comparision)

:::info
By default, <code>StringComparison.OrdinalIgnoreCase</code> is used to compare culture-agnostic and case-insensitive string matching.
:::

### Client side paging

For paging, `AllowPaging` and `PageSize` parameters are required.
Add `AllowPaging="true"` and `PageSize="20"` parameters to the Grid. `PageSize` parameter is optional. 

<img src="https://i.imgur.com/WXwUqgX.png" alt="Blazor Bootstrap: Grid Component - Client side paging" />

:::info INFO
The default page size is 10.
:::

```cshtml {1} showLineNumbers
<Grid TItem="Employee1" class="table table-hover table-bordered table-striped" DataProvider="EmployeesDataProvider" AllowPaging="true" PageSize="5" Responsive="true">
    <GridColumn TItem="Employee1" HeaderText="Id">
        @context.Id
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Employee Name">
        @context.Name
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Designation">
        @context.Designation
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="DOJ">
        @context.DOJ
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Active">
        @context.IsActive
    </GridColumn>
</Grid>
```

```cs showLineNumbers
@code {
    private IEnumerable<Employee1> employees;

    protected override void OnInitialized()
    {
        employees = new List<Employee1>
        {
            new Employee1 { Id = 107, Name = "Alice", Designation = "AI Engineer", DOJ = new DateOnly(1998, 11, 17), IsActive = true },
            new Employee1 { Id = 103, Name = "Bob", Designation = "Senior DevOps Engineer", DOJ = new DateOnly(1985, 1, 5), IsActive = true },
            new Employee1 { Id = 106, Name = "John", Designation = "Data Engineer", DOJ = new DateOnly(1995, 4, 17), IsActive = true },
            new Employee1 { Id = 104, Name = "Pop", Designation = "Associate Architect", DOJ = new DateOnly(1985, 6, 8), IsActive = false },
            new Employee1 { Id = 105, Name = "Ronald", Designation = "Senior Data Engineer", DOJ = new DateOnly(1991, 8, 23), IsActive = true },
            new Employee1 { Id = 102, Name = "Line", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 101, Name = "Daniel", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 113, Name = "Merlin", Designation = "Senior Consultant", DOJ = new DateOnly(1989, 10, 2), IsActive = true },
            new Employee1 { Id = 117, Name = "Sharna", Designation = "Data Analyst", DOJ = new DateOnly(1994, 5, 12), IsActive = true },
            new Employee1 { Id = 108, Name = "Zayne", Designation = "Data Analyst", DOJ = new DateOnly(1991, 1, 1), IsActive = true },
            new Employee1 { Id = 109, Name = "Isha", Designation = "App Maker", DOJ = new DateOnly(1996, 7, 1), IsActive = true },
            new Employee1 { Id = 111, Name = "Glenda", Designation = "Data Engineer", DOJ = new DateOnly(1994, 1, 12), IsActive = true },
        };
    }

    private async Task<GridDataProviderResult<Employee1>> EmployeesDataProvider(GridDataProviderRequest<Employee1> request)
    {
        return await Task.FromResult(request.ApplyTo(employees));
    }
}
```

[See demo here](https://demos.blazorbootstrap.com/grid#client-side-paging)

### Client side sorting

For sorting, `AllowSorting` and `SortKeySelector` parameters are required.
Add `AllowSorting="true"` parameter to Grid and `SortKeySelector` to all the GridColumns.

<img src="https://i.imgur.com/wkIWG5S.png" alt="Blazor Bootstrap: Grid Component - Client side sorting" />

```cshtml {1,2,5,8,11,14} showLineNumbers
<Grid TItem="Employee1" class="table table-hover table-bordered table-striped" DataProvider="EmployeesDataProvider" AllowSorting="true" Responsive="true">
    <GridColumn TItem="Employee1" HeaderText="Id" SortKeySelector="item => item.Id">
        @context.Id
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Employee Name" SortKeySelector="item => item.Name">
        @context.Name
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Designation" SortKeySelector="item => item.Designation">
        @context.Designation
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="DOJ" SortKeySelector="item => item.DOJ">
        @context.DOJ
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Active" SortKeySelector="item => item.IsActive">
        @context.IsActive
    </GridColumn>
</Grid>
```

```cs showLineNumbers
@code {
    private IEnumerable<Employee1> employees;

    protected override void OnInitialized()
    {
        employees = new List<Employee1>
        {
            new Employee1 { Id = 107, Name = "Alice", Designation = "AI Engineer", DOJ = new DateOnly(1998, 11, 17), IsActive = true },
            new Employee1 { Id = 103, Name = "Bob", Designation = "Senior DevOps Engineer", DOJ = new DateOnly(1985, 1, 5), IsActive = true },
            new Employee1 { Id = 106, Name = "John", Designation = "Data Engineer", DOJ = new DateOnly(1995, 4, 17), IsActive = true },
            new Employee1 { Id = 104, Name = "Pop", Designation = "Associate Architect", DOJ = new DateOnly(1985, 6, 8), IsActive = false },
            new Employee1 { Id = 105, Name = "Ronald", Designation = "Senior Data Engineer", DOJ = new DateOnly(1991, 8, 23), IsActive = true },
            new Employee1 { Id = 102, Name = "Line", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 101, Name = "Daniel", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 108, Name = "Zayne", Designation = "Data Analyst", DOJ = new DateOnly(1991, 1, 1), IsActive = true },
            new Employee1 { Id = 109, Name = "Isha", Designation = "App Maker", DOJ = new DateOnly(1996, 7, 1), IsActive = true },
        };
    }

    private async Task<GridDataProviderResult<Employee1>> EmployeesDataProvider(GridDataProviderRequest<Employee1> request)
    {
        return await Task.FromResult(request.ApplyTo(employees));
    }
}
```

[See demo here](https://demos.blazorbootstrap.com/grid#client-side-sorting)

### Client side filtering, paging, and sorting

<img src="https://i.imgur.com/wZ0cQiO.png" alt="Blazor Bootstrap: Grid Component - Client side filtering, paging, and sorting" />

```cshtml {1,2,5,8,11,14} showLineNumbers
<Grid TItem="Employee1" class="table table-hover table-bordered table-striped" DataProvider="EmployeesDataProvider" AllowFiltering="true" AllowPaging="true" PageSize="5" AllowSorting="true" Responsive="true">
    <GridColumn TItem="Employee1" HeaderText="Id" PropertyName="Id" SortKeySelector="item => item.Id">
        @context.Id
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Employee Name" PropertyName="Name" SortKeySelector="item => item.Name">
        @context.Name
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Designation" PropertyName="Designation" SortKeySelector="item => item.Designation">
        @context.Designation
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="DOJ" PropertyName="DOJ" SortKeySelector="item => item.DOJ">
        @context.DOJ
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Active" PropertyName="IsActive" SortKeySelector="item => item.IsActive">
        @context.IsActive
    </GridColumn>
</Grid>
```

```cs showLineNumbers
@code {
    private IEnumerable<Employee1> employees;

    protected override void OnInitialized()
    {
        employees = new List<Employee1>
        {
            new Employee1 { Id = 107, Name = "Alice", Designation = "AI Engineer", DOJ = new DateOnly(1998, 11, 17), IsActive = true },
            new Employee1 { Id = 103, Name = "Bob", Designation = "Senior DevOps Engineer", DOJ = new DateOnly(1985, 1, 5), IsActive = true },
            new Employee1 { Id = 106, Name = "John", Designation = "Data Engineer", DOJ = new DateOnly(1995, 4, 17), IsActive = true },
            new Employee1 { Id = 104, Name = "Pop", Designation = "Associate Architect", DOJ = new DateOnly(1985, 6, 8), IsActive = false },
            new Employee1 { Id = 105, Name = "Ronald", Designation = "Senior Data Engineer", DOJ = new DateOnly(1991, 8, 23), IsActive = true },
            new Employee1 { Id = 102, Name = "Line", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 101, Name = "Daniel", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 113, Name = "Merlin", Designation = "Senior Consultant", DOJ = new DateOnly(1989, 10, 2), IsActive = true },
            new Employee1 { Id = 117, Name = "Sharna", Designation = "Data Analyst", DOJ = new DateOnly(1994, 5, 12), IsActive = true },
            new Employee1 { Id = 108, Name = "Zayne", Designation = "Data Analyst", DOJ = new DateOnly(1991, 1, 1), IsActive = true },
            new Employee1 { Id = 109, Name = "Isha", Designation = "App Maker", DOJ = new DateOnly(1996, 7, 1), IsActive = true },
            new Employee1 { Id = 111, Name = "Glenda", Designation = "Data Engineer", DOJ = new DateOnly(1994, 1, 12), IsActive = true },
        };
    }

    private async Task<GridDataProviderResult<Employee1>> EmployeesDataProvider(GridDataProviderRequest<Employee1> request)
    {
        return await Task.FromResult(request.ApplyTo(employees));
    }
}
```

[See demo here](https://demos.blazorbootstrap.com/grid#client-side-filtering-paging-sorting)

### Set default filter

`FilterOperator` and `FilterValue` parameters are required to set the default filter. 

<img src="https://i.imgur.com/jog5EA4.png" alt="Blazor Bootstrap: Grid Component - Set default filter" />

:::tip TIP
You can set the default filter on more than one GridColumn.
:::

```cshtml {2} showLineNumbers
<Grid TItem="Employee1" class="table table-hover table-bordered table-striped" DataProvider="EmployeesDataProvider" AllowFiltering="true" Responsive="true">
    <GridColumn TItem="Employee1" HeaderText="Id" PropertyName="Id" FilterOperator="FilterOperator.GreaterThanOrEquals" FilterValue="105">
        @context.Id
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Employee Name" PropertyName="Name">
        @context.Name
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Designation" PropertyName="Designation">
        @context.Designation
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="DOJ" PropertyName="DOJ">
        @context.DOJ
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Active" PropertyName="IsActive">
        @context.IsActive
    </GridColumn>
</Grid>
```

```cs showLineNumbers
@code {
    private IEnumerable<Employee1> employees;

    protected override void OnInitialized()
    {
        employees = new List<Employee1>
        {
            new Employee1 { Id = 107, Name = "Alice", Designation = "AI Engineer", DOJ = new DateOnly(1998, 11, 17), IsActive = true },
            new Employee1 { Id = 103, Name = "Bob", Designation = "Senior DevOps Engineer", DOJ = new DateOnly(1985, 1, 5), IsActive = true },
            new Employee1 { Id = 106, Name = "John", Designation = "Data Engineer", DOJ = new DateOnly(1995, 4, 17), IsActive = true },
            new Employee1 { Id = 104, Name = "Pop", Designation = "Associate Architect", DOJ = new DateOnly(1985, 6, 8), IsActive = false },
            new Employee1 { Id = 105, Name = "Ronald", Designation = "Senior Data Engineer", DOJ = new DateOnly(1991, 8, 23), IsActive = true },
            new Employee1 { Id = 102, Name = "Line", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 101, Name = "Daniel", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 108, Name = "Zayne", Designation = "Data Analyst", DOJ = new DateOnly(1991, 1, 1), IsActive = true },
            new Employee1 { Id = 109, Name = "Isha", Designation = "App Maker", DOJ = new DateOnly(1996, 7, 1), IsActive = true },
        };
    }

    private async Task<GridDataProviderResult<Employee1>> EmployeesDataProvider(GridDataProviderRequest<Employee1> request)
    {
        return await Task.FromResult(request.ApplyTo(employees));
    }
}
```

[See demo here](https://demos.blazorbootstrap.com/grid#set-default-filter)

### Disable specific column filter

`Filterable` parameter is required to disable the filter on a specific column. 
Add `Filterable="false"` parameter to GridColumn.

<img src="https://i.imgur.com/oGeA4VO.png" alt="Blazor Bootstrap: Grid Component - Disable specific column filter" />

:::info INFO
By default, `Filterable="true"` on all the columns if the `AllowFiltering` parameter is set to `true` on the grid.
:::
```cshtml {14} showLineNumbers
<Grid TItem="Employee1" class="table table-hover table-bordered table-striped" DataProvider="EmployeesDataProvider" AllowFiltering="true" Responsive="true">
    <GridColumn TItem="Employee1" HeaderText="Id" Filterable="false">
        @context.Id
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Employee Name" PropertyName="Name">
        @context.Name
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Designation" PropertyName="Designation">
        @context.Designation
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="DOJ" PropertyName="DOJ">
        @context.DOJ
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Active" Filterable="false">
        @context.IsActive
    </GridColumn>
</Grid>
```

```cs showLineNumbers
@code {
    private IEnumerable<Employee1> employees;

    protected override void OnInitialized()
    {
        employees = new List<Employee1>
        {
            new Employee1 { Id = 107, Name = "Alice", Designation = "AI Engineer", DOJ = new DateOnly(1998, 11, 17), IsActive = true },
            new Employee1 { Id = 103, Name = "Bob", Designation = "Senior DevOps Engineer", DOJ = new DateOnly(1985, 1, 5), IsActive = true },
            new Employee1 { Id = 106, Name = "John", Designation = "Data Engineer", DOJ = new DateOnly(1995, 4, 17), IsActive = true },
            new Employee1 { Id = 104, Name = "Pop", Designation = "Associate Architect", DOJ = new DateOnly(1985, 6, 8), IsActive = false },
            new Employee1 { Id = 105, Name = "Ronald", Designation = "Senior Data Engineer", DOJ = new DateOnly(1991, 8, 23), IsActive = true },
            new Employee1 { Id = 102, Name = "Line", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 101, Name = "Daniel", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 108, Name = "Zayne", Designation = "Data Analyst", DOJ = new DateOnly(1991, 1, 1), IsActive = true },
            new Employee1 { Id = 109, Name = "Isha", Designation = "App Maker", DOJ = new DateOnly(1996, 7, 1), IsActive = true },
        };
    }

    private async Task<GridDataProviderResult<Employee1>> EmployeesDataProvider(GridDataProviderRequest<Employee1> request)
    {
        return await Task.FromResult(request.ApplyTo(employees));
    }
}
```

[See demo here](https://demos.blazorbootstrap.com/grid#disable-specific-column-filter)

### Increase filter textbox width

Add `FilterTextboxWidth` parameter to the GridColumn to increase or decrease the filter textbox width, `FilterTextboxWidth` parameter is optional.

<img src="https://i.imgur.com/eWXiHr0.png" alt="Blazor Bootstrap: Grid Component - Increase filter textbox width" />

:::note NOTE
Filter textbox width measured in pixels.
:::

```cshtml {2,5,8} showLineNumbers
<Grid TItem="Employee3" class="table table-hover table-bordered table-striped" DataProvider="EmployeesDataProvider" AllowFiltering="true" Responsive="true">
    <GridColumn TItem="Employee3" HeaderText="Id" PropertyName="Id" FilterTextboxWidth="80">
        @context.Id
    </GridColumn>
    <GridColumn TItem="Employee3" HeaderText="First Name" PropertyName="FirstName" FilterTextboxWidth="80">
        @context.FirstName
    </GridColumn>
    <GridColumn TItem="Employee3" HeaderText="Last Name" PropertyName="LastName" FilterTextboxWidth="80">
        @context.LastName
    </GridColumn>
    <GridColumn TItem="Employee3" HeaderText="Email" PropertyName="Email">
        @context.Email
    </GridColumn>
    <GridColumn TItem="Employee3" HeaderText="Company" TextNoWrap="true" PropertyName="Company">
        @context.Company
    </GridColumn>
    <GridColumn TItem="Employee3" HeaderText="Designation" TextNoWrap="true" PropertyName="Designation">
        @context.Designation
    </GridColumn>
    <GridColumn TItem="Employee3" HeaderText="DOJ" PropertyName="DOJ">
        @context.DOJ
    </GridColumn>
    <GridColumn TItem="Employee3" HeaderText="Salary" HeaderTextAlignment="Alignment.End" TextAlignment="Alignment.End" PropertyName="Salary" FilterTextboxWidth="80">
        @context.Salary.ToString("N2")
    </GridColumn>
    <GridColumn TItem="Employee3" HeaderText="Active" HeaderTextAlignment="Alignment.Center" TextAlignment="Alignment.Center" PropertyName="IsActive">
        @context.IsActive
    </GridColumn>
</Grid>
```

```cs showLineNumbers
@code {
    private IEnumerable<Employee3> employees;

    protected override void OnInitialized()
    {
        employees = new List<Employee3>
        {
            new Employee3 { Id = 107, FirstName = "Alice", LastName = "Reddy", Email = "alice@blazorbootstrap.com", Company = "BlazorBootstrap Company", Designation = "AI Engineer", DOJ = new DateOnly(1998, 11, 17), Salary = 7700, IsActive = true },
            new Employee3 { Id = 103, FirstName = "Bob", LastName = "Roy", Email = "bob@blazorbootstrap.com", Company = "BlazorBootstrap Company", Designation = "Senior DevOps Engineer", DOJ = new DateOnly(1985, 1, 5), Salary = 19000, IsActive = true },
            new Employee3 { Id = 106, FirstName = "John", LastName = "Papa", Email = "john@blazorbootstrap.com", Company = "BlazorBootstrap Company", Designation = "Data Engineer", DOJ = new DateOnly(1995, 4, 17), Salary = 12000, IsActive = true },
            new Employee3 { Id = 104, FirstName = "Pop", LastName = "Two", Email = "pop@blazorbootstrap.com", Company = "BlazorBootstrap Company", Designation = "Associate Architect", DOJ = new DateOnly(1985, 6, 8), Salary = 19000, IsActive = false },
            new Employee3 { Id = 105, FirstName = "Ronald", LastName = "Dire", Email = "ronald@blazorbootstrap.com", Company = "BlazorBootstrap Company", Designation = "Senior Data Engineer", DOJ = new DateOnly(1991, 8, 23), Salary = 16500.50M, IsActive = true },
            new Employee3 { Id = 102, FirstName = "Line", LastName = "K", Email = "line@blazorbootstrap.com", Company = "BlazorBootstrap Company", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), Salary = 24000, IsActive = true },
            new Employee3 { Id = 101, FirstName = "Daniel", LastName = "Potter", Email = "daniel@blazorbootstrap.com", Company = "BlazorBootstrap Company", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), Salary = 21000, IsActive = true },
            new Employee3 { Id = 108, FirstName = "Zayne", LastName = "Simmons", Email = "zayne@blazorbootstrap.com", Company = "BlazorBootstrap Company", Designation = "Data Analyst", DOJ = new DateOnly(1991, 1, 1), Salary = 17850, IsActive = true },
            new Employee3 { Id = 109, FirstName = "Isha", LastName = "Davison", Email = "isha@blazorbootstrap.com", Company = "BlazorBootstrap Company", Designation = "App Maker", DOJ = new DateOnly(1996, 7, 1), Salary = 8000, IsActive = true },
        };
    }

    private async Task<GridDataProviderResult<Employee3>> EmployeesDataProvider(GridDataProviderRequest<Employee3> request)
    {
        return await Task.FromResult(request.ApplyTo(employees));
    }
}
```

[See demo here](https://demos.blazorbootstrap.com/grid#increase-filter-textbox-width)

### Server side filtering, paging and sorting

<img src="https://i.imgur.com/xHVXTew.png" alt="Blazor Bootstrap: Grid Component - Server side filtering, paging and sorting" />

:::note NOTE
For server-side sorting, we need the `SortString` parameter on GridColumn along with the `SortKeySelector` parameter.
:::

```cshtml showLineNumbers
<Grid TItem="Employee" class="table table-hover table-bordered table-striped" DataProvider="EmployeesDataProvider" AllowFiltering="true" AllowPaging="true" PageSize="5" AllowSorting="true" Responsive="true">
    <GridColumn TItem="Employee" HeaderText="Id" PropertyName="Id" SortString="Id" SortKeySelector="item => item.Id">
        @context.Id
    </GridColumn>
    <GridColumn TItem="Employee" HeaderText="First Name" PropertyName="FirstName" SortString="FirstName" SortKeySelector="item => item.FirstName">
        @context.FirstName
    </GridColumn>
    <GridColumn TItem="Employee" HeaderText="Last Name" PropertyName="LastName" SortString="LastName" SortKeySelector="item => item.LastName">
        @context.LastName
    </GridColumn>
    <GridColumn TItem="Employee" HeaderText="Designation" PropertyName="Designation" SortString="Designation" SortKeySelector="item => item.Designation">
        @context.Designation
    </GridColumn>
    <GridColumn TItem="Employee" HeaderText="Salary" PropertyName="Salary" SortString="Salary" SortKeySelector="item => item.Salary">
        @context.Salary
    </GridColumn>
    <GridColumn TItem="Employee" HeaderText="DOJ" PropertyName="DOJ" SortString="DOJ" SortKeySelector="item => item.DOJ">
        @context.DOJ
    </GridColumn>
    <GridColumn TItem="Employee" HeaderText="Active" PropertyName="IsActive" SortString="IsActive" SortKeySelector="item => item.IsActive">
        @context.IsActive
    </GridColumn>
</Grid>
```

```cs {11} showLineNumbers
@code {
    [Inject] public IEmployeeService _employeeService { get; set; }

    private async Task<GridDataProviderResult<Employee>> EmployeesDataProvider(GridDataProviderRequest<Employee> request)
    {
        string sortString = "";
        SortDirection sortDirection = SortDirection.None;

        if (request.Sorting is not null && request.Sorting.Any())
        {
            // Note: Multi column sorting is not supported at this moment
            sortString = request.Sorting[0].SortString;
            sortDirection = request.Sorting[0].SortDirection;
        }
        var result = _employeeService.GetEmployees(request.Filters, request.PageNumber, request.PageSize, sortString, sortDirection);
        return await Task.FromResult(new GridDataProviderResult<Employee> { Data = result.Item1, TotalCount = result.Item2 });
    }
}
```

[See demo here](https://demos.blazorbootstrap.com/grid#server-side-filtering-paging-sorting)

### Set default sorting

`IsDefaultSortColumn` parameter is required to set the default sorting. Add `IsDefaultSortColumn="true"` parameter to the GridColumn.
The default sort direction will be **ascending**. To change the default sorting of a column, add `SortDirection="SortDirection.Descending"` to the GridColumn.

<img src="https://i.imgur.com/WxULPS6.png" alt="Blazor Bootstrap: Grid Component - Set default sorting" />

:::info INFO
If more than one GridColumn has the `IsDefaultSortColumn` paramter, it will pick the first column as the default sorting column.
:::

```cshtml {5} showLineNumbers
<Grid TItem="Employee1" class="table table-hover table-bordered table-striped" DataProvider="EmployeesDataProvider" AllowSorting="true">
    <GridColumn TItem="Employee1" HeaderText="Id" SortKeySelector="@(item => item.Id)">
        @context.Id
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Employee Name" SortKeySelector="@(item => item.Name)" IsDefaultSortColumn="true" SortDirection="SortDirection.Descending">
        @context.Name
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Designation" SortKeySelector="@(item => item.Designation)">
        @context.Designation
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="DOJ" SortKeySelector="@(item => item.DOJ)">
        @context.DOJ
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Active" SortKeySelector="@(item => item.IsActive)">
        @context.IsActive
    </GridColumn>
</Grid>
```

```cs showLineNumbers
@code {
    private IEnumerable<Employee1> employees;

    protected override void OnInitialized()
    {
        employees = new List<Employee1>
        {
            new Employee1 { Id = 107, Name = "Alice", Designation = "AI Engineer", DOJ = new DateOnly(1998, 11, 17), IsActive = true },
            new Employee1 { Id = 103, Name = "Bob", Designation = "Senior DevOps Engineer", DOJ = new DateOnly(1985, 1, 5), IsActive = true },
            new Employee1 { Id = 106, Name = "John", Designation = "Data Engineer", DOJ = new DateOnly(1995, 4, 17), IsActive = true },
            new Employee1 { Id = 104, Name = "Pop", Designation = "Associate Architect", DOJ = new DateOnly(1985, 6, 8), IsActive = false },
            new Employee1 { Id = 105, Name = "Ronald", Designation = "Senior Data Engineer", DOJ = new DateOnly(1991, 8, 23), IsActive = true },
            new Employee1 { Id = 102, Name = "Line", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 101, Name = "Daniel", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 108, Name = "Zayne", Designation = "Data Analyst", DOJ = new DateOnly(1991, 1, 1), IsActive = true },
            new Employee1 { Id = 109, Name = "Isha", Designation = "App Maker", DOJ = new DateOnly(1996, 7, 1), IsActive = true },
        };
    }

    private async Task<GridDataProviderResult<Employee1>> EmployeesDataProvider(GridDataProviderRequest<Employee1> request)
    {
        return await Task.FromResult(request.ApplyTo(employees));
    }
}
```

[See demo here](https://demos.blazorbootstrap.com/grid#set-default-sorting)

### Disable specific column sorting

Add `Sortable="false"` parameter the GridColumn to disable the sorting. 

:::info INFO
If sorting is disabled, then the `SortKeySelector` parameter is not required.
:::

```cshtml {8} showLineNumbers
<Grid TItem="Employee1" class="table table-hover table-bordered table-striped" DataProvider="EmployeesDataProvider" AllowSorting="true">
    <GridColumn TItem="Employee1" HeaderText="Id" SortKeySelector="@(item => item.Id)">
        @context.Id
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Employee Name" SortKeySelector="@(item => item.Name)">
        @context.Name
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Designation" Sortable="false">
        @context.Designation
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="DOJ" SortKeySelector="@(item => item.DOJ)">
        @context.DOJ
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Active" SortKeySelector="@(item => item.IsActive)">
        @context.IsActive
    </GridColumn>
</Grid>
```

```cs showLineNumbers
@code {
    private IEnumerable<Employee1> employees;

    protected override void OnInitialized()
    {
        employees = new List<Employee1>
        {
            new Employee1 { Id = 107, Name = "Alice", Designation = "AI Engineer", DOJ = new DateOnly(1998, 11, 17), IsActive = true },
            new Employee1 { Id = 103, Name = "Bob", Designation = "Senior DevOps Engineer", DOJ = new DateOnly(1985, 1, 5), IsActive = true },
            new Employee1 { Id = 106, Name = "John", Designation = "Data Engineer", DOJ = new DateOnly(1995, 4, 17), IsActive = true },
            new Employee1 { Id = 104, Name = "Pop", Designation = "Associate Architect", DOJ = new DateOnly(1985, 6, 8), IsActive = false },
            new Employee1 { Id = 105, Name = "Ronald", Designation = "Senior Data Engineer", DOJ = new DateOnly(1991, 8, 23), IsActive = true },
            new Employee1 { Id = 102, Name = "Line", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 101, Name = "Daniel", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 108, Name = "Zayne", Designation = "Data Analyst", DOJ = new DateOnly(1991, 1, 1), IsActive = true },
            new Employee1 { Id = 109, Name = "Isha", Designation = "App Maker", DOJ = new DateOnly(1996, 7, 1), IsActive = true },
        };
    }

    private async Task<GridDataProviderResult<Employee1>> EmployeesDataProvider(GridDataProviderRequest<Employee1> request)
    {
        return await Task.FromResult(request.ApplyTo(employees));
    }
}
```

[See demo here](https://demos.blazorbootstrap.com/grid#disable-specific-column-sorting)

### Header text alignment

Use the `HeaderTextAlignment` parameter to change the header column alignment. 
By default, `HeaderTextAlignment` is set to Alignment.Start. Other options you can use are `Alignment.Center` and `Alignment.End`.

<img src="https://i.imgur.com/gWgIESD.png" alt="Blazor Bootstrap: Grid Component - Header text alignment" />

```cshtml {8,11,14} showLineNumbers
<Grid TItem="Employee1" class="table table-hover table-bordered table-striped" DataProvider="EmployeesDataProvider">
    <GridColumn TItem="Employee1" HeaderText="Id" HeaderTextAlignment="Alignment.Center">
        @context.Id
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Employee Name">
        @context.Name
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Designation" HeaderTextAlignment="Alignment.Center">
        @context.Designation
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="DOJ" HeaderTextAlignment="Alignment.Center">
        @context.DOJ
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Active" HeaderTextAlignment="Alignment.End">
        @context.IsActive
    </GridColumn>
</Grid>
```

```cs showLineNumbers
@code {
    private IEnumerable<Employee1> employees;

    protected override void OnInitialized()
    {
        employees = new List<Employee1>
        {
            new Employee1 { Id = 107, Name = "Alice", Designation = "AI Engineer", DOJ = new DateOnly(1998, 11, 17), IsActive = true },
            new Employee1 { Id = 103, Name = "Bob", Designation = "Senior DevOps Engineer", DOJ = new DateOnly(1985, 1, 5), IsActive = true },
            new Employee1 { Id = 106, Name = "John", Designation = "Data Engineer", DOJ = new DateOnly(1995, 4, 17), IsActive = true },
            new Employee1 { Id = 104, Name = "Pop", Designation = "Associate Architect", DOJ = new DateOnly(1985, 6, 8), IsActive = false },
            new Employee1 { Id = 105, Name = "Ronald", Designation = "Senior Data Engineer", DOJ = new DateOnly(1991, 8, 23), IsActive = true },
            new Employee1 { Id = 102, Name = "Line", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 101, Name = "Daniel", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 108, Name = "Zayne", Designation = "Data Analyst", DOJ = new DateOnly(1991, 1, 1), IsActive = true },
            new Employee1 { Id = 109, Name = "Isha", Designation = "App Maker", DOJ = new DateOnly(1996, 7, 1), IsActive = true },
        };
    }

    private async Task<GridDataProviderResult<Employee1>> EmployeesDataProvider(GridDataProviderRequest<Employee1> request)
    {
        return await Task.FromResult(request.ApplyTo(employees));
    }
}
```

[See demo here](https://demos.blazorbootstrap.com/grid#header-text-alignment)

### Cell alignment

Use the `TextAlignment` parameter to change the cell data alignment. 
By default, `TextAlignment` is set to `Alignment.Start`. Other options you can use are `Alignment.Center` and `Alignment.End`.

<img src="https://i.imgur.com/0OKp4yd.png" alt="Blazor Bootstrap: Grid Component - Cell alignment" />

```cshtml {11,14} showLineNumbers
<Grid TItem="Employee2" class="table table-hover table-bordered table-striped" DataProvider="EmployeesDataProvider">
    <GridColumn TItem="Employee2" HeaderText="Id" HeaderTextAlignment="Alignment.Center" TextAlignment="Alignment.Center">
        @context.Id
    </GridColumn>
    <GridColumn TItem="Employee2" HeaderText="Employee Name">
        @context.Name
    </GridColumn>
    <GridColumn TItem="Employee2" HeaderText="Designation">
        @context.Designation
    </GridColumn>
    <GridColumn TItem="Employee2" HeaderText="Salary" HeaderTextAlignment="Alignment.End" TextAlignment="Alignment.End">
        @context.Salary
    </GridColumn>
    <GridColumn TItem="Employee2" HeaderText="Active" HeaderTextAlignment="Alignment.Center" TextAlignment="Alignment.Center">
        @context.IsActive
    </GridColumn>
</Grid>
```

```cs showLineNumbers
@code {
    private IEnumerable<Employee2> employees;

    protected override void OnInitialized()
    {
        employees = new List<Employee2>
        {
            new Employee2 { Id = 107, Name = "Alice", Designation = "AI Engineer", Salary = 7700, IsActive = true },
            new Employee2 { Id = 103, Name = "Bob", Designation = "Senior DevOps Engineer", Salary = 19000, IsActive = true },
            new Employee2 { Id = 106, Name = "John", Designation = "Data Engineer", Salary = 12000, IsActive = true },
            new Employee2 { Id = 104, Name = "Pop", Designation = "Associate Architect", Salary = 19000, IsActive = false },
            new Employee2 { Id = 105, Name = "Ronald", Designation = "Senior Data Engineer", Salary = 16500.50M, IsActive = true },
            new Employee2 { Id = 102, Name = "Line", Designation = "Architect", Salary = 24000, IsActive = true },
            new Employee2 { Id = 101, Name = "Daniel", Designation = "Architect", Salary = 21000, IsActive = true },
            new Employee2 { Id = 108, Name = "Zayne", Designation = "Data Analyst", Salary = 17850, IsActive = true },
            new Employee2 { Id = 109, Name = "Isha", Designation = "App Maker", Salary = 8000, IsActive = true },
        };
    }

    private async Task<GridDataProviderResult<Employee2>> EmployeesDataProvider(GridDataProviderRequest<Employee2> request)
    {
        return await Task.FromResult(request.ApplyTo(employees));
    }
}
```

[See demo here](https://demos.blazorbootstrap.com/grid#cell-alignment)

### Cell formating
To format the cell data, use `ToString` method and format strings. Refer: [How to format numbers, dates, enums, and other types in .NET](https://docs.microsoft.com/en-us/dotnet/standard/base-types/formatting-types)

<img src="https://i.imgur.com/MitfasL.png" alt="Blazor Bootstrap: Grid Component - Cell formating" />

:::tip EXAMPLE
@context.Salary.ToString("N2")
:::

```cshtml {12} showLineNumbers
<Grid TItem="Employee2" class="table table-hover table-bordered table-striped" DataProvider="EmployeesDataProvider">
    <GridColumn TItem="Employee2" HeaderText="Id" HeaderTextAlignment="Alignment.Center" TextAlignment="Alignment.Center">
        @context.Id
    </GridColumn>
    <GridColumn TItem="Employee2" HeaderText="Employee Name">
        @context.Name
    </GridColumn>
    <GridColumn TItem="Employee2" HeaderText="Designation">
        @context.Designation
    </GridColumn>
    <GridColumn TItem="Employee2" HeaderText="Salary" HeaderTextAlignment="Alignment.End" TextAlignment="Alignment.End">
        @context.Salary.ToString("N2")
    </GridColumn>
    <GridColumn TItem="Employee2" HeaderText="Active" HeaderTextAlignment="Alignment.Center" TextAlignment="Alignment.Center">
        @context.IsActive
    </GridColumn>
</Grid>
```

```cs showLineNumbers
@code {
    private IEnumerable<Employee2> employees;

    protected override void OnInitialized()
    {
        employees = new List<Employee2>
        {
            new Employee2 { Id = 107, Name = "Alice", Designation = "AI Engineer", Salary = 7700, IsActive = true },
            new Employee2 { Id = 103, Name = "Bob", Designation = "Senior DevOps Engineer", Salary = 19000, IsActive = true },
            new Employee2 { Id = 106, Name = "John", Designation = "Data Engineer", Salary = 12000, IsActive = true },
            new Employee2 { Id = 104, Name = "Pop", Designation = "Associate Architect", Salary = 19000, IsActive = false },
            new Employee2 { Id = 105, Name = "Ronald", Designation = "Senior Data Engineer", Salary = 16500.50M, IsActive = true },
            new Employee2 { Id = 102, Name = "Line", Designation = "Architect", Salary = 24000, IsActive = true },
            new Employee2 { Id = 101, Name = "Daniel", Designation = "Architect", Salary = 21000, IsActive = true },
            new Employee2 { Id = 108, Name = "Zayne", Designation = "Data Analyst", Salary = 17850, IsActive = true },
            new Employee2 { Id = 109, Name = "Isha", Designation = "App Maker", Salary = 8000, IsActive = true },
        };
    }

    private async Task<GridDataProviderResult<Employee2>> EmployeesDataProvider(GridDataProviderRequest<Employee2> request)
    {
        return await Task.FromResult(request.ApplyTo(employees));
    }
}
```

[See demo here](https://demos.blazorbootstrap.com/grid#cell-formating)

### Cell nowrap

To prevent text from wrapping, add `TextNoWrap="true"` parameter to the GridColumn.

<img src="https://i.imgur.com/Wzc3AUF.png" alt="Blazor Bootstrap: Grid Component - Cell nowrap" />

:::tip TIP
Add `Responsive="true"` parameter to the grid to enable horizontal scrolling.
:::

```cshtml {14,17} showLineNumbers
<Grid TItem="Employee3" class="table table-hover table-bordered table-striped" DataProvider="EmployeesDataProvider" Responsive="true">
    <GridColumn TItem="Employee3" HeaderText="Id" HeaderTextAlignment="Alignment.Center" TextAlignment="Alignment.Center">
        @context.Id
    </GridColumn>
    <GridColumn TItem="Employee3" HeaderText="First Name">
        @context.FirstName
    </GridColumn>
    <GridColumn TItem="Employee3" HeaderText="First Name">
        @context.LastName
    </GridColumn>
    <GridColumn TItem="Employee3" HeaderText="Email">
        @context.Email
    </GridColumn>
    <GridColumn TItem="Employee3" HeaderText="Company" TextNoWrap="true">
        @context.Company
    </GridColumn>
    <GridColumn TItem="Employee3" HeaderText="Designation" TextNoWrap="true">
        @context.Designation
    </GridColumn>
    <GridColumn TItem="Employee3" HeaderText="DOJ">
        @context.DOJ
    </GridColumn>
    <GridColumn TItem="Employee3" HeaderText="Salary" HeaderTextAlignment="Alignment.End" TextAlignment="Alignment.End">
        @context.Salary.ToString("N2")
    </GridColumn>
    <GridColumn TItem="Employee3" HeaderText="Active" HeaderTextAlignment="Alignment.Center" TextAlignment="Alignment.Center">
        @context.IsActive
    </GridColumn>
</Grid>
```

```cs showLineNumbers
@code {
    private IEnumerable<Employee3> employees;

    protected override void OnInitialized()
    {
        employees = new List<Employee3>
        {
            new Employee3 { Id = 107, FirstName = "Alice", LastName = "Reddy", Email = "alice@blazorbootstrap.com", Company = "BlazorBootstrap Company", Designation = "AI Engineer", DOJ = new DateOnly(1998, 11, 17), Salary = 7700, IsActive = true },
            new Employee3 { Id = 103, FirstName = "Bob", LastName = "Roy", Email = "bob@blazorbootstrap.com", Company = "BlazorBootstrap Company", Designation = "Senior DevOps Engineer", DOJ = new DateOnly(1985, 1, 5), Salary = 19000, IsActive = true },
            new Employee3 { Id = 106, FirstName = "John", LastName = "Papa", Email = "john@blazorbootstrap.com", Company = "BlazorBootstrap Company", Designation = "Data Engineer", DOJ = new DateOnly(1995, 4, 17), Salary = 12000, IsActive = true },
            new Employee3 { Id = 104, FirstName = "Pop", LastName = "Two", Email = "pop@blazorbootstrap.com", Company = "BlazorBootstrap Company", Designation = "Associate Architect", DOJ = new DateOnly(1985, 6, 8), Salary = 19000, IsActive = false },
            new Employee3 { Id = 105, FirstName = "Ronald", LastName = "Dire", Email = "ronald@blazorbootstrap.com", Company = "BlazorBootstrap Company", Designation = "Senior Data Engineer", DOJ = new DateOnly(1991, 8, 23), Salary = 16500.50M, IsActive = true },
            new Employee3 { Id = 102, FirstName = "Line", LastName = "K", Email = "line@blazorbootstrap.com", Company = "BlazorBootstrap Company", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), Salary = 24000, IsActive = true },
            new Employee3 { Id = 101, FirstName = "Daniel", LastName = "Potter", Email = "daniel@blazorbootstrap.com", Company = "BlazorBootstrap Company", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), Salary = 21000, IsActive = true },
            new Employee3 { Id = 108, FirstName = "Zayne", LastName = "Simmons", Email = "zayne@blazorbootstrap.com", Company = "BlazorBootstrap Company", Designation = "Data Analyst", DOJ = new DateOnly(1991, 1, 1), Salary = 17850, IsActive = true },
            new Employee3 { Id = 109, FirstName = "Isha", LastName = "Davison", Email = "isha@blazorbootstrap.com", Company = "BlazorBootstrap Company", Designation = "App Maker", DOJ = new DateOnly(1996, 7, 1), Salary = 8000, IsActive = true },
        };
    }

    private async Task<GridDataProviderResult<Employee3>> EmployeesDataProvider(GridDataProviderRequest<Employee3> request)
    {
        return await Task.FromResult(request.ApplyTo(employees));
    }
}
```

[See demo here](https://demos.blazorbootstrap.com/grid#cell-nowrap)

### Pagination alignment

Change the alignment of pagination by adding the `PaginationAlignment` parameter to the Grid. 
By default, `PaginationAlignment` is set to `Alignment.Start`. Other options you can use are `Alignment.Center` and `Alignment.End`.

<img src="https://i.imgur.com/CtSqfJb.png" alt="Blazor Bootstrap: Grid Component - Pagination alignment" />

```cshtml {1} showLineNumbers
<Grid TItem="Employee1" class="table table-hover table-bordered table-striped table-striped" DataProvider="EmployeesDataProvider" AllowPaging="true" PageSize="5" PaginationAlignment="Alignment.End" Responsive="true">
    <GridColumn TItem="Employee1" HeaderText="Id">
        @context.Id
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Employee Name">
        @context.Name
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Designation">
        @context.Designation
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="DOJ">
        @context.DOJ
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Active">
        @context.IsActive
    </GridColumn>
</Grid>
```

```cs showLineNumbers
@code {
    private IEnumerable<Employee1> employees;

    protected override void OnInitialized()
    {
        employees = new List<Employee1>
        {
            new Employee1 { Id = 107, Name = "Alice", Designation = "AI Engineer", DOJ = new DateOnly(1998, 11, 17), IsActive = true },
            new Employee1 { Id = 103, Name = "Bob", Designation = "Senior DevOps Engineer", DOJ = new DateOnly(1985, 1, 5), IsActive = true },
            new Employee1 { Id = 106, Name = "John", Designation = "Data Engineer", DOJ = new DateOnly(1995, 4, 17), IsActive = true },
            new Employee1 { Id = 104, Name = "Pop", Designation = "Associate Architect", DOJ = new DateOnly(1985, 6, 8), IsActive = false },
            new Employee1 { Id = 105, Name = "Ronald", Designation = "Senior Data Engineer", DOJ = new DateOnly(1991, 8, 23), IsActive = true },
            new Employee1 { Id = 102, Name = "Line", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 101, Name = "Daniel", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 113, Name = "Merlin", Designation = "Senior Consultant", DOJ = new DateOnly(1989, 10, 2), IsActive = true },
            new Employee1 { Id = 117, Name = "Sharna", Designation = "Data Analyst", DOJ = new DateOnly(1994, 5, 12), IsActive = true },
            new Employee1 { Id = 108, Name = "Zayne", Designation = "Data Analyst", DOJ = new DateOnly(1991, 1, 1), IsActive = true },
            new Employee1 { Id = 109, Name = "Isha", Designation = "App Maker", DOJ = new DateOnly(1996, 7, 1), IsActive = true },
            new Employee1 { Id = 111, Name = "Glenda", Designation = "Data Engineer", DOJ = new DateOnly(1994, 1, 12), IsActive = true },
        };
    }

    private async Task<GridDataProviderResult<Employee1>> EmployeesDataProvider(GridDataProviderRequest<Employee1> request)
    {
        return await Task.FromResult(request.ApplyTo(employees));
    }
}
```

[See demo here](https://demos.blazorbootstrap.com/grid#pagination-alignment)

### Empty data

If there are no records to display in the Grid, by default, it will display the **No records to display** message. 
You can change this message by adding the `EmptyText` parameter to the Grid.

<img src="https://i.imgur.com/cLuvfmD.png" alt="Blazor Bootstrap: Grid Component - Empty data" />

```cshtml {1} showLineNumbers
<Grid TItem="Employee" class="table table-hover table-bordered table-striped" DataProvider="EmployeesDataProvider" EmptyText="No records to display">
    <GridColumn TItem="Employee" HeaderText="Id">
        @context.Id
    </GridColumn>
    <GridColumn TItem="Employee" HeaderText="First Name">
        @context.FirstName
    </GridColumn>
    <GridColumn TItem="Employee" HeaderText="Last Name">
        @context.LastName
    </GridColumn>
    <GridColumn TItem="Employee" HeaderText="Designation">
        @context.Designation
    </GridColumn>
</Grid>
```

```cs showLineNumbers
@code {
    private async Task<GridDataProviderResult<Employee>> EmployeesDataProvider(GridDataProviderRequest<Employee> request)
    {
        await Task.Delay(3000);

        return (new GridDataProviderResult<Employee> { Data = new List<Employee>(), TotalCount = 0 });
    }
}
```

[See demo here](https://demos.blazorbootstrap.com/grid#empty-data)

:::tip TIP
Add `Responsive="true"` parameter to the grid to enable horizontal scrolling.
:::

### Save and Load Grid Settings

This example shows how to save/load the Grid state. The state includes the page number, page size, and filters.

:::danger IMPORTANT
In version `0.5.1`, the Grid sorting state is not included as part of GridSettings. We will add it in the subsequent releases.
:::

:::note NOTE
Browser local storage is used to persist the Grid state. Common locations exist for persisting state are **Server-side storage**, **URL**, **Browser storage**, and **In-memory state container service**.
:::

<img src="https://i.imgur.com/weFYVWA.png" alt="Blazor Bootstrap: Grid Component - Save and Load Grid Settings" />

```cshtml {1,6,7} showLineNumbers
@using System.Text.Json

<Grid @ref="grid" TItem="Employee1" class="table table-hover table-bordered table-striped"
      DataProvider="EmployeesDataProvider"
      AllowFiltering="true" PageSize="8" AllowPaging="true" AllowSorting="true" Responsive="true"
      GridSettingsChanged="OnGridSettingsChanged"
      SettingsProvider="GridSettingsProvider">
    <GridColumn TItem="Employee1" HeaderText="Id" PropertyName="Id" SortKeySelector="item => item.Id" FilterOperator="FilterOperator.GreaterThanOrEquals" FilterValue="109">
        @context.Id
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Employee Name" PropertyName="Name" SortKeySelector="item => item.Name">
        @context.Name
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Designation" PropertyName="Designation" SortKeySelector="item => item.Designation">
        @context.Designation
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="DOJ" PropertyName="DOJ" SortKeySelector="item => item.DOJ">
        @context.DOJ
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Active" PropertyName="IsActive" SortKeySelector="item => item.IsActive">
        @context.IsActive
    </GridColumn>
</Grid>
```

```cshtml {1,6,7} showLineNumbers

@code {
    BlazorBootstrap.Grid<Employee1> grid;
    private IEnumerable<Employee1> employees;

    [Inject] public IJSRuntime JS { get; set; }
    public GridSettings Settings { get; set; }

    private async Task<GridDataProviderResult<Employee1>> EmployeesDataProvider(GridDataProviderRequest<Employee1> request)
    {
        if (employees is null) // pull employees only one time for client-side filtering, sorting, and paging
            employees = GetEmployees(); // call a service or an API to pull the employees

        return await Task.FromResult(request.ApplyTo(employees));
    }

    private async Task OnGridSettingsChanged(GridSettings settings)
    {
        if (settings is null)
            return;

        // NOTE: enable below two lines, if you want to set default values for PageNumber and PageSize all the time.
        //settings.PageNumber = 1;
        //settings.PageSize = 10;

        await JS.InvokeVoidAsync("window.localStorage.setItem", "grid-settings", JsonSerializer.Serialize(settings));
    }

    private async Task<GridSettings> GridSettingsProvider()
    {
        var settingsJson = await JS.InvokeAsync<string>("window.localStorage.getItem", "grid-settings");
        if (string.IsNullOrWhiteSpace(settingsJson))
            return null;

        var settings = JsonSerializer.Deserialize<GridSettings>(settingsJson);
        if (settings is null)
            return null;

        return settings;
    }


    private IEnumerable<Employee1> GetEmployees()
    {
        return new List<Employee1>
        {
            new Employee1 { Id = 107, Name = "Alice", Designation = "AI Engineer", DOJ = new DateOnly(1998, 11, 17), IsActive = true },
            new Employee1 { Id = 103, Name = "Bob", Designation = "Senior DevOps Engineer", DOJ = new DateOnly(1985, 1, 5), IsActive = true },
            new Employee1 { Id = 106, Name = "John", Designation = "Data Engineer", DOJ = new DateOnly(1995, 4, 17), IsActive = true },
            new Employee1 { Id = 104, Name = "Pop", Designation = "Associate Architect", DOJ = new DateOnly(1985, 6, 8), IsActive = false },
            new Employee1 { Id = 105, Name = "Ronald", Designation = "Senior Data Engineer", DOJ = new DateOnly(1991, 8, 23), IsActive = true },
            new Employee1 { Id = 102, Name = "Line", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 101, Name = "Daniel", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 113, Name = "Merlin", Designation = "Senior Consultant", DOJ = new DateOnly(1989, 10, 2), IsActive = true },
            new Employee1 { Id = 117, Name = "Sharna", Designation = "Data Analyst", DOJ = new DateOnly(1994, 5, 12), IsActive = true },
            new Employee1 { Id = 108, Name = "Zayne", Designation = "Data Analyst", DOJ = new DateOnly(1991, 1, 1), IsActive = true },
            new Employee1 { Id = 109, Name = "Isha", Designation = "App Maker", DOJ = new DateOnly(1996, 7, 1), IsActive = true },
            new Employee1 { Id = 111, Name = "Glenda", Designation = "Data Engineer", DOJ = new DateOnly(1994, 1, 12), IsActive = true },
        };
    }
}
```

[See demo here](https://demos.blazorbootstrap.com/grid#save-and-load-grid-settings)

### Data parameter - Assign collection

Assign a collection to the `Data` parameter to render the grid dynamically. The example below will render different department employees in the individual grid.

```cshtml {} showLineNumbers
@using BlazorBootstrap.Demo.Models;

@foreach (var department in departments)
{
    <p>@department.Name Employees:</p>
    <Grid TItem="Employee1" class="table table-hover table-bordered table-striped" Data="department.Employees">
        <GridColumn TItem="Employee1" HeaderText="Id" PropertyName="Id">
            @context.Id
        </GridColumn>
        <GridColumn TItem="Employee1" HeaderText="Employee Name" PropertyName="Name">
            @context.Name
        </GridColumn>
        <GridColumn TItem="Employee1" HeaderText="Designation" PropertyName="Designation">
            @context.Designation
        </GridColumn>
        <GridColumn TItem="Employee1" HeaderText="DOJ" PropertyName="DOJ">
            @context.DOJ
        </GridColumn>
        <GridColumn TItem="Employee1" HeaderText="Active" PropertyName="IsActive">
            @context.IsActive
        </GridColumn>
    </Grid>
}
```

```cs {} showLineNumbers
@code {
    Grid<Employee1> grid;

    private List<Department> departments = new List<Department>()
    {
        new Department("Product 1 - Research & Development", new List<Employee1> {
            new Employee1 { Id = 107, Name = "Alice", Designation = "AI Engineer", DOJ = new DateOnly(1998, 11, 17), IsActive = true },
            new Employee1 { Id = 103, Name = "Bob", Designation = "Senior DevOps Engineer", DOJ = new DateOnly(1985, 1, 5), IsActive = true },
            new Employee1 { Id = 106, Name = "John", Designation = "Data Engineer", DOJ = new DateOnly(1995, 4, 17), IsActive = true },
            new Employee1 { Id = 104, Name = "Pop", Designation = "Associate Architect", DOJ = new DateOnly(1985, 6, 8), IsActive = false },
            new Employee1 { Id = 105, Name = "Ronald", Designation = "Senior Data Engineer", DOJ = new DateOnly(1991, 8, 23), IsActive = true }
        }),
        new Department("Product 2 - Research & Development", new List<Employee1> {
            new Employee1 { Id = 102, Name = "Line", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 101, Name = "Daniel", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 108, Name = "Zayne", Designation = "Data Analyst", DOJ = new DateOnly(1991, 1, 1), IsActive = true },
            new Employee1 { Id = 109, Name = "Isha", Designation = "App Maker", DOJ = new DateOnly(1996, 7, 1), IsActive = true }
        })
    };
}
```

[See demo here](https://demos.blazorbootstrap.com/grid#data-parameter-assign-collection)

### Data parameter - Update collection

Assign a collection to the `Data` parameter to render the grid dynamically. The example below will render different department employees in the individual grid.

```cshtml {} showLineNumbers
@using BlazorBootstrap.Demo.Models;

<Button Type="ButtonType.Button" Color="ButtonColor.Primary" @onclick="AddEmployee"> Add Employee </Button>
<Button Type="ButtonType.Button" Color="ButtonColor.Primary" @onclick="AddEmployee2"> Add Employee 2 </Button>

<Grid @ref="grid" TItem="Employee1" class="table table-hover table-bordered table-striped mt-3" Data="employees">
    <GridColumn TItem="Employee1" HeaderText="Id" PropertyName="Id">
        @context.Id
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Employee Name" PropertyName="Name">
        @context.Name
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Designation" PropertyName="Designation">
        @context.Designation
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="DOJ" PropertyName="DOJ">
        @context.DOJ
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Active" PropertyName="IsActive">
        @context.IsActive
    </GridColumn>
</Grid>
```

```cs {} showLineNumbers
@code {
    Grid<Employee1> grid;

    private List<Employee1> employees;

    protected override void OnInitialized()
    {
        employees = new List<Employee1> {
            new Employee1 { Id = 107, Name = "Alice", Designation = "AI Engineer", DOJ = new DateOnly(1998, 11, 17), IsActive = true },
            new Employee1 { Id = 103, Name = "Bob", Designation = "Senior DevOps Engineer", DOJ = new DateOnly(1985, 1, 5), IsActive = true },
            new Employee1 { Id = 106, Name = "John", Designation = "Data Engineer", DOJ = new DateOnly(1995, 4, 17), IsActive = true },
            new Employee1 { Id = 104, Name = "Pop", Designation = "Associate Architect", DOJ = new DateOnly(1985, 6, 8), IsActive = false },
            new Employee1 { Id = 105, Name = "Ronald", Designation = "Senior Data Engineer", DOJ = new DateOnly(1991, 8, 23), IsActive = true }
        };
    }

    private async Task AddEmployee()
    {
        // for the same employees collection, we are adding an object
        // explicit grid refresh required
        employees.Add(CreateEmployee());
        await grid.RefreshDataAsync();
    }

    private void AddEmployee2()
    {
        // creates a shallow copy
        var emps = employees.GetRange(0, employees.Count);
        emps.Add(CreateEmployee());
        // now employees variable has a new reference. So no need to refresh the grid explicitly
        // explicit grid refresh is not required
        employees = emps;
    }

    private Employee1 CreateEmployee()
    {
        var emp = new Employee1();
        emp.Id = employees.Max(x => x.Id) + 1;
        emp.Name = $"Employee {emp.Id}";
        emp.Designation = $"QA Engineer {emp.Id}";
        emp.DOJ = new DateOnly(new Random().Next(1970, 2000), new Random().Next(1, 12), new Random().Next(1, 25));
        emp.IsActive = true;
        return emp;
    }
}
```

:::note
The **Add Employee** button click adds a new employee to the existing **employees** collection—so explicit grid refresh is required.

The **Add Employee 2** button click creates a shallow copy of the **employees** collection and adds a new employee. This new collection is assigned to the **employees** variable. Now, the **employees** variable has a new reference. So the grid will refresh automatically. An explicit grid refresh call is not required.
:::

[See demo here](https://demos.blazorbootstrap.com/grid#data-parameter-update-collection)

### Conditional css class for grid row

In the below example, we applied `table-danger` CSS class to the row where the employee is inactive and the `table-success` CSS class to the row where the employee designation is Architect.

<img src="https://i.imgur.com/TYW4VsK.png" alt="Blazor Bootstrap: Grid Component - Conditional css class for grid row" />

```cshtml {9} showLineNumbers
<Grid TItem="Employee1"
      Class="table table-hover table-bordered"
      DataProvider="EmployeesDataProvider"
      AllowFiltering="true"
      AllowPaging="true"
      PageSize="5"
      AllowSorting="true"
      Responsive="true"
      RowClass="GetRowClass">

    <GridColumn TItem="Employee1" HeaderText="Id" PropertyName="Id" SortKeySelector="item => item.Id">
        @context.Id
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Employee Name" PropertyName="Name" SortKeySelector="item => item.Name">
        @context.Name
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Designation" PropertyName="Designation" SortKeySelector="item => item.Designation">
        @context.Designation
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="DOJ" PropertyName="DOJ" SortKeySelector="item => item.DOJ">
        @context.DOJ
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Active" PropertyName="IsActive" SortKeySelector="item => item.IsActive">
        @context.IsActive
    </GridColumn>

</Grid>
```

```cs {12-20} showLineNumbers
@code {
    private IEnumerable<Employee1> employees;

    private async Task<GridDataProviderResult<Employee1>> EmployeesDataProvider(GridDataProviderRequest<Employee1> request)
    {
        if (employees is null) // pull employees only one time for client-side filtering, sorting, and paging
            employees = GetEmployees(); // call a service or an API to pull the employees

        return await Task.FromResult(request.ApplyTo(employees));
    }

    private string GetRowClass(Employee1 emp)
    {
        if (!emp.IsActive)
            return "table-danger";
        else if (emp.Designation == "Architect")
            return "table-success";

        return string.Empty;
    }

    private IEnumerable<Employee1> GetEmployees()
    {
        return new List<Employee1>
        {
            new Employee1 { Id = 107, Name = "Alice", Designation = "AI Engineer", DOJ = new DateOnly(1998, 11, 17), IsActive = true },
            new Employee1 { Id = 103, Name = "Bob", Designation = "Senior DevOps Engineer", DOJ = new DateOnly(1985, 1, 5), IsActive = true },
            new Employee1 { Id = 106, Name = "John", Designation = "Data Engineer", DOJ = new DateOnly(1995, 4, 17), IsActive = true },
            new Employee1 { Id = 104, Name = "Pop", Designation = "Associate Architect", DOJ = new DateOnly(1985, 6, 8), IsActive = false },
            new Employee1 { Id = 105, Name = "Ronald", Designation = "Senior Data Engineer", DOJ = new DateOnly(1991, 8, 23), IsActive = true },
            new Employee1 { Id = 102, Name = "Line", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 101, Name = "Daniel", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 113, Name = "Merlin", Designation = "Senior Consultant", DOJ = new DateOnly(1989, 10, 2), IsActive = true },
            new Employee1 { Id = 117, Name = "Sharna", Designation = "Data Analyst", DOJ = new DateOnly(1994, 5, 12), IsActive = true },
            new Employee1 { Id = 108, Name = "Zayne", Designation = "Data Analyst", DOJ = new DateOnly(1991, 1, 1), IsActive = true },
            new Employee1 { Id = 109, Name = "Isha", Designation = "App Maker", DOJ = new DateOnly(1996, 7, 1), IsActive = true },
            new Employee1 { Id = 111, Name = "Glenda", Designation = "Data Engineer", DOJ = new DateOnly(1994, 1, 12), IsActive = true },
        };
    }
}
```

[See demo here](https://demos.blazorbootstrap.com/grid#conditional-css-class-for-grid-row)

### Conditional css class for grid column

In the below example, we applied `table-danger` CSS class to the Active column where the employee is inactive and the `table-success` CSS class to the Active column where the employee is active.

<img src="https://i.imgur.com/XlatgsB.png" alt="Blazor Bootstrap: Grid Component - Conditional css class for grid column" />

```cshtml {26} showLineNumbers
<Grid TItem="Employee1"
      Class="table table-hover table-bordered"
      DataProvider="EmployeesDataProvider"
      AllowFiltering="true"
      AllowPaging="true"
      PageSize="5"
      AllowSorting="true"
      Responsive="true">

    <GridColumn TItem="Employee1" HeaderText="Id" PropertyName="Id" SortKeySelector="item => item.Id">
        @context.Id
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Employee Name" PropertyName="Name" SortKeySelector="item => item.Name">
        @context.Name
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Designation" PropertyName="Designation" SortKeySelector="item => item.Designation">
        @context.Designation
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="DOJ" PropertyName="DOJ" SortKeySelector="item => item.DOJ">
        @context.DOJ
    </GridColumn>
    <GridColumn TItem="Employee1"
                HeaderText="Active"
                PropertyName="IsActive"
                SortKeySelector="item => item.IsActive"
                ColumnClass="@(x => x.IsActive ? "table-success" : "table-danger")">
        @context.IsActive
    </GridColumn>

</Grid>
```
```cs {} showLineNumbers
@code {
    private IEnumerable<Employee1> employees;

    private async Task<GridDataProviderResult<Employee1>> EmployeesDataProvider(GridDataProviderRequest<Employee1> request)
    {
        if (employees is null) // pull employees only one time for client-side filtering, sorting, and paging
            employees = GetEmployees(); // call a service or an API to pull the employees

        return await Task.FromResult(request.ApplyTo(employees));
    }

    private IEnumerable<Employee1> GetEmployees()
    {
        return new List<Employee1>
        {
            new Employee1 { Id = 107, Name = "Alice", Designation = "AI Engineer", DOJ = new DateOnly(1998, 11, 17), IsActive = true },
            new Employee1 { Id = 103, Name = "Bob", Designation = "Senior DevOps Engineer", DOJ = new DateOnly(1985, 1, 5), IsActive = true },
            new Employee1 { Id = 106, Name = "John", Designation = "Data Engineer", DOJ = new DateOnly(1995, 4, 17), IsActive = true },
            new Employee1 { Id = 104, Name = "Pop", Designation = "Associate Architect", DOJ = new DateOnly(1985, 6, 8), IsActive = false },
            new Employee1 { Id = 105, Name = "Ronald", Designation = "Senior Data Engineer", DOJ = new DateOnly(1991, 8, 23), IsActive = true },
            new Employee1 { Id = 102, Name = "Line", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 101, Name = "Daniel", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 113, Name = "Merlin", Designation = "Senior Consultant", DOJ = new DateOnly(1989, 10, 2), IsActive = true },
            new Employee1 { Id = 117, Name = "Sharna", Designation = "Data Analyst", DOJ = new DateOnly(1994, 5, 12), IsActive = true },
            new Employee1 { Id = 108, Name = "Zayne", Designation = "Data Analyst", DOJ = new DateOnly(1991, 1, 1), IsActive = true },
            new Employee1 { Id = 109, Name = "Isha", Designation = "App Maker", DOJ = new DateOnly(1996, 7, 1), IsActive = true },
            new Employee1 { Id = 111, Name = "Glenda", Designation = "Data Engineer", DOJ = new DateOnly(1994, 1, 12), IsActive = true },
        };
    }
}
```

[See demo here](https://demos.blazorbootstrap.com/grid#conditional-css-class-for-grid-column)

### Custom column headers

In the below example, we use `<HeaderContent>` and `<ChildContent>` tags to define custom column header and cell content. When defining header content, filters and sorting are removed from column.

<img src="https://i.imgur.com/yeTbaNT.png" alt="Blazor Bootstrap: Grid Component - Custom column headers" />

```cshtml {23-29} showLineNumbers
<Grid TItem="Employee1"
      Class="table table-hover table-bordered"
      DataProvider="EmployeesDataProvider"
      AllowFiltering="true"
      AllowPaging="true"
      PageSize="5"
      AllowSorting="true"
      Responsive="true">

    <GridColumn TItem="Employee1" HeaderText="Id" PropertyName="Id" SortKeySelector="item => item.Id">
        @context.Id
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Employee Name" PropertyName="Name" SortKeySelector="item => item.Name">
        @context.Name
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Designation" PropertyName="Designation" SortKeySelector="item => item.Designation">
        @context.Designation
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="DOJ" PropertyName="DOJ" SortKeySelector="item => item.DOJ">
        @context.DOJ
    </GridColumn>
    <GridColumn TItem="Employee1" PropertyName="IsActive" Filterable="false" Sortable="false">
      <HeaderContent>
        <Switch @bind-Value="IsAllChecked"/>
      </HeaderContent>
      <ChildContent>
        <Switch @bind-Value="@context.IsActive"/>
      </ChildContent>
    </GridColumn>

</Grid>
```
```cs {4-8} showLineNumbers
@code {
    private IEnumerable<Employee1> employees;

    private bool IsAllChecked
    {
        get => employees.All(e => e.IsActive);
        set => Array.ForEach(employees.ToArray(), e => e.IsActive = value);
    }

    private async Task<GridDataProviderResult<Employee1>> EmployeesDataProvider(GridDataProviderRequest<Employee1> request)
    {
        if (employees is null) // pull employees only one time for client-side filtering, sorting, and paging
            employees = GetEmployees(); // call a service or an API to pull the employees

        return await Task.FromResult(request.ApplyTo(employees));
    }

    private IEnumerable<Employee1> GetEmployees()
    {
        return new List<Employee1>
        {
            new Employee1 { Id = 107, Name = "Alice", Designation = "AI Engineer", DOJ = new DateOnly(1998, 11, 17), IsActive = true },
            new Employee1 { Id = 103, Name = "Bob", Designation = "Senior DevOps Engineer", DOJ = new DateOnly(1985, 1, 5), IsActive = true },
            new Employee1 { Id = 106, Name = "John", Designation = "Data Engineer", DOJ = new DateOnly(1995, 4, 17), IsActive = true },
            new Employee1 { Id = 104, Name = "Pop", Designation = "Associate Architect", DOJ = new DateOnly(1985, 6, 8), IsActive = false },
            new Employee1 { Id = 105, Name = "Ronald", Designation = "Senior Data Engineer", DOJ = new DateOnly(1991, 8, 23), IsActive = true },
            new Employee1 { Id = 102, Name = "Line", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 101, Name = "Daniel", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 113, Name = "Merlin", Designation = "Senior Consultant", DOJ = new DateOnly(1989, 10, 2), IsActive = true },
            new Employee1 { Id = 117, Name = "Sharna", Designation = "Data Analyst", DOJ = new DateOnly(1994, 5, 12), IsActive = true },
            new Employee1 { Id = 108, Name = "Zayne", Designation = "Data Analyst", DOJ = new DateOnly(1991, 1, 1), IsActive = true },
            new Employee1 { Id = 109, Name = "Isha", Designation = "App Maker", DOJ = new DateOnly(1996, 7, 1), IsActive = true },
            new Employee1 { Id = 111, Name = "Glenda", Designation = "Data Engineer", DOJ = new DateOnly(1994, 1, 12), IsActive = true },
        };
    }
}
```

### Selection

Set `AllowSelection="true"` to enable the selection on the Grid. By default, SelectionMode is **Single**.

<img src="https://i.imgur.com/u1lV12d.png" alt="Blazor Bootstrap: Grid Component - Selection" />

```cshtml {4-5} showLineNumbers
<Grid TItem="Employee1"
      Class="table table-hover table-bordered"
      DataProvider="EmployeesDataProvider"
      AllowSelection="true"
      SelectedItemsChanged="OnSelectedItemsChanged"
      Responsive="true">

    <GridColumn TItem="Employee1" HeaderText="Id" PropertyName="Id">
        @context.Id
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Employee Name" PropertyName="Name">
        @context.Name
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Designation" PropertyName="Designation">
        @context.Designation
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="DOJ" PropertyName="DOJ">
        @context.DOJ
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Active" PropertyName="IsActive">
        @context.IsActive
    </GridColumn>

</Grid>

<div class="mt-3">
    Selected Items Count: @selectedEmployees.Count
</div>

<div class="mt-2">
    Selected Employees:
    <ul>
        @foreach (var emp in selectedEmployees)
        {
            <li>@emp.Name</li>
        }
    </ul>
</div>
```

```cs {32-36} showLineNumbers
@code {
    private IEnumerable<Employee1> employees = default!;

    private HashSet<Employee1> selectedEmployees = new();

    private async Task<GridDataProviderResult<Employee1>> EmployeesDataProvider(GridDataProviderRequest<Employee1> request)
    {
        Console.WriteLine("EmployeesDataProvider called...");

        if (employees is null) // pull employees only one time for client-side filtering, sorting, and paging
            employees = GetEmployees(); // call a service or an API to pull the employees

        return await Task.FromResult(request.ApplyTo(employees));
    }

    private IEnumerable<Employee1> GetEmployees()
    {
        return new List<Employee1>
        {
            new Employee1 { Id = 107, Name = "Alice", Designation = "AI Engineer", DOJ = new DateOnly(1998, 11, 17), IsActive = true },
            new Employee1 { Id = 103, Name = "Bob", Designation = "Senior DevOps Engineer", DOJ = new DateOnly(1985, 1, 5), IsActive = true },
            new Employee1 { Id = 106, Name = "John", Designation = "Data Engineer", DOJ = new DateOnly(1995, 4, 17), IsActive = true },
            new Employee1 { Id = 104, Name = "Pop", Designation = "Associate Architect", DOJ = new DateOnly(1985, 6, 8), IsActive = false },
            new Employee1 { Id = 105, Name = "Ronald", Designation = "Senior Data Engineer", DOJ = new DateOnly(1991, 8, 23), IsActive = true },
            new Employee1 { Id = 102, Name = "Line", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 101, Name = "Daniel", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 108, Name = "Zayne", Designation = "Data Analyst", DOJ = new DateOnly(1991, 1, 1), IsActive = true },
            new Employee1 { Id = 109, Name = "Isha", Designation = "App Maker", DOJ = new DateOnly(1996, 7, 1), IsActive = true },
        };
    }

    private Task OnSelectedItemsChanged(HashSet<Employee1> employees)
    {
        selectedEmployees = employees is not null && employees.Any() ? employees : new();
        return Task.CompletedTask;
    }
}
```

[See demo here](https://demos.blazorbootstrap.com/grid#selection)

### Multiple selection

To select multiple rows, set `SelectionMode="GridSelectionMode.Multiple"`.

<img src="https://i.imgur.com/yzJETf8.png" alt="Blazor Bootstrap: Grid Component - Multiple selection" />

```cshtml {4-6} showLineNumbers
<Grid TItem="Employee1"
      Class="table table-hover table-bordered"
      DataProvider="EmployeesDataProvider"
      AllowSelection="true"
      SelectionMode="GridSelectionMode.Multiple"
      SelectedItemsChanged="OnSelectedItemsChanged"
      Responsive="true">

    <GridColumn TItem="Employee1" HeaderText="Id" PropertyName="Id">
        @context.Id
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Employee Name" PropertyName="Name">
        @context.Name
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Designation" PropertyName="Designation">
        @context.Designation
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="DOJ" PropertyName="DOJ">
        @context.DOJ
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Active" PropertyName="IsActive">
        @context.IsActive
    </GridColumn>

</Grid>

<div class="mt-3">
    Selected Items Count: @selectedEmployees.Count
</div>

<div class="mt-2">
    Selected Employees:
    <ul>
        @foreach (var emp in selectedEmployees)
        {
            <li>@emp.Name</li>
        }
    </ul>
</div>
```

```cs {32-36} showLineNumbers
@code {
    private IEnumerable<Employee1> employees = default!;

    private HashSet<Employee1> selectedEmployees = new();

    private async Task<GridDataProviderResult<Employee1>> EmployeesDataProvider(GridDataProviderRequest<Employee1> request)
    {
        Console.WriteLine("EmployeesDataProvider called...");

        if (employees is null) // pull employees only one time for client-side filtering, sorting, and paging
            employees = GetEmployees(); // call a service or an API to pull the employees

        return await Task.FromResult(request.ApplyTo(employees));
    }

    private IEnumerable<Employee1> GetEmployees()
    {
        return new List<Employee1>
        {
            new Employee1 { Id = 107, Name = "Alice", Designation = "AI Engineer", DOJ = new DateOnly(1998, 11, 17), IsActive = true },
            new Employee1 { Id = 103, Name = "Bob", Designation = "Senior DevOps Engineer", DOJ = new DateOnly(1985, 1, 5), IsActive = true },
            new Employee1 { Id = 106, Name = "John", Designation = "Data Engineer", DOJ = new DateOnly(1995, 4, 17), IsActive = true },
            new Employee1 { Id = 104, Name = "Pop", Designation = "Associate Architect", DOJ = new DateOnly(1985, 6, 8), IsActive = false },
            new Employee1 { Id = 105, Name = "Ronald", Designation = "Senior Data Engineer", DOJ = new DateOnly(1991, 8, 23), IsActive = true },
            new Employee1 { Id = 102, Name = "Line", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 101, Name = "Daniel", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 108, Name = "Zayne", Designation = "Data Analyst", DOJ = new DateOnly(1991, 1, 1), IsActive = true },
            new Employee1 { Id = 109, Name = "Isha", Designation = "App Maker", DOJ = new DateOnly(1996, 7, 1), IsActive = true },
        };
    }

    private Task OnSelectedItemsChanged(HashSet<Employee1> employees)
    {
        selectedEmployees = employees is not null && employees.Any() ? employees : new();
        return Task.CompletedTask;
    }
}
```

[See demo here](https://demos.blazorbootstrap.com/grid#multiple-selection)

### Disable selection

We can disable the header checkbox or row level checkbox based on a condition. 
For this, we have `DisableAllRowsSelection` and `DisableRowSelection` delegate parameters. 
In the below example, we disabled the header checkbox if any of the employee Id is less than 105. 
Also, disable check the row level checkbox if the employee Id is less than 105.

<img src="https://i.imgur.com/v0x4C16.png" alt="Blazor Bootstrap: Grid Component - Disable selection" />

```cshtml {4-8} showLineNumbers
<Grid TItem="Employee1"
      Class="table table-hover table-bordered"
      DataProvider="EmployeesDataProvider"
      AllowSelection="true"
      SelectionMode="GridSelectionMode.Multiple"
      DisableAllRowsSelection="DisableAllRowsSelectionHandler"
      DisableRowSelection="DisableRowSelectionHandler"
      SelectedItemsChanged="OnSelectedItemsChanged"
      Responsive="true">

    <GridColumn TItem="Employee1" HeaderText="Id" PropertyName="Id">
        @context.Id
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Employee Name" PropertyName="Name">
        @context.Name
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Designation" PropertyName="Designation">
        @context.Designation
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="DOJ" PropertyName="DOJ">
        @context.DOJ
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Active" PropertyName="IsActive">
        @context.IsActive
    </GridColumn>

</Grid>

<div class="mt-3">
    Selected Items Count: @selectedEmployees.Count
</div>

<div class="mt-2">
    Selected Employees:
    <ul>
        @foreach (var emp in selectedEmployees)
        {
            <li>@emp.Name</li>
        }
    </ul>
</div>
```

```cs {30-33,35-38,40-44} showLineNumbers
@code {
    private IEnumerable<Employee1> employees = default!;

    private HashSet<Employee1> selectedEmployees = new();

    private async Task<GridDataProviderResult<Employee1>> EmployeesDataProvider(GridDataProviderRequest<Employee1> request)
    {
        if (employees is null) // pull employees only one time for client-side filtering, sorting, and paging
            employees = GetEmployees(); // call a service or an API to pull the employees

        return await Task.FromResult(request.ApplyTo(employees));
    }

    private IEnumerable<Employee1> GetEmployees()
    {
        return new List<Employee1>
        {
            new Employee1 { Id = 107, Name = "Alice", Designation = "AI Engineer", DOJ = new DateOnly(1998, 11, 17), IsActive = true },
            new Employee1 { Id = 103, Name = "Bob", Designation = "Senior DevOps Engineer", DOJ = new DateOnly(1985, 1, 5), IsActive = true },
            new Employee1 { Id = 106, Name = "John", Designation = "Data Engineer", DOJ = new DateOnly(1995, 4, 17), IsActive = true },
            new Employee1 { Id = 104, Name = "Pop", Designation = "Associate Architect", DOJ = new DateOnly(1985, 6, 8), IsActive = false },
            new Employee1 { Id = 105, Name = "Ronald", Designation = "Senior Data Engineer", DOJ = new DateOnly(1991, 8, 23), IsActive = true },
            new Employee1 { Id = 102, Name = "Line", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 101, Name = "Daniel", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 108, Name = "Zayne", Designation = "Data Analyst", DOJ = new DateOnly(1991, 1, 1), IsActive = true },
            new Employee1 { Id = 109, Name = "Isha", Designation = "App Maker", DOJ = new DateOnly(1996, 7, 1), IsActive = true },
        };
    }

    private bool DisableAllRowsSelectionHandler(IEnumerable<Employee1> employees)
    {
        return employees.Any(x => x.Id < 105); // disable selection if EmployeeId < 105
    }

    private bool DisableRowSelectionHandler(Employee1 emp)
    {
        return emp.Id < 105; // disable selection if EmployeeId < 105
    }

    private Task OnSelectedItemsChanged(HashSet<Employee1> employees)
    {
        selectedEmployees = employees is not null && employees.Any() ? employees : new();
        return Task.CompletedTask;
    }
}
```

[See demo here](https://demos.blazorbootstrap.com/grid#disable-selection)

### Dynamic page size

<img src="https://user-images.githubusercontent.com/2337067/239613002-c7b4b6f6-be67-4f14-accc-b3dd390eb0f9.png" alt="Blazor Bootstrap: Grid Component - Dynamic page size" />

```cshtml {5,26-28} showLineNumbers
<Grid TItem="Employee1"
      Class="table table-hover table-bordered table-striped"
      DataProvider="EmployeesDataProvider"
      AllowPaging="true"
      PageSize="@pageSize"
      Responsive="true">

    <GridColumn TItem="Employee1" HeaderText="Id">
        @context.Id
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Employee Name">
        @context.Name
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Designation">
        @context.Designation
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="DOJ">
        @context.DOJ
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Active">
        @context.IsActive
    </GridColumn>

</Grid>

<Button Type="ButtonType.Button" Color="ButtonColor.Primary" @onclick="() => ChangeSize(5)">Grid Size 5</Button>
<Button Type="ButtonType.Button" Color="ButtonColor.Secondary" @onclick="() => ChangeSize(10)">Grid Size 10</Button>
<Button Type="ButtonType.Button" Color="ButtonColor.Secondary" @onclick="() => ChangeSize(15)">Grid Size 15</Button>
```

```cs {2,32} showLineNumbers
@code {
    private int pageSize = 5;
    private IEnumerable<Employee1> employees = default!;

    private async Task<GridDataProviderResult<Employee1>> EmployeesDataProvider(GridDataProviderRequest<Employee1> request)
    {
        if (employees is null) // pull employees only one time for client-side filtering, sorting, and paging
            employees = GetEmployees(); // call a service or an API to pull the employees

        return await Task.FromResult(request.ApplyTo(employees));
    }

    private IEnumerable<Employee1> GetEmployees()
    {
        return new List<Employee1>
        {
            new Employee1 { Id = 107, Name = "Alice", Designation = "AI Engineer", DOJ = new DateOnly(1998, 11, 17), IsActive = true },
            new Employee1 { Id = 103, Name = "Bob", Designation = "Senior DevOps Engineer", DOJ = new DateOnly(1985, 1, 5), IsActive = true },
            new Employee1 { Id = 106, Name = "John", Designation = "Data Engineer", DOJ = new DateOnly(1995, 4, 17), IsActive = true },
            new Employee1 { Id = 104, Name = "Pop", Designation = "Associate Architect", DOJ = new DateOnly(1985, 6, 8), IsActive = false },
            new Employee1 { Id = 105, Name = "Ronald", Designation = "Senior Data Engineer", DOJ = new DateOnly(1991, 8, 23), IsActive = true },
            new Employee1 { Id = 102, Name = "Line", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 101, Name = "Daniel", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 113, Name = "Merlin", Designation = "Senior Consultant", DOJ = new DateOnly(1989, 10, 2), IsActive = true },
            new Employee1 { Id = 117, Name = "Sharna", Designation = "Data Analyst", DOJ = new DateOnly(1994, 5, 12), IsActive = true },
            new Employee1 { Id = 108, Name = "Zayne", Designation = "Data Analyst", DOJ = new DateOnly(1991, 1, 1), IsActive = true },
            new Employee1 { Id = 109, Name = "Isha", Designation = "App Maker", DOJ = new DateOnly(1996, 7, 1), IsActive = true },
            new Employee1 { Id = 111, Name = "Glenda", Designation = "Data Engineer", DOJ = new DateOnly(1994, 1, 12), IsActive = true },
        };
    }

    private void ChangeSize(int size) => pageSize = size;
}
```

[See demo here](https://demos.blazorbootstrap.com/grid#dynamic-page-size)

### Page size selection

<img src="https://user-images.githubusercontent.com/2337067/239613340-3917f4fa-a252-4e5e-a3b5-27b83304cbc2.png" alt="Blazor Bootstrap: Grid Component - Page size selection" />

```cshtml {5-7} showLineNumbers
<Grid TItem="Employee1"
      Class="table table-hover table-bordered table-striped"
      DataProvider="EmployeesDataProvider"
      AllowPaging="true"
      PageSize="10"
      PageSizeSelectorVisible="true"
      PageSizeSelectorItems="@(new int[] { 5,10,20 })"
      Responsive="true">

    <GridColumn TItem="Employee1" HeaderText="Id">
        @context.Id
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Employee Name">
        @context.Name
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Designation">
        @context.Designation
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="DOJ">
        @context.DOJ
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Active">
        @context.IsActive
    </GridColumn>

</Grid>
```

```cs {} showLineNumbers
@code {
    private IEnumerable<Employee1> employees = default!;

    private async Task<GridDataProviderResult<Employee1>> EmployeesDataProvider(GridDataProviderRequest<Employee1> request)
    {
        if (employees is null) // pull employees only one time for client-side filtering, sorting, and paging
            employees = GetEmployees(); // call a service or an API to pull the employees

        return await Task.FromResult(request.ApplyTo(employees));
    }

    private IEnumerable<Employee1> GetEmployees()
    {
        return new List<Employee1>
        {
            new Employee1 { Id = 107, Name = "Alice", Designation = "AI Engineer", DOJ = new DateOnly(1998, 11, 17), IsActive = true },
            new Employee1 { Id = 103, Name = "Bob", Designation = "Senior DevOps Engineer", DOJ = new DateOnly(1985, 1, 5), IsActive = true },
            new Employee1 { Id = 106, Name = "John", Designation = "Data Engineer", DOJ = new DateOnly(1995, 4, 17), IsActive = true },
            new Employee1 { Id = 104, Name = "Pop", Designation = "Associate Architect", DOJ = new DateOnly(1985, 6, 8), IsActive = false },
            new Employee1 { Id = 105, Name = "Ronald", Designation = "Senior Data Engineer", DOJ = new DateOnly(1991, 8, 23), IsActive = true },
            new Employee1 { Id = 102, Name = "Line", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 101, Name = "Daniel", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 113, Name = "Merlin", Designation = "Senior Consultant", DOJ = new DateOnly(1989, 10, 2), IsActive = true },
            new Employee1 { Id = 117, Name = "Sharna", Designation = "Data Analyst", DOJ = new DateOnly(1994, 5, 12), IsActive = true },
            new Employee1 { Id = 108, Name = "Zayne", Designation = "Data Analyst", DOJ = new DateOnly(1991, 1, 1), IsActive = true },
            new Employee1 { Id = 109, Name = "Isha", Designation = "App Maker", DOJ = new DateOnly(1996, 7, 1), IsActive = true },
            new Employee1 { Id = 111, Name = "Glenda", Designation = "Data Engineer", DOJ = new DateOnly(1994, 1, 12), IsActive = true },
        };
    }
}
```

[See demo here](https://demos.blazorbootstrap.com/grid#page-size-selection)

### Header row css class

<img src="https://i.imgur.com/KIqBefV.png" alt="Blazor Bootstrap: Grid Component - Header row css class" />

```cshtml {5,34,63,92} showLineNumbers
<Grid TItem="Employee1"
      AllowSorting="true"
      Class="table table-hover"
      DataProvider="EmployeesDataProvider"
      HeaderRowCssClass="bg-primary text-white border-bottom-0"
      Responsive="true">

    <GridColumn TItem="Employee1" HeaderText="Id" SortKeySelector="item => item.Id">
        @context.Id
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="Employee Name" SortKeySelector="item => item.Name">
        @context.Name
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="Designation" SortKeySelector="item => item.Designation">
        @context.Designation
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="DOJ" SortKeySelector="item => item.DOJ">
        @context.DOJ
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="Active" SortKeySelector="item => item.IsActive">
        @context.IsActive
    </GridColumn>

</Grid>

<Grid TItem="Employee1"
      AllowSorting="true"
      Class="table table-hover"
      DataProvider="EmployeesDataProvider"
      HeaderRowCssClass="bg-primary text-white bg-opacity-75 border-bottom-0"
      Responsive="true">

    <GridColumn TItem="Employee1" HeaderText="Id" SortKeySelector="item => item.Id">
        @context.Id
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="Employee Name" SortKeySelector="item => item.Name">
        @context.Name
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="Designation" SortKeySelector="item => item.Designation">
        @context.Designation
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="DOJ" SortKeySelector="item => item.DOJ">
        @context.DOJ
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="Active" SortKeySelector="item => item.IsActive">
        @context.IsActive
    </GridColumn>

</Grid>

<Grid TItem="Employee1"
             AllowSorting="true"
             Class="table table-hover"
             DataProvider="EmployeesDataProvider"
             HeaderRowCssClass="bg-success text-white border-bottom-0"
             Responsive="true">

    <GridColumn TItem="Employee1" HeaderText="Id" SortKeySelector="item => item.Id">
        @context.Id
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="Employee Name" SortKeySelector="item => item.Name">
        @context.Name
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="Designation" SortKeySelector="item => item.Designation">
        @context.Designation
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="DOJ" SortKeySelector="item => item.DOJ">
        @context.DOJ
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="Active" SortKeySelector="item => item.IsActive">
        @context.IsActive
    </GridColumn>

</Grid>

<Grid TItem="Employee1"
      AllowSorting="true"
      Class="table table-hover"
      DataProvider="EmployeesDataProvider"
      HeaderRowCssClass="bg-success text-white bg-opacity-75 border-bottom-0"
      Responsive="true">

    <GridColumn TItem="Employee1" HeaderText="Id" SortKeySelector="item => item.Id">
        @context.Id
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="Employee Name" SortKeySelector="item => item.Name">
        @context.Name
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="Designation" SortKeySelector="item => item.Designation">
        @context.Designation
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="DOJ" SortKeySelector="item => item.DOJ">
        @context.DOJ
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="Active" SortKeySelector="item => item.IsActive">
        @context.IsActive
    </GridColumn>

</Grid>
```

```cs {} showLineNumbers
@code {
    private IEnumerable<Employee1> employees = default!;

    private async Task<GridDataProviderResult<Employee1>> EmployeesDataProvider(GridDataProviderRequest<Employee1> request)
    {
        if (employees is null) // pull employees only one time for client-side filtering, sorting, and paging
            employees = GetEmployees(); // call a service or an API to pull the employees

        return await Task.FromResult(request.ApplyTo(employees));
    }

    private IEnumerable<Employee1> GetEmployees()
    {
        return new List<Employee1>
        {
            new Employee1 { Id = 103, Name = "Bob", Designation = "Senior DevOps Engineer", DOJ = new DateOnly(1985, 1, 5), IsActive = true },
            new Employee1 { Id = 106, Name = "John", Designation = "Data Engineer", DOJ = new DateOnly(1995, 4, 17), IsActive = true },
            new Employee1 { Id = 104, Name = "Pop", Designation = "Associate Architect", DOJ = new DateOnly(1985, 6, 8), IsActive = false },
            new Employee1 { Id = 105, Name = "Ronald", Designation = "Senior Data Engineer", DOJ = new DateOnly(1991, 8, 23), IsActive = true },
            new Employee1 { Id = 102, Name = "Line", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 101, Name = "Daniel", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
        };
    }
}
```

[See demo here](https://demos.blazorbootstrap.com/grid#header-row-css-class)

### Filters row css class

<img src="https://i.imgur.com/11SK9v4.png" alt="Blazor Bootstrap: Grid Component - Filters row css class" />

```cshtml {7,38,69,100,131,162,193} showLineNumbers
<Grid TItem="Employee1"
      AllowFiltering="true"
      AllowSorting="true"
      Class="table table-hover"
      DataProvider="EmployeesDataProvider"
      HeaderRowCssClass="bg-primary text-white border-bottom-0"
      FiltersRowCssClass="bg-primary text-white bg-opacity-25 border-bottom-0"
      Responsive="true">

    <GridColumn TItem="Employee1" HeaderText="Id" PropertyName="Id" SortKeySelector="item => item.Id">
        @context.Id
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="Employee Name" PropertyName="Name" SortKeySelector="item => item.Name">
        @context.Name
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="Designation" PropertyName="Designation" SortKeySelector="item => item.Designation">
        @context.Designation
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="DOJ" PropertyName="DOJ" SortKeySelector="item => item.DOJ">
        @context.DOJ
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="Active" PropertyName="IsActive" SortKeySelector="item => item.IsActive">
        @context.IsActive
    </GridColumn>

</Grid>

<Grid TItem="Employee1"
      AllowFiltering="true"
      AllowSorting="true"
      Class="table table-hover"
      DataProvider="EmployeesDataProvider"
      HeaderRowCssClass="bg-warning text-white border-bottom-0"
      FiltersRowCssClass="bg-warning text-white bg-opacity-25 border-bottom-0"
      Responsive="true">

    <GridColumn TItem="Employee1" HeaderText="Id" PropertyName="Id" SortKeySelector="item => item.Id">
        @context.Id
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="Employee Name" PropertyName="Name" SortKeySelector="item => item.Name">
        @context.Name
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="Designation" PropertyName="Designation" SortKeySelector="item => item.Designation">
        @context.Designation
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="DOJ" PropertyName="DOJ" SortKeySelector="item => item.DOJ">
        @context.DOJ
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="Active" PropertyName="IsActive" SortKeySelector="item => item.IsActive">
        @context.IsActive
    </GridColumn>

</Grid>

<Grid TItem="Employee1"
      AllowFiltering="true"
      AllowSorting="true"
      Class="table table-hover"
      DataProvider="EmployeesDataProvider"
      HeaderRowCssClass="bg-danger text-white border-bottom-0"
      FiltersRowCssClass="bg-danger text-white bg-opacity-25 border-bottom-0"
      Responsive="true">

    <GridColumn TItem="Employee1" HeaderText="Id" PropertyName="Id" SortKeySelector="item => item.Id">
        @context.Id
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="Employee Name" PropertyName="Name" SortKeySelector="item => item.Name">
        @context.Name
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="Designation" PropertyName="Designation" SortKeySelector="item => item.Designation">
        @context.Designation
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="DOJ" PropertyName="DOJ" SortKeySelector="item => item.DOJ">
        @context.DOJ
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="Active" PropertyName="IsActive" SortKeySelector="item => item.IsActive">
        @context.IsActive
    </GridColumn>

</Grid>

<Grid TItem="Employee1"
      AllowFiltering="true"
      AllowSorting="true"
      Class="table table-hover"
      DataProvider="EmployeesDataProvider"
      HeaderRowCssClass="bg-success text-white border-bottom-0"
      FiltersRowCssClass="bg-success text-white bg-opacity-25 border-bottom-0"
      Responsive="true">

    <GridColumn TItem="Employee1" HeaderText="Id" PropertyName="Id" SortKeySelector="item => item.Id">
        @context.Id
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="Employee Name" PropertyName="Name" SortKeySelector="item => item.Name">
        @context.Name
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="Designation" PropertyName="Designation" SortKeySelector="item => item.Designation">
        @context.Designation
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="DOJ" PropertyName="DOJ" SortKeySelector="item => item.DOJ">
        @context.DOJ
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="Active" PropertyName="IsActive" SortKeySelector="item => item.IsActive">
        @context.IsActive
    </GridColumn>

</Grid>

<Grid TItem="Employee1"
      AllowFiltering="true"
      AllowSorting="true"
      Class="table table-hover"
      DataProvider="EmployeesDataProvider"
      HeaderRowCssClass="bg-info text-white border-bottom-0"
      FiltersRowCssClass="bg-info text-white bg-opacity-25 border-bottom-0"
      Responsive="true">

    <GridColumn TItem="Employee1" HeaderText="Id" PropertyName="Id" SortKeySelector="item => item.Id">
        @context.Id
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="Employee Name" PropertyName="Name" SortKeySelector="item => item.Name">
        @context.Name
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="Designation" PropertyName="Designation" SortKeySelector="item => item.Designation">
        @context.Designation
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="DOJ" PropertyName="DOJ" SortKeySelector="item => item.DOJ">
        @context.DOJ
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="Active" PropertyName="IsActive" SortKeySelector="item => item.IsActive">
        @context.IsActive
    </GridColumn>

</Grid>

<Grid TItem="Employee1"
      AllowFiltering="true"
      AllowSorting="true"
      Class="table table-hover"
      DataProvider="EmployeesDataProvider"
      HeaderRowCssClass="bg-dark text-white border-bottom-0"
      FiltersRowCssClass="bg-dark text-white bg-opacity-25 border-bottom-0"
      Responsive="true">

    <GridColumn TItem="Employee1" HeaderText="Id" PropertyName="Id" SortKeySelector="item => item.Id">
        @context.Id
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="Employee Name" PropertyName="Name" SortKeySelector="item => item.Name">
        @context.Name
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="Designation" PropertyName="Designation" SortKeySelector="item => item.Designation">
        @context.Designation
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="DOJ" PropertyName="DOJ" SortKeySelector="item => item.DOJ">
        @context.DOJ
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="Active" PropertyName="IsActive" SortKeySelector="item => item.IsActive">
        @context.IsActive
    </GridColumn>

</Grid>

<Grid TItem="Employee1"
      AllowFiltering="true"
      AllowSorting="true"
      Class="table table-hover"
      DataProvider="EmployeesDataProvider"
      HeaderRowCssClass="bg-secondary text-white border-bottom-0"
      FiltersRowCssClass="bg-secondary text-white bg-opacity-25 border-bottom-0"
      Responsive="true">

    <GridColumn TItem="Employee1" HeaderText="Id" PropertyName="Id" SortKeySelector="item => item.Id">
        @context.Id
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="Employee Name" PropertyName="Name" SortKeySelector="item => item.Name">
        @context.Name
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="Designation" PropertyName="Designation" SortKeySelector="item => item.Designation">
        @context.Designation
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="DOJ" PropertyName="DOJ" SortKeySelector="item => item.DOJ">
        @context.DOJ
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="Active" PropertyName="IsActive" SortKeySelector="item => item.IsActive">
        @context.IsActive
    </GridColumn>

</Grid>
```

```cs {} showLineNumbers
@code {
    private IEnumerable<Employee1> employees = default!;

    private async Task<GridDataProviderResult<Employee1>> EmployeesDataProvider(GridDataProviderRequest<Employee1> request)
    {
        if (employees is null) // pull employees only one time for client-side filtering, sorting, and paging
            employees = GetEmployees(); // call a service or an API to pull the employees

        return await Task.FromResult(request.ApplyTo(employees));
    }

    private IEnumerable<Employee1> GetEmployees()
    {
        return new List<Employee1>
        {
            new Employee1 { Id = 103, Name = "Bob", Designation = "Senior DevOps Engineer", DOJ = new DateOnly(1985, 1, 5), IsActive = true },
            new Employee1 { Id = 106, Name = "John", Designation = "Data Engineer", DOJ = new DateOnly(1995, 4, 17), IsActive = true },
            new Employee1 { Id = 104, Name = "Pop", Designation = "Associate Architect", DOJ = new DateOnly(1985, 6, 8), IsActive = false },
            new Employee1 { Id = 105, Name = "Ronald", Designation = "Senior Data Engineer", DOJ = new DateOnly(1991, 8, 23), IsActive = true },
            new Employee1 { Id = 102, Name = "Line", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 101, Name = "Daniel", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
        };
    }
}
```

[See demo here](https://demos.blazorbootstrap.com/grid#filters-row-css-class)

### Row click event

```cshtml {2,7} showLineNumbers
<Grid TItem="Employee1"
      AllowRowClick="true"
      AllowSorting="true"
      Class="table table-hover"
      DataProvider="EmployeesDataProvider"
      HeaderRowCssClass="bg-primary text-white border-bottom-0"
      OnRowClick="OnRowClick"
      Responsive="true">

    <GridColumn TItem="Employee1" HeaderText="Id" SortKeySelector="item => item.Id">
        @context.Id
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="Employee Name" SortKeySelector="item => item.Name">
        @context.Name
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="Designation" SortKeySelector="item => item.Designation">
        @context.Designation
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="DOJ" SortKeySelector="item => item.DOJ">
        @context.DOJ
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="Active" SortKeySelector="item => item.IsActive">
        @context.IsActive
    </GridColumn>

</Grid>
```

```cs {27-30} showLineNumbers
@code {
    [Inject] ModalService ModalService { get; set; } = default!;

    private IEnumerable<Employee1> employees = default!;

    private async Task<GridDataProviderResult<Employee1>> EmployeesDataProvider(GridDataProviderRequest<Employee1> request)
    {
        if (employees is null) // pull employees only one time for client-side filtering, sorting, and paging
            employees = GetEmployees(); // call a service or an API to pull the employees

        return await Task.FromResult(request.ApplyTo(employees));
    }

    private IEnumerable<Employee1> GetEmployees()
    {
        return new List<Employee1>
        {
            new Employee1 { Id = 103, Name = "Bob", Designation = "Senior DevOps Engineer", DOJ = new DateOnly(1985, 1, 5), IsActive = true },
            new Employee1 { Id = 106, Name = "John", Designation = "Data Engineer", DOJ = new DateOnly(1995, 4, 17), IsActive = true },
            new Employee1 { Id = 104, Name = "Pop", Designation = "Associate Architect", DOJ = new DateOnly(1985, 6, 8), IsActive = false },
            new Employee1 { Id = 105, Name = "Ronald", Designation = "Senior Data Engineer", DOJ = new DateOnly(1991, 8, 23), IsActive = true },
            new Employee1 { Id = 102, Name = "Line", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 101, Name = "Daniel", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
        };
    }

    private async Task OnRowClick(GridRowEventArgs<Employee1> args)
    {
        await ModalService.ShowAsync(new ModalOption { Type = ModalType.Primary, Title = "Event: Row Click", Message = $"Id: {args.Item.Id}, Name: {args.Item.Name}" });
    }
}
```

[See demo here](https://demos.blazorbootstrap.com/grid#row-click-event)

### Row double click event

```cshtml {2,7} showLineNumbers
<Grid TItem="Employee1"
      AllowRowClick="true"
      AllowSorting="true"
      Class="table table-hover"
      DataProvider="EmployeesDataProvider"
      HeaderRowCssClass="bg-danger text-white border-bottom-0"
      OnRowDoubleClick="OnRowDoubleClick"
      Responsive="true">

    <GridColumn TItem="Employee1" HeaderText="Id" SortKeySelector="item => item.Id">
        @context.Id
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="Employee Name" SortKeySelector="item => item.Name">
        @context.Name
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="Designation" SortKeySelector="item => item.Designation">
        @context.Designation
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="DOJ" SortKeySelector="item => item.DOJ">
        @context.DOJ
    </GridColumn>

    <GridColumn TItem="Employee1" HeaderText="Active" SortKeySelector="item => item.IsActive">
        @context.IsActive
    </GridColumn>

</Grid>
```

```cs {27-30} showLineNumbers
@code {
    [Inject] ModalService ModalService { get; set; } = default!;

    private IEnumerable<Employee1> employees = default!;

    private async Task<GridDataProviderResult<Employee1>> EmployeesDataProvider(GridDataProviderRequest<Employee1> request)
    {
        if (employees is null) // pull employees only one time for client-side filtering, sorting, and paging
            employees = GetEmployees(); // call a service or an API to pull the employees

        return await Task.FromResult(request.ApplyTo(employees));
    }

    private IEnumerable<Employee1> GetEmployees()
    {
        return new List<Employee1>
        {
            new Employee1 { Id = 103, Name = "Bob", Designation = "Senior DevOps Engineer", DOJ = new DateOnly(1985, 1, 5), IsActive = true },
            new Employee1 { Id = 106, Name = "John", Designation = "Data Engineer", DOJ = new DateOnly(1995, 4, 17), IsActive = true },
            new Employee1 { Id = 104, Name = "Pop", Designation = "Associate Architect", DOJ = new DateOnly(1985, 6, 8), IsActive = false },
            new Employee1 { Id = 105, Name = "Ronald", Designation = "Senior Data Engineer", DOJ = new DateOnly(1991, 8, 23), IsActive = true },
            new Employee1 { Id = 102, Name = "Line", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 101, Name = "Daniel", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
        };
    }

    private async Task OnRowDoubleClick(GridRowEventArgs<Employee1> args)
    {
        await ModalService.ShowAsync(new ModalOption { Type = ModalType.Primary, Title = "Event: Row Double Click", Message = $"Id: {args.Item.Id}, Name: {args.Item.Name}" });
    }
}
```

[See demo here](https://demos.blazorbootstrap.com/grid#row-double-click-event)

### Translations

In the example below, you will see translations related to pagination and filters in **Dutch**.

<img src="https://i.imgur.com/kKNgo2I.png" alt="Blazor Bootstrap: Grid Component - Translations" />

```cshtml {8,13-14} showLineNumbers
<Grid TItem="Employee1"
      AllowFiltering="true"
      AllowPaging="true"
      AllowSorting="true"
      Class="table table-hover"
      DataProvider="EmployeesDataProvider"
      FiltersRowCssClass="bg-dark text-white bg-opacity-25 border-bottom-0"
      FiltersTranslationProvider="GridFiltersTranslationProvider"
      HeaderRowCssClass="bg-dark text-white border-bottom-0"
      PageSize="10"
      PageSizeSelectorVisible="true"
      PageSizeSelectorItems="@(new int[] { 5,10,20 })"
      PaginationItemsTextFormat="{0} - {1} van {2} artikelen"
      ItemsPerPageText="Artikelen per pagina"
      Responsive="true">

    <GridColumn TItem="Employee1" HeaderText="Id" PropertyName="Id" SortKeySelector="item => item.Id">
        @context.Id
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Employee Name" PropertyName="Name" SortKeySelector="item => item.Name">
        @context.Name
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Designation" PropertyName="Designation" SortKeySelector="item => item.Designation">
        @context.Designation
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="DOJ" PropertyName="DOJ" SortKeySelector="item => item.DOJ">
        @context.DOJ
    </GridColumn>
    <GridColumn TItem="Employee1" HeaderText="Active" PropertyName="IsActive" SortKeySelector="item => item.IsActive">
        @context.IsActive
    </GridColumn>

</Grid>
```

```cs {4-25} showLineNumbers
@code {
    private IEnumerable<Employee1> employees = default!;

    private async Task<IEnumerable<FilterOperatorInfo>> GridFiltersTranslationProvider()
    {
        var filtersTranslation = new List<FilterOperatorInfo>();

        // number/date/boolean
        filtersTranslation.Add(new("=", "gelijk aan", FilterOperator.Equals));
        filtersTranslation.Add(new("!=", "Niet gelijk", FilterOperator.NotEquals));
        // number/date
        filtersTranslation.Add(new("<", "Minder dan", FilterOperator.LessThan));
        filtersTranslation.Add(new("<=", "Kleiner dan of gelijk aan", FilterOperator.LessThanOrEquals));
        filtersTranslation.Add(new(">", "Groter dan", FilterOperator.GreaterThan));
        filtersTranslation.Add(new(">=", "Groter dan of gelijk aan", FilterOperator.GreaterThanOrEquals));
        // string
        filtersTranslation.Add(new("*a*", "Bevat", FilterOperator.Contains));
        filtersTranslation.Add(new("a**", "Begint met", FilterOperator.StartsWith));
        filtersTranslation.Add(new("**a", "Eindigt met", FilterOperator.EndsWith));
        filtersTranslation.Add(new("=", "gelijk aan", FilterOperator.Equals));
        // common
        filtersTranslation.Add(new("x", "Duidelijk", FilterOperator.Clear));

        return await Task.FromResult(filtersTranslation);
    }

    private async Task<GridDataProviderResult<Employee1>> EmployeesDataProvider(GridDataProviderRequest<Employee1> request)
    {
        if (employees is null) // pull employees only one time for client-side filtering, sorting, and paging
            employees = GetEmployees(); // call a service or an API to pull the employees

        return await Task.FromResult(request.ApplyTo(employees));
    }

    private IEnumerable<Employee1> GetEmployees()
    {
        return new List<Employee1>
        {
            new Employee1 { Id = 107, Name = "Alice", Designation = "AI Engineer", DOJ = new DateOnly(1998, 11, 17), IsActive = true },
            new Employee1 { Id = 103, Name = "Bob", Designation = "Senior DevOps Engineer", DOJ = new DateOnly(1985, 1, 5), IsActive = true },
            new Employee1 { Id = 106, Name = "John", Designation = "Data Engineer", DOJ = new DateOnly(1995, 4, 17), IsActive = true },
            new Employee1 { Id = 104, Name = "Pop", Designation = "Associate Architect", DOJ = new DateOnly(1985, 6, 8), IsActive = false },
            new Employee1 { Id = 105, Name = "Ronald", Designation = "Senior Data Engineer", DOJ = new DateOnly(1991, 8, 23), IsActive = true },
            new Employee1 { Id = 102, Name = "Line", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 101, Name = "Daniel", Designation = "Architect", DOJ = new DateOnly(1977, 1, 12), IsActive = true },
            new Employee1 { Id = 113, Name = "Merlin", Designation = "Senior Consultant", DOJ = new DateOnly(1989, 10, 2), IsActive = true },
            new Employee1 { Id = 117, Name = "Sharna", Designation = "Data Analyst", DOJ = new DateOnly(1994, 5, 12), IsActive = true },
            new Employee1 { Id = 108, Name = "Zayne", Designation = "Data Analyst", DOJ = new DateOnly(1991, 1, 1), IsActive = true },
            new Employee1 { Id = 109, Name = "Isha", Designation = "App Maker", DOJ = new DateOnly(1996, 7, 1), IsActive = true },
            new Employee1 { Id = 111, Name = "Glenda", Designation = "Data Engineer", DOJ = new DateOnly(1994, 1, 12), IsActive = true },
        };
    }
}
```

[See demo here](https://demos.blazorbootstrap.com/grid#translations)
