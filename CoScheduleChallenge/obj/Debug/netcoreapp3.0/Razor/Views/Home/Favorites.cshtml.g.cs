#pragma checksum "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4063e471e84b13db01e858fbb0a0227630651c08"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4063e471e84b13db01e858fbb0a0227630651c08", @"/Views/Home/Favorites.cshtml")]
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
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 61 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                           Write(Html.DisplayFor(modelItem => item.MeasureForIngredient1));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 61 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                                                                     Write(Html.DisplayFor(modelItem => item.Ingredient1));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                                ");
#nullable restore
#line 62 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                           Write(Html.DisplayFor(modelItem => item.MeasureForIngredient2));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 62 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                                                                     Write(Html.DisplayFor(modelItem => item.Ingredient2));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                                ");
#nullable restore
#line 63 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                           Write(Html.DisplayFor(modelItem => item.MeasureForIngredient3));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 63 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                                                                     Write(Html.DisplayFor(modelItem => item.Ingredient3));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                                ");
#nullable restore
#line 64 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                           Write(Html.DisplayFor(modelItem => item.MeasureForIngredient4));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 64 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                                                                     Write(Html.DisplayFor(modelItem => item.Ingredient4));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                                ");
#nullable restore
#line 65 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                           Write(Html.DisplayFor(modelItem => item.MeasureForIngredient5));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 65 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                                                                     Write(Html.DisplayFor(modelItem => item.Ingredient5));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                                ");
#nullable restore
#line 66 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                           Write(Html.DisplayFor(modelItem => item.MeasureForIngredient6));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 66 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                                                                     Write(Html.DisplayFor(modelItem => item.Ingredient6));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                                ");
#nullable restore
#line 67 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                           Write(Html.DisplayFor(modelItem => item.MeasureForIngredient7));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 67 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                                                                     Write(Html.DisplayFor(modelItem => item.Ingredient7));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                                ");
#nullable restore
#line 68 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                           Write(Html.DisplayFor(modelItem => item.MeasureForIngredient8));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 68 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                                                                     Write(Html.DisplayFor(modelItem => item.Ingredient8));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                                ");
#nullable restore
#line 69 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                           Write(Html.DisplayFor(modelItem => item.MeasureForIngredient9));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 69 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                                                                     Write(Html.DisplayFor(modelItem => item.Ingredient9));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                                ");
#nullable restore
#line 70 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                           Write(Html.DisplayFor(modelItem => item.MeasureForIngredient10));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 70 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                                                                      Write(Html.DisplayFor(modelItem => item.Ingredient10));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                                ");
#nullable restore
#line 71 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                           Write(Html.DisplayFor(modelItem => item.MeasureForIngredient11));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 71 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                                                                      Write(Html.DisplayFor(modelItem => item.Ingredient11));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                                ");
#nullable restore
#line 72 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                           Write(Html.DisplayFor(modelItem => item.MeasureForIngredient12));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 72 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                                                                      Write(Html.DisplayFor(modelItem => item.Ingredient12));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                                ");
#nullable restore
#line 73 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                           Write(Html.DisplayFor(modelItem => item.MeasureForIngredient13));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 73 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                                                                      Write(Html.DisplayFor(modelItem => item.Ingredient13));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                                ");
#nullable restore
#line 74 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                           Write(Html.DisplayFor(modelItem => item.MeasureForIngredient14));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 74 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                                                                      Write(Html.DisplayFor(modelItem => item.Ingredient14));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                                ");
#nullable restore
#line 75 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                           Write(Html.DisplayFor(modelItem => item.MeasureForIngredient15));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 75 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                                                                      Write(Html.DisplayFor(modelItem => item.Ingredient15));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                            </td>\r\n                            <td>\r\n                                <p>\r\n                                    <img title=\"Click to View\"");
            BeginWriteAttribute("src", " src=\"", 4541, "\"", 4562, 1);
#nullable restore
#line 79 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
WriteAttributeValue("", 4547, item.ImageLink, 4547, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"30\" height=\"30\" type=\"button\" class=\"btn btn-sm bs-tooltip-bottom\" data-toggle=\"modal\" data-target=\"#pop-");
#nullable restore
#line 79 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                                                                                                                                                                                                Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" />\r\n                                </p>\r\n\r\n                                <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 4785, "\"", 4802, 2);
            WriteAttributeValue("", 4790, "pop-", 4790, 4, true);
#nullable restore
#line 82 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
WriteAttributeValue("", 4794, item.Id, 4794, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"cocktailImageLabel\" aria-hidden=\"true\">\r\n                                    <div class=\"modal-dialog modal-dialog-centered\" role=\"document\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 5036, "\"", 5057, 1);
#nullable restore
#line 84 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
WriteAttributeValue("", 5042, item.ImageLink, 5042, 15, false);

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
            BeginWriteAttribute("onclick", " onclick=\"", 5339, "\"", 5422, 3);
            WriteAttributeValue("", 5349, "location.href=\'", 5349, 15, true);
#nullable restore
#line 89 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
WriteAttributeValue("", 5364, Url.Action("EditCocktail", "Home", new { id = item.Id }), 5364, 57, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5421, "\'", 5421, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                <button class=\"btn btn btn-outline-info btn-sm mt-2\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5512, "\"", 5546, 3);
            WriteAttributeValue("", 5522, "deleteCocktail(", 5522, 15, true);
#nullable restore
#line 90 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
WriteAttributeValue("", 5537, item.Id, 5537, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5545, ")", 5545, 1, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"button\">Delete</button>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 93 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
                     


                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        function editing(ctId) {\r\n             $.ajax({\r\n                type: \'GET\',\r\n                url: \'");
#nullable restore
#line 107 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
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
#line 122 "C:\Users\Visitor\Downloads\CocktailSummer\CoScheduleChallenge\Views\Home\Favorites.cshtml"
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