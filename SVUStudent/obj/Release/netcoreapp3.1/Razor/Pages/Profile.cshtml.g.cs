#pragma checksum "E:\Projects\NetCore\KSP\SVUStudent\SVUStudent\Pages\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92641ca8b1236ecee5150c044011bd2971a77d24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SVUStudent.Pages.Pages_Profile), @"mvc.1.0.razor-page", @"/Pages/Profile.cshtml")]
namespace SVUStudent.Pages
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
#line 1 "E:\Projects\NetCore\KSP\SVUStudent\SVUStudent\Pages\_ViewImports.cshtml"
using SVUStudent;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92641ca8b1236ecee5150c044011bd2971a77d24", @"/Pages/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"892fe96ed1254782af74736dc5b6db601a0f28a4", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Profile : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\Projects\NetCore\KSP\SVUStudent\SVUStudent\Pages\Profile.cshtml"
  
    ViewData["Title"] = "Profile";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""main-content"">
        <section class=""section"">
          <div class=""section-body"">
            <div class=""section-title""> STUDENT PROFILE </div>
            <div class=""row"">
              <div class=""col-12 col-sm-12 col-lg-12"">
                <div class=""card"">
                  <div class=""card-body"">
                    <div class=""row"">
                      <div class=""col-12 col-sm-12 col-md-4"">
                        <ul class=""nav nav-pills flex-column"" id=""myTab4"" role=""tablist"">
                          <li class=""nav-item"">
                            <a class=""nav-link active mt-2 mb-2"" id=""hallticket-tab4"" data-toggle=""tab"" href=""#number4"" role=""tab""
                              aria-controls=""number"" aria-selected=""true""> <i class=""fa-solid fa-book mr-2""></i> Hallticket Number</a>
                          </li>
                          <li class=""nav-item"">
                            <a class=""nav-link mt-2 mb-2"" id=""photo-tab4"" data-toggle=""tab"" hre");
            WriteLiteral(@"f=""#photo4"" role=""tab""
                              aria-controls=""photo"" aria-selected=""false""> <i class=""fa-solid fa-user mr-2""></i> Change Photo </a>
                          </li>
                          <li class=""nav-item"">
                            <a class=""nav-link mt-2 mb-2"" id=""home-tab4"" data-toggle=""tab"" href=""#home4"" role=""tab""
                              aria-controls=""home"" aria-selected=""false""> <i class=""fa-solid fa-lock mr-2""></i> Change Password</a>
                          </li>
                          <li class=""nav-item"">
                            <a class=""nav-link mt-2 mb-2"" id=""profile-tab4"" data-toggle=""tab"" href=""#profile4"" role=""tab""
                              aria-controls=""profile"" aria-selected=""false""> <i class=""fa-solid fa-envelope-open-text mr-2""></i> Change Email ID</a>
                          </li>
                          <li class=""nav-item"">
                            <a class=""nav-link mt-2 mb-2"" id=""contact-tab4"" data-toggle=""tab"" href=");
            WriteLiteral(@"""#contact4"" role=""tab""
                              aria-controls=""contact"" aria-selected=""false""> <i class=""fa-solid fa-mobile-screen-button mr-2""></i> Change Mobile Number </a>
                          </li>
                        </ul>
                      </div>
                      <div class=""col-12 col-sm-12 col-md-8"">
                        <div class=""tab-content no-padding"" id=""myTab2Content"">
                          <div class=""tab-pane fade show active"" id=""number4"" role=""tabpanel"" aria-labelledby=""number-tab4"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92641ca8b1236ecee5150c044011bd2971a77d246049", async() => {
                WriteLiteral("\r\n                              <div class=\"form-group\">\r\n                                <label>Enter Student Name</label>\r\n                                <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("required", " required=\"", 2912, "\"", 2923, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                              </div>\r\n                              <div class=\"form-group\">\r\n                                <label>Enter Your Date of Birth </label>\r\n                                <input type=\"date\" class=\"form-control\"");
                BeginWriteAttribute("required", " required=\"", 3166, "\"", 3177, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                              </div>
                              <div class=""form-group"">
                                <label>Enter Your Hallticket Number</label>
                                <input type=""text"" class=""form-control"">
                              </div>
                              <button class=""btn btn-primary mt-2"">Update Hallticket Number</button>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                          </div>
                          <div class=""tab-pane fade "" id=""photo4"" role=""tabpanel"" aria-labelledby=""photo-tab4"">
                           <div class=""col-md-12 d-flex""> 
                             <div class=""col-md-6""> 
                                <div class=""card-body photo-file"">
                                    <div class=""empty-state p-0 "">
                                      <div class=""guideline  photo""> <img
                                          class=""img-thumbnail img-responsive center-block d-block mx-auto""
                                          src=""../img/news/Photo.jpg"" id=""photo""");
            BeginWriteAttribute("alt", " alt=\"", 4264, "\"", 4270, 0);
            EndWriteAttribute();
            WriteLiteral(@"> </div>
                                      <div class=""js box image-upload"">
                                        <input type=""file"" name=""file-1[]"" id=""file-1"" onchange=""readURL(this);""
                                          class=""inputfile inputfile-1"" data-multiple-caption=""{count} files selected""
                                          multiple />
                                        <label for=""file-1""><i class=""fas fa-upload mr-2""></i><span>Choose a
                                            Photo</span></label>
                                      </div>
                                      
                                      <!--<a href=""#"" class=""mt-4 bb"">Remove Photo</a>-->
                                      <div class=""guideline"">
                                        <h6>This page contains some guideline for photo uploadings.</h6>
                                        <ul class=""list-group list-group-flush"">
                                          <li cl");
            WriteLiteral(@"ass=""list-group-item"" s>The paper should then be scanned to obtain a
                                            resolution of 200 DPI.</li>
                                          <li class=""list-group-item"">Image Format – JPG JPEG PNG </li>
                                          <li class=""list-group-item"">Photo File Dimensions: 252px X 324px(35 mm x 45 mm)(3.5 cm x 4.5 cm)</li>
                                          <li class=""list-group-item"">Photo File Size of Image – Minimum 50 KB – Maximum 100
                                            KB</li>
                                        </ul>
                                      </div>
                                    </div>
                                 </div>
                              </div> 
                              <div class=""col-md-6""> 
                                <div class=""card-body photo-file"">
                                    <div class=""empty-state p-0"">
                                      <div cl");
            WriteLiteral(@"ass=""signature-mt""></div>
                                      <div class=""signature""> <img
                                          class=""img-thumbnail img-responsive center-block d-block mx-auto""
                                          src=""../img/news/signature.jpg"" id=""signature""");
            BeginWriteAttribute("alt", " alt=\"", 6611, "\"", 6617, 0);
            EndWriteAttribute();
            WriteLiteral(@"> </div>
                                      <div class="" js box image-upload "">
                                        <input type=""file"" name=""file-1[]"" id=""file-1"" class=""inputfile inputfile-1""
                                          data-multiple-caption=""{count} files selected"" multiple />
                                        <label for=""file-1""><i class=""fas fa-upload mr-2""></i><span>Choose a
                                            signature</span></label>
                                      </div>
                                      
                                      <!--<a href=""#"" class=""mt-4 bb"">Remove Signature</a>-->

                                      <div class=""guideline"">
                                        <h6>This page contains some guideline for photo uploadings.</h6>
                                        <ul class=""list-group list-group-flush"">
                                          <li class=""list-group-item"" s>The paper should then be scanned ");
            WriteLiteral(@"to obtain a
                                            resolution of 200 DPI.</li>
                                          <li class=""list-group-item"">Image Format – JPG JPEG PNG </li>
                                          <li class=""list-group-item"">Photo File Dimensions: 432px X 144px(60 mm x 20 mm)(6.0 cm x 2.0 cm)</li>
                                          <li class=""list-group-item"">Photo File Size of Image – Minimum 10 KB – Maximum 20
                                            KB</li>
                                        </ul>
                                      </div>
                                    </div>
                                </div>
                              </div>
                           </div> 
                           <div class=""col-md-12 text-center"">
                                <a href=""#"" class=""btn btn-primary w-50 mt-1 mb-3"">Save</a>
                           </div>
                          </div> 
                          <div c");
            WriteLiteral("lass=\"tab-pane fade\" id=\"home4\" role=\"tabpanel\" aria-labelledby=\"home-tab4\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92641ca8b1236ecee5150c044011bd2971a77d2414166", async() => {
                WriteLiteral("\r\n                              <div class=\"form-group\">\r\n                                <label>Old Password</label>\r\n                                <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("required", " required=\"", 8968, "\"", 8979, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                              </div>\r\n                              <div class=\"form-group\">\r\n                                <label>New Password</label>\r\n                                <input type=\"email\" class=\"form-control\"");
                BeginWriteAttribute("required", " required=\"", 9210, "\"", 9221, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                              </div>
                              <div class=""form-group"">
                                <label>Confirm New Password</label>
                                <input type=""email"" class=""form-control"">
                              </div>
                              <button class=""btn btn-primary mt-2"">Update Password</button>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                          </div>\r\n                          <div class=\"tab-pane fade\" id=\"profile4\" role=\"tabpanel\" aria-labelledby=\"profile-tab4\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92641ca8b1236ecee5150c044011bd2971a77d2416759", async() => {
                WriteLiteral("\r\n                              <div class=\"form-group\">\r\n                                <label>Old Email Id</label>\r\n                                <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("required", " required=\"", 10005, "\"", 10016, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                              </div>\r\n                              <div class=\"form-group\">\r\n                                <label>New Email Id</label>\r\n                                <input type=\"email\" class=\"form-control\"");
                BeginWriteAttribute("required", " required=\"", 10247, "\"", 10258, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                              </div>\r\n                              <button class=\"btn btn-primary mt-2\">Update Email Id</button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                          </div>\r\n                          <div class=\"tab-pane fade\" id=\"contact4\" role=\"tabpanel\" aria-labelledby=\"contact-tab4\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92641ca8b1236ecee5150c044011bd2971a77d2419117", async() => {
                WriteLiteral("\r\n                              <div class=\"form-group\">\r\n                                <label>Old Mobile Number</label>\r\n                                <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("required", " required=\"", 10809, "\"", 10820, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                              </div>\r\n                              <div class=\"form-group\">\r\n                                <label>New Mobile Number</label>\r\n                                <input type=\"email\" class=\"form-control\"");
                BeginWriteAttribute("required", " required=\"", 11056, "\"", 11067, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                              </div>\r\n                              <button class=\"btn btn-primary mt-2\">Update Mobile Number</button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                          </div>
                        </div>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </section>
       
      </div>
    ");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SVUStudent.Pages.ProfileModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SVUStudent.Pages.ProfileModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SVUStudent.Pages.ProfileModel>)PageContext?.ViewData;
        public SVUStudent.Pages.ProfileModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
