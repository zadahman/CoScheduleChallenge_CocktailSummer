#pragma checksum "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b98250a23307cd3d13bfa1331d4c3c245429d3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Favorites), @"mvc.1.0.view", @"/Views/Home/Favorites.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\_ViewImports.cshtml"
using CoScheduleChallenge;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\_ViewImports.cshtml"
using CoScheduleChallenge.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b98250a23307cd3d13bfa1331d4c3c245429d3d", @"/Views/Home/Favorites.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a59216e56272abedfd2e3219220d1921dae07e45", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Favorites : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoScheduleChallenge.Models.Cocktail>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
  
    ViewData["Title"] = "Your Favorite Cocktails";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card mt-3 pt-2\">\r\n    <div class=\"card-header\">\r\n        <h3>");
#nullable restore
#line 11 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n    <div class=\"card-body\">\r\n        <table class=\"table table-striped\">\r\n            <thead>\r\n                <tr class=\"table-info\">\r\n                    <th>\r\n                        ");
#nullable restore
#line 18 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 21 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                   Write(Html.DisplayName("Drink Type"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 24 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                   Write(Html.DisplayName("Glass Type"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 27 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                   Write(Html.DisplayName("Drink Category"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 30 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                   Write(Html.DisplayNameFor(model => model.Instructions));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 33 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                   Write(Html.DisplayName("Ingredients"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 40 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                 foreach (var item in Model)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                     using (Html.BeginForm())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr");
            BeginWriteAttribute("id", " id=\"", 1378, "\"", 1391, 1);
