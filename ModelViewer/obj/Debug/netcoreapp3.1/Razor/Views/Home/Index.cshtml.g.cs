#pragma checksum "C:\Users\zbysl\source\repos\ModelViewer\ModelViewer\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7d86c49acd39f650daa0ebdbffa3f04647392c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\zbysl\source\repos\ModelViewer\ModelViewer\Views\_ViewImports.cshtml"
using ModelViewer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zbysl\source\repos\ModelViewer\ModelViewer\Views\_ViewImports.cshtml"
using ModelViewer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\zbysl\source\repos\ModelViewer\ModelViewer\Views\Home\Index.cshtml"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zbysl\source\repos\ModelViewer\ModelViewer\Views\Home\Index.cshtml"
using System.Web;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7d86c49acd39f650daa0ebdbffa3f04647392c8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9843c3a9f7dc892c1b49cb08e224960b59fa43c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("file-preview-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ModelPreview", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\zbysl\source\repos\ModelViewer\ModelViewer\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Model Viewer";
    string[] filesPath = Directory.GetFiles("wwwroot/assets/");

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"viewer\">\r\n");
#nullable restore
#line 8 "C:\Users\zbysl\source\repos\ModelViewer\ModelViewer\Views\Home\Index.cshtml"
      
        foreach (string file in filesPath)
        {
            string fileName = file.Replace("wwwroot/assets/", "");

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"file-icon\"");
            BeginWriteAttribute("onclick", " onclick=\"", 339, "\"", 374, 4);
            WriteAttributeValue("", 349, "renderIcon(this,", 349, 16, true);
            WriteAttributeValue(" ", 365, "\'", 366, 2, true);
#nullable restore
#line 12 "C:\Users\zbysl\source\repos\ModelViewer\ModelViewer\Views\Home\Index.cshtml"
WriteAttributeValue("", 367, file, 367, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 372, "\')", 372, 2, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 12 "C:\Users\zbysl\source\repos\ModelViewer\ModelViewer\Views\Home\Index.cshtml"
                                                                  Write(fileName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7d86c49acd39f650daa0ebdbffa3f04647392c85563", async() => {
                WriteLiteral("Zobacz");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-objectname", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "C:\Users\zbysl\source\repos\ModelViewer\ModelViewer\Views\Home\Index.cshtml"
                                                                                WriteLiteral(fileName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["objectname"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-objectname", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["objectname"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 15 "C:\Users\zbysl\source\repos\ModelViewer\ModelViewer\Views\Home\Index.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
<script>
    renderIcon = (target, filedir) => {
            if(document.querySelectorAll("".icon-canvas"").length > 0)
            {
                document.querySelectorAll("".icon-canvas"").forEach(el =>{
                    el.remove();
                })
            }
        filedir = filedir.replace(""wwwroot"", """");
        console.log(filedir);
        let canvas = document.createElement(""canvas"");
        canvas.className = ""icon-canvas"";
        canvas.setAttribute(""width"", ""100px"");
        canvas.setAttribute(""height"", ""100px"");
        target.appendChild(canvas);
        var scene = new THREE.Scene();
        var camera = new THREE.PerspectiveCamera(90, 1, 1, 100);
        camera.updateProjectionMatrix();
        var Loader = new THREE.OBJLoader();
        var light = new THREE.AmbientLight(0x404040);
        scene.add(light);
        scene.background = new THREE.Color('black');
        var render = new THREE.WebGLRenderer({canvas: canvas});
        render.setSize(canva");
            WriteLiteral(@"s.width, canvas.height);
        Loader.load(filedir, (object)=>{
            scene.add(object);
            object.position.set(0,0,0);
            object.rotation.set(15,10,0);
            camera.position.z = 4;
            render.render(scene, camera);
        })
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
