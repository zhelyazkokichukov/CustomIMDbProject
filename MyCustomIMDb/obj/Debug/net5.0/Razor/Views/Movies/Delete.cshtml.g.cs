#pragma checksum "C:\Users\Zheko\source\repos\MyCustomIMDb\MyCustomIMDb\Views\Movies\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "109b631509e875c9b60c8ed34456ee6734963ef4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Delete), @"mvc.1.0.view", @"/Views/Movies/Delete.cshtml")]
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
#line 1 "C:\Users\Zheko\source\repos\MyCustomIMDb\MyCustomIMDb\Views\_ViewImports.cshtml"
using MyCustomIMDb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Zheko\source\repos\MyCustomIMDb\MyCustomIMDb\Views\_ViewImports.cshtml"
using MyCustomIMDb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Zheko\source\repos\MyCustomIMDb\MyCustomIMDb\Views\_ViewImports.cshtml"
using MyCustomIMDb.Models.Movie;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Zheko\source\repos\MyCustomIMDb\MyCustomIMDb\Views\_ViewImports.cshtml"
using MyCustomIMDb.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Zheko\source\repos\MyCustomIMDb\MyCustomIMDb\Views\_ViewImports.cshtml"
using MyCustomIMDb.Models.TVShow;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Zheko\source\repos\MyCustomIMDb\MyCustomIMDb\Views\_ViewImports.cshtml"
using MyCustomIMDb.Models.Episode;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"109b631509e875c9b60c8ed34456ee6734963ef4", @"/Views/Movies/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43ed89e6133b538ddd14315aa464d38a8faf80bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h3>");
#nullable restore
#line 3 "C:\Users\Zheko\source\repos\MyCustomIMDb\MyCustomIMDb\Views\Movies\Delete.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 3 "C:\Users\Zheko\source\repos\MyCustomIMDb\MyCustomIMDb\Views\Movies\Delete.cshtml"
             Write(Model.ReleaseDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(") has been removed successfully!</h3>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
