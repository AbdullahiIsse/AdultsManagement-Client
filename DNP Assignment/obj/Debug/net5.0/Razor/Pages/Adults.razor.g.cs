#pragma checksum "C:\Users\abdul\RiderProjects\DNP Assignment\DNP Assignment\Pages\Adults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d8bf9f617b2b1e5e2b57a8e6fb3b08e45a54a9e"
// <auto-generated/>
#pragma warning disable 1591
namespace DNP_Assignment.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\abdul\RiderProjects\DNP Assignment\DNP Assignment\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abdul\RiderProjects\DNP Assignment\DNP Assignment\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\abdul\RiderProjects\DNP Assignment\DNP Assignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\abdul\RiderProjects\DNP Assignment\DNP Assignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\abdul\RiderProjects\DNP Assignment\DNP Assignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\abdul\RiderProjects\DNP Assignment\DNP Assignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\abdul\RiderProjects\DNP Assignment\DNP Assignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\abdul\RiderProjects\DNP Assignment\DNP Assignment\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\abdul\RiderProjects\DNP Assignment\DNP Assignment\_Imports.razor"
using DNP_Assignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\abdul\RiderProjects\DNP Assignment\DNP Assignment\_Imports.razor"
using DNP_Assignment.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abdul\RiderProjects\DNP Assignment\DNP Assignment\Pages\Adults.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\abdul\RiderProjects\DNP Assignment\DNP Assignment\Pages\Adults.razor"
using DNP_Assignment.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Adults")]
    public partial class Adults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Adults</h3>\r\n\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, " Search ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "Text");
            __builder.AddAttribute(5, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\abdul\RiderProjects\DNP Assignment\DNP Assignment\Pages\Adults.razor"
                                          (arg) => FilterByFirstname(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 11 "C:\Users\abdul\RiderProjects\DNP Assignment\DNP Assignment\Pages\Adults.razor"
 if (AdultsToShow == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<p><em>Loading...</em></p>");
#nullable restore
#line 16 "C:\Users\abdul\RiderProjects\DNP Assignment\DNP Assignment\Pages\Adults.razor"
}
else if (!AdultsToShow.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<p><em>No ToDo items exist. Please add some.</em></p>");
#nullable restore
#line 22 "C:\Users\abdul\RiderProjects\DNP Assignment\DNP Assignment\Pages\Adults.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "table");
            __builder.AddMarkupContent(10, @"<thead><tr><th>ID</th>
            <th>FirstName</th>
            <th>LastName</th>
            <th>HairColor</th>
            <th>EyeColor</th>
            <th>Age</th>
            <th>Weight</th>
            <th>Height</th>
            <th>Sex</th>
            <th>JobTitle</th>
            <th>Salary</th></tr></thead>
        ");
            __builder.OpenElement(11, "tbody");
#nullable restore
#line 42 "C:\Users\abdul\RiderProjects\DNP Assignment\DNP Assignment\Pages\Adults.razor"
         foreach (var item in AdultsToShow)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "tr");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 45 "C:\Users\abdul\RiderProjects\DNP Assignment\DNP Assignment\Pages\Adults.razor"
                     item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 46 "C:\Users\abdul\RiderProjects\DNP Assignment\DNP Assignment\Pages\Adults.razor"
                     item.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 47 "C:\Users\abdul\RiderProjects\DNP Assignment\DNP Assignment\Pages\Adults.razor"
                     item.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 48 "C:\Users\abdul\RiderProjects\DNP Assignment\DNP Assignment\Pages\Adults.razor"
                     item.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 49 "C:\Users\abdul\RiderProjects\DNP Assignment\DNP Assignment\Pages\Adults.razor"
                     item.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 50 "C:\Users\abdul\RiderProjects\DNP Assignment\DNP Assignment\Pages\Adults.razor"
                     item.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 51 "C:\Users\abdul\RiderProjects\DNP Assignment\DNP Assignment\Pages\Adults.razor"
                     item.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 52 "C:\Users\abdul\RiderProjects\DNP Assignment\DNP Assignment\Pages\Adults.razor"
                     item.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 53 "C:\Users\abdul\RiderProjects\DNP Assignment\DNP Assignment\Pages\Adults.razor"
                     item.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.OpenElement(40, "td");
            __builder.AddContent(41, 
#nullable restore
#line 54 "C:\Users\abdul\RiderProjects\DNP Assignment\DNP Assignment\Pages\Adults.razor"
                     item.JobTitle.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.OpenElement(43, "td");
            __builder.AddContent(44, 
#nullable restore
#line 55 "C:\Users\abdul\RiderProjects\DNP Assignment\DNP Assignment\Pages\Adults.razor"
                     item.JobTitle.Salary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n\r\n\r\n                ");
            __builder.OpenElement(46, "td");
            __builder.OpenElement(47, "button");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\abdul\RiderProjects\DNP Assignment\DNP Assignment\Pages\Adults.razor"
                                        () => RemoveTodo(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(49, "<i class=\"oi oi-trash\" style=\"color:red\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 66 "C:\Users\abdul\RiderProjects\DNP Assignment\DNP Assignment\Pages\Adults.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 69 "C:\Users\abdul\RiderProjects\DNP Assignment\DNP Assignment\Pages\Adults.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "C:\Users\abdul\RiderProjects\DNP Assignment\DNP Assignment\Pages\Adults.razor"
       

    private IList<Adult> filterAdultList;
    private IList<Adult> AdultsToShow;
    private string? filterByFirstName;
    


    protected override async Task OnInitializedAsync()
    {
        filterAdultList = _adultData.GetAdults();
        AdultsToShow = filterAdultList;


    }
   
    
    
    private void RemoveTodo(int adultId)
    {
        Adult adultToRemove = AdultsToShow.First(a => a.Id == adultId);
        _adultData.RemoveAdults(adultId);
        
    }

    private void FilterByFirstname(ChangeEventArgs changeEventArgs)
    {
        filterByFirstName = changeEventArgs.Value.ToString();

        if (filterByFirstName.Length <= 0)
        {
            AdultsToShow = filterAdultList;
        }
        else
        {
             AdultsToShow= AdultsToShow.Where(
                                    a => a.FirstName.ToLower().Contains(filterByFirstName.ToLower()) || a.FirstName.ToUpper().Contains(filterByFirstName.ToUpper())||
                                         a.LastName.ToLower().Contains(filterByFirstName.ToLower()) || a.LastName.ToUpper().Contains(filterByFirstName.ToUpper()) ||
                                         a.HairColor.ToLower().Contains(filterByFirstName.ToLower()) || a.HairColor.ToUpper().Contains(filterByFirstName.ToUpper()) ||
                                         a.EyeColor.ToLower().Contains(filterByFirstName.ToLower()) || a.EyeColor.ToUpper().Contains(filterByFirstName.ToUpper()) ||
                                         a.Age.ToString().ToLower().Contains(filterByFirstName.ToLower()) || a.Weight.ToString().ToLower().Contains(filterByFirstName.ToLower()) ||
                                         a.Height.ToString().ToLower().Contains(filterByFirstName.ToLower()) || 
                                         a.Sex.ToLower().Contains(filterByFirstName.ToLower()) || a.Sex.ToUpper().Contains(filterByFirstName.ToUpper()) ||
                                         a.JobTitle.JobTitle.ToLower().Contains(filterByFirstName.ToLower()) || a.JobTitle.JobTitle.ToUpper().Contains(filterByFirstName.ToUpper()) ||
                                         a.JobTitle.Salary.ToString().ToLower().Contains(filterByFirstName.ToLower())).ToList();
        }

         
      
        
        
      
    }
    
    
    
    


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultData _adultData { get; set; }
    }
}
#pragma warning restore 1591