#nullable restore
#line 44 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
WriteAttributeValue("", 1383, item.Id, 1383, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <td>\r\n                                ");
#nullable restore
#line 46 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 49 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                           Write(Html.DisplayFor(modelItem => item.DrinkType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 52 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                           Write(Html.DisplayFor(modelItem => item.GlassType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 55 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                           Write(Html.DisplayFor(modelItem => item.DrinkCategory));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 58 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Instructions));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
#nullable restore
#line 61 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                 if (!String.IsNullOrEmpty(item.Ingredient1))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MeasureForIngredient1));

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                                                                         Write(Html.DisplayFor(modelItem => item.Ingredient1));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n");
#nullable restore
#line 64 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                 if (!String.IsNullOrEmpty(item.Ingredient2))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MeasureForIngredient2));

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                                                                         Write(Html.DisplayFor(modelItem => item.Ingredient2));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n");
#nullable restore
#line 68 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                 if (!String.IsNullOrEmpty(item.Ingredient3))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MeasureForIngredient3));

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                                                                         Write(Html.DisplayFor(modelItem => item.Ingredient3));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n");
#nullable restore
#line 72 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                 if (!String.IsNullOrEmpty(item.Ingredient4))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MeasureForIngredient4));

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                                                                         Write(Html.DisplayFor(modelItem => item.Ingredient4));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n");
#nullable restore
#line 76 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                 if (!String.IsNullOrEmpty(item.Ingredient5))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MeasureForIngredient5));

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                                                                         Write(Html.DisplayFor(modelItem => item.Ingredient5));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n");
#nullable restore
#line 80 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                 if (!String.IsNullOrEmpty(item.Ingredient6))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MeasureForIngredient6));

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                                                                         Write(Html.DisplayFor(modelItem => item.Ingredient6));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n");
#nullable restore
#line 84 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                 if (!String.IsNullOrEmpty(item.Ingredient7))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MeasureForIngredient7));

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                                                                         Write(Html.DisplayFor(modelItem => item.Ingredient7));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n");
#nullable restore
#line 88 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                 if (!String.IsNullOrEmpty(item.Ingredient8))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MeasureForIngredient8));

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                                                                         Write(Html.DisplayFor(modelItem => item.Ingredient8));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n");
#nullable restore
#line 92 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                 if (!String.IsNullOrEmpty(item.Ingredient9))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MeasureForIngredient9));

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                                                                         Write(Html.DisplayFor(modelItem => item.Ingredient9));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n");
#nullable restore
#line 96 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                 if (!String.IsNullOrEmpty(item.Ingredient10))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MeasureForIngredient10));

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                                                                          Write(Html.DisplayFor(modelItem => item.Ingredient10));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n");
#nullable restore
#line 100 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                 if (!String.IsNullOrEmpty(item.Ingredient11))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MeasureForIngredient11));

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                                                                          Write(Html.DisplayFor(modelItem => item.Ingredient11));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n");
#nullable restore
#line 104 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                 if (!String.IsNullOrEmpty(item.Ingredient12))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MeasureForIngredient12));

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                                                                          Write(Html.DisplayFor(modelItem => item.Ingredient12));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n");
#nullable restore
#line 108 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                 if (!String.IsNullOrEmpty(item.Ingredient13))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MeasureForIngredient13));

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                                                                          Write(Html.DisplayFor(modelItem => item.Ingredient13));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n");
#nullable restore
#line 112 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 113 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                 if (!String.IsNullOrEmpty(item.Ingredient14))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MeasureForIngredient14));

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                                                                          Write(Html.DisplayFor(modelItem => item.Ingredient14));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n");
#nullable restore
#line 116 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 117 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                 if (!String.IsNullOrEmpty(item.Ingredient15))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 119 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MeasureForIngredient15));

#line default
#line hidden
#nullable disable
#nullable restore
#line 119 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                                                                          Write(Html.DisplayFor(modelItem => item.Ingredient15));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n");
#nullable restore
#line 120 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                            <td>\r\n                                <p>\r\n                                    <img title=\"Click to View\"");
            BeginWriteAttribute("src", " src=\"", 6842, "\"", 6863, 1);
#nullable restore
#line 124 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
WriteAttributeValue("", 6848, item.ImageLink, 6848, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"30\" height=\"30\" type=\"button\" class=\"btn btn-sm bs-tooltip-bottom\" data-toggle=\"modal\" data-target=\"#pop-");
#nullable restore
#line 124 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                                                                                                                                                                                Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" />\r\n                                </p>\r\n\r\n                                <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 7086, "\"", 7103, 2);
            WriteAttributeValue("", 7091, "pop-", 7091, 4, true);
#nullable restore
#line 127 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
WriteAttributeValue("", 7095, item.Id, 7095, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"cocktailImageLabel\" aria-hidden=\"true\">\r\n                                    <div class=\"modal-dialog modal-dialog-centered\" role=\"document\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 7337, "\"", 7358, 1);
#nullable restore
#line 129 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
WriteAttributeValue("", 7343, item.ImageLink, 7343, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                    </div>
                                </div>
                            </td>
                            <td>
                                <input type=""button"" title=""Edit"" class=""btn btn btn-outline-info btn-sm mr-2"" value=""Edit""");
            BeginWriteAttribute("onclick", " onclick=\"", 7640, "\"", 7723, 3);
            WriteAttributeValue("", 7650, "location.href=\'", 7650, 15, true);
#nullable restore
#line 134 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
WriteAttributeValue("", 7665, Url.Action("EditCocktail", "Home", new { id = item.Id }), 7665, 57, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7722, "\'", 7722, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                <button class=\"btn btn btn-outline-info btn-sm mt-2\"");
            BeginWriteAttribute("onclick", " onclick=\"", 7813, "\"", 7847, 3);
            WriteAttributeValue("", 7823, "deleteCocktail(", 7823, 15, true);
#nullable restore
#line 135 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
WriteAttributeValue("", 7838, item.Id, 7838, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7846, ")", 7846, 1, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"button\">Delete</button>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 138 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 138 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                     


                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        function editing(ctId) {\r\n             $.ajax({\r\n                type: \'GET\',\r\n                url: \'");
#nullable restore
#line 152 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                 Write(Url.Action("EditCocktail", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"?id=' + ctId,
                dataType: 'json',
                contentType: ""application/json; charset=utf-8"",
                success: function (response) {
                    alert(response);
                },
                error: function (err) {
                    alert(err.responseText);
                }
            });
        };

        function deleteCocktail(id) {
        $.ajax({
            type: 'DELETE',
            url: '");
#nullable restore
#line 167 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
             Write(Url.Action("DeleteCocktail", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"?id=' + id,
            dataType: 'json',
            contentType: ""application/json; charset=utf-8"",
            success: function (response) {
                alert(response);
                window.location.reload();
            },
            error: function (err) {
                alert(err.responseText);
            }
        });
        }

        $(document).ready(function () {
            $("".active"").removeClass(""active"");
            $(""#link-favorite"").addClass(""active"");
        });
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CoScheduleChallenge.Models.Cocktail>> Html { get; private set; }
    }
}
#pragma warning restore 1591