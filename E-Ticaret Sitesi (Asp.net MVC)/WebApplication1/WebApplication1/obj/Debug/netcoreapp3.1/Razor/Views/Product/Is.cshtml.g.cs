#pragma checksum "C:\Users\onur_\OneDrive\Masaüstü\Dersler\Projeler\E-Ticaret Sitesi (Asp.net MVC)\WebApplication1\WebApplication1\Views\Product\Is.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad5f5cd6a53ac6f4c3dc0c1108c9cb5e8ea73d9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Is), @"mvc.1.0.view", @"/Views/Product/Is.cshtml")]
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
#line 1 "C:\Users\onur_\OneDrive\Masaüstü\Dersler\Projeler\E-Ticaret Sitesi (Asp.net MVC)\WebApplication1\WebApplication1\Views\Product\Is.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad5f5cd6a53ac6f4c3dc0c1108c9cb5e8ea73d9a", @"/Views/Product/Is.cshtml")]
    public class Views_Product_Is : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Products>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\onur_\OneDrive\Masaüstü\Dersler\Projeler\E-Ticaret Sitesi (Asp.net MVC)\WebApplication1\WebApplication1\Views\Product\Is.cshtml"
  
    ViewData["Title"] = "Is";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""stylesheet"" href=""/css/style.css"">
<link rel=""stylesheet"" href=""/css/styleis.css"">
<link rel=""stylesheet"" href=""/css/bootstrap.css"">

<div class=""a"">
    <div class=""container"" id=""orta1"">
        <div class=""row"">
            <div class=""col-sm-12 col-md-2"" id=""menu2"">
                <p id=""baslik""><a href=""/Product/Urunler/"">Avukatlık-Hukuk</a></p>
            </div>

            <div class=""col-sm-12 col-md-2"" id=""menu2"">
                <p id=""baslik""><a href=""/Product/Cicek/"">Çiçek-Peyzaj</a></p>
            </div>

            <div class=""col-sm-12 col-md-2"" id=""menu2"">
                <p id=""baslik""><a href=""/Product/Otomotiv/"">Otomotiv</a></p>
            </div>

            <div class=""col-sm-12 col-md-2"" id=""menu2"">
                <p id=""baslik""><a href=""/Product/Temizlik/"">Temizlik</a></p>
            </div>

            <div class=""col-sm-12 col-md-2"" id=""menu2"">
                <p id=""baslik""><a href=""/Product/Insaat/"">İnşaat-Mimarlık</a></p>
            </");
            WriteLiteral(@"div>

            <div class=""col-sm-12 col-md-2"" id=""menu2"">
                <p id=""baslik""><a href=""/Product/Gida/"">Gıda-Restaurant</a></p>
            </div>

            <div class=""col-sm-12 col-md-2"" id=""menu2"">
                <p id=""baslik""><a href=""/Product/Danismanlik/"">Danışmanlık</a></p>
            </div>

            <div class=""col-sm-12 col-md-2"" id=""menu2"">
                <p id=""baslik""><a href=""/Product/Saglik/"">Sağlık</a></p>
            </div>

            <div class=""col-sm-12 col-md-2"" id=""menu2"">
                <p id=""baslik""><a href=""/Product/Blog/"">Blog</a></p>
            </div>

            <div class=""col-sm-12 col-md-2"" id=""menu2"">
                <p id=""baslik""><a href=""/Product/Turizm/"">Turizm</a></p>
            </div>

            <div class=""col-sm-12 col-md-2"" id=""menu2"">
                <p id=""baslik""><a href=""/Product/Is/"" style=""font-weight: bold"">İş-Hizmet</a></p>
            </div>

            <div class=""col-sm-12 col-md-2"" id=""menu2"">
   ");
            WriteLiteral(@"             <p id=""baslik""><a href=""/Product/Sigorta/"">Sigorta</a></p>
            </div>
        </div>
    </div>

    <div class=""modal fade"" id=""modal1"">
        <div class=""modal-dialog modal-dialog-centered"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h4 class=""modal-title"">Bu Web Sayfasını Beğendiniz Mi?</h4>
                    <buton type=""button"" class=""close"" data-dismiss=""modal"">&times;</buton>
                </div>

                <div class=""modal-body justify-content-center"">
                    <img src=""/tasarimlar/is/48.jpg"" width=""100%"">
                </div>

                <div class=""modal-footer"" id=""modalalt"">
                    <form action=""/Product/Ekle"">
                        <input name=""ProductName"" value=""İş"" type=""hidden"" />
                        <input name=""Price"" value=""100"" type=""hidden"" />
                        <input name=""Category"" value=""İş"" type=""hidden"" />
                  ");
            WriteLiteral(@"      <button style=""background-color:#FB5369;border:1px solid #FB5369; width:200px;height:45px;color:white;font-size:20px;"" type=""submit"" class=""btn btn-success"">Sepete Ekle</button>
                    </form>
                </div>
            </div>
        </div>
    </div>


    <div class=""modal fade"" id=""modal2"">
        <div class=""modal-dialog modal-dialog-centered"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h4 class=""modal-title"">Bu Web Sayfasını Beğendiniz Mi?</h4>
                    <buton type=""button"" class=""close"" data-dismiss=""modal"">&times;</buton>
                </div>

                <div class=""modal-body justify-content-center"">
                    <img src=""/tasarimlar/is/49.jpg"" width=""100%"">
                </div>

                <div class=""modal-footer"" id=""modalalt"">
                    <form action=""/Product/Ekle"">
                        <input name=""ProductName"" value=""İş"" type=""hidden"" />
 ");
            WriteLiteral(@"                       <input name=""Price"" value=""100"" type=""hidden"" />
                        <input name=""Category"" value=""İş"" type=""hidden"" />
                        <button style=""background-color:#FB5369;border:1px solid #FB5369; width:200px;height:45px;color:white;font-size:20px;"" type=""submit"" class=""btn btn-success"">Sepete Ekle</button>
                    </form>
                </div>
            </div>
        </div>
    </div>

    <div class=""modal fade"" id=""modal3"">
        <div class=""modal-dialog modal-dialog-centered"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h4 class=""modal-title"">Bu Web Sayfasını Beğendiniz Mi?</h4>
                    <buton type=""button"" class=""close"" data-dismiss=""modal"">&times;</buton>
                </div>

                <div class=""modal-body justify-content-center"">
                    <img src=""/tasarimlar/is/50.jpg"" width=""100%"">
                </div>

                <div cla");
            WriteLiteral(@"ss=""modal-footer"" id=""modalalt"">
                    <form action=""/Product/Ekle"">
                        <input name=""ProductName"" value=""İş"" type=""hidden"" />
                        <input name=""Price"" value=""100"" type=""hidden"" />
                        <input name=""Category"" value=""İş"" type=""hidden"" />
                        <button style=""background-color:#FB5369;border:1px solid #FB5369; width:200px;height:45px;color:white;font-size:20px;"" type=""submit"" class=""btn btn-success"">Sepete Ekle</button>
                    </form>
                </div>
            </div>
        </div>
    </div>

    <div class=""modal fade"" id=""modal4"">
        <div class=""modal-dialog modal-dialog-centered"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h4 class=""modal-title"">Bu Web Sayfasını Beğendiniz Mi?</h4>
                    <buton type=""button"" class=""close"" data-dismiss=""modal"">&times;</buton>
                </div>

                <d");
            WriteLiteral(@"iv class=""modal-body justify-content-center"">
                    <img src=""/tasarimlar/is/51.jpg"" width=""100%"">
                </div>

                <div class=""modal-footer"" id=""modalalt"">
                    <form action=""/Product/Ekle"">
                        <input name=""ProductName"" value=""İş"" type=""hidden"" />
                        <input name=""Price"" value=""100"" type=""hidden"" />
                        <input name=""Category"" value=""İş"" type=""hidden"" />
                        <button style=""background-color:#FB5369;border:1px solid #FB5369; width:200px;height:45px;color:white;font-size:20px;"" type=""submit"" class=""btn btn-success"">Sepete Ekle</button>
                    </form>
                </div>
            </div>
        </div>
    </div>

    <div class=""modal fade"" id=""modal5"">
        <div class=""modal-dialog modal-dialog-centered"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h4 class=""modal-title"">Bu Web Say");
            WriteLiteral(@"fasını Beğendiniz Mi?</h4>
                    <buton type=""button"" class=""close"" data-dismiss=""modal"">&times;</buton>
                </div>

                <div class=""modal-body justify-content-center"">
                    <img src=""/tasarimlar/is/52.jpg"" width=""100%"">
                </div>

                <div class=""modal-footer"" id=""modalalt"">
                    <form action=""/Product/Ekle"">
                        <input name=""ProductName"" value=""İş"" type=""hidden"" />
                        <input name=""Price"" value=""100"" type=""hidden"" />
                        <input name=""Category"" value=""İş"" type=""hidden"" />
                        <button style=""background-color:#FB5369;border:1px solid #FB5369; width:200px;height:45px;color:white;font-size:20px;"" type=""submit"" class=""btn btn-success"">Sepete Ekle</button>
                    </form>
                </div>
            </div>
        </div>
    </div>

    <div class=""modal fade"" id=""modal6"">
        <div class=""modal-dialog");
            WriteLiteral(@" modal-dialog-centered"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h4 class=""modal-title"">Bu Web Sayfasını Beğendiniz Mi?</h4>
                    <buton type=""button"" class=""close"" data-dismiss=""modal"">&times;</buton>
                </div>

                <div class=""modal-body justify-content-center"">
                    <img src=""/tasarimlar/is/53.jpg"" width=""100%"">
                </div>

                <div class=""modal-footer"" id=""modalalt"">
                    <form action=""/Product/Ekle"">
                        <input name=""ProductName"" value=""İş"" type=""hidden"" />
                        <input name=""Price"" value=""100"" type=""hidden"" />
                        <input name=""Category"" value=""İş"" type=""hidden"" />
                        <button style=""background-color:#FB5369;border:1px solid #FB5369; width:200px;height:45px;color:white;font-size:20px;"" type=""submit"" class=""btn btn-success"">Sepete Ekle</button>
            ");
            WriteLiteral(@"        </form>
                </div>
            </div>
        </div>
    </div>

    <div class=""modal fade"" id=""modal7"">
        <div class=""modal-dialog modal-dialog-centered"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h4 class=""modal-title"">Bu Web Sayfasını Beğendiniz Mi?</h4>
                    <buton type=""button"" class=""close"" data-dismiss=""modal"">&times;</buton>
                </div>

                <div class=""modal-body justify-content-center"">
                    <img src=""/tasarimlar/is/54.jpg"" width=""100%"">
                </div>

                <div class=""modal-footer"" id=""modalalt"">
                    <form action=""/Product/Ekle"">
                        <input name=""ProductName"" value=""İş"" type=""hidden"" />
                        <input name=""Price"" value=""100"" type=""hidden"" />
                        <input name=""Category"" value=""İş"" type=""hidden"" />
                        <button style=""background-");
            WriteLiteral(@"color:#FB5369;border:1px solid #FB5369; width:200px;height:45px;color:white;font-size:20px;"" type=""submit"" class=""btn btn-success"">Sepete Ekle</button>
                    </form>
                </div>
            </div>
        </div>
    </div>

    <div class=""modal fade"" id=""modal8"">
        <div class=""modal-dialog modal-dialog-centered"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h4 class=""modal-title"">Bu Web Sayfasını Beğendiniz Mi?</h4>
                    <buton type=""button"" class=""close"" data-dismiss=""modal"">&times;</buton>
                </div>

                <div class=""modal-body justify-content-center"">
                    <img src=""/tasarimlar/is/55.jpg"" width=""100%"">
                </div>

                <div class=""modal-footer"" id=""modalalt"">
                    <form action=""/Product/Ekle"">
                        <input name=""ProductName"" value=""İş"" type=""hidden"" />
                        <input name");
            WriteLiteral(@"=""Price"" value=""100"" type=""hidden"" />
                        <input name=""Category"" value=""İş"" type=""hidden"" />
                        <button style=""background-color:#FB5369;border:1px solid #FB5369; width:200px;height:45px;color:white;font-size:20px;"" type=""submit"" class=""btn btn-success"">Sepete Ekle</button>
                    </form>
                </div>
            </div>
        </div>
    </div>

    <div class=""modal fade"" id=""modal9"">
        <div class=""modal-dialog modal-dialog-centered"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h4 class=""modal-title"">Bu Web Sayfasını Beğendiniz Mi?</h4>
                    <buton type=""button"" class=""close"" data-dismiss=""modal"">&times;</buton>
                </div>

                <div class=""modal-body justify-content-center"">
                    <img src=""/tasarimlar/is/56.jpg"" width=""100%"">
                </div>

                <div class=""modal-footer"" id=""modalalt"">
");
            WriteLiteral(@"                    <form action=""/Product/Ekle"">
                        <input name=""ProductName"" value=""İş"" type=""hidden"" />
                        <input name=""Price"" value=""100"" type=""hidden"" />
                        <input name=""Category"" value=""İş"" type=""hidden"" />
                        <button style=""background-color:#FB5369;border:1px solid #FB5369; width:200px;height:45px;color:white;font-size:20px;"" type=""submit"" class=""btn btn-success"">Sepete Ekle</button>
                    </form>
                </div>
            </div>
        </div>
    </div>

    <div class=""modal fade"" id=""modal10"">
        <div class=""modal-dialog modal-dialog-centered"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h4 class=""modal-title"">Bu Web Sayfasını Beğendiniz Mi?</h4>
                    <buton type=""button"" class=""close"" data-dismiss=""modal"">&times;</buton>
                </div>

                <div class=""modal-body justify-cont");
            WriteLiteral(@"ent-center"">
                    <img src=""/tasarimlar/is/57.jpg"" width=""100%"">
                </div>

                <div class=""modal-footer"" id=""modalalt"">
                    <form action=""/Product/Ekle"">
                        <input name=""ProductName"" value=""İş"" type=""hidden"" />
                        <input name=""Price"" value=""100"" type=""hidden"" />
                        <input name=""Category"" value=""İş"" type=""hidden"" />
                        <button style=""background-color:#FB5369;border:1px solid #FB5369; width:200px;height:45px;color:white;font-size:20px;"" type=""submit"" class=""btn btn-success"">Sepete Ekle</button>
                    </form>
                </div>
            </div>
        </div>
    </div>

    <div class=""modal fade"" id=""modal11"">
        <div class=""modal-dialog modal-dialog-centered"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h4 class=""modal-title"">Bu Web Sayfasını Beğendiniz Mi?</h4>
    ");
            WriteLiteral(@"                <buton type=""button"" class=""close"" data-dismiss=""modal"">&times;</buton>
                </div>

                <div class=""modal-body justify-content-center"">
                    <img src=""/tasarimlar/is/58.jpg"" width=""100%"">
                </div>

                <div class=""modal-footer"" id=""modalalt"">
                    <form action=""/Product/Ekle"">
                        <input name=""ProductName"" value=""İş"" type=""hidden"" />
                        <input name=""Price"" value=""100"" type=""hidden"" />
                        <input name=""Category"" value=""İş"" type=""hidden"" />
                        <button style=""background-color:#FB5369;border:1px solid #FB5369; width:200px;height:45px;color:white;font-size:20px;"" type=""submit"" class=""btn btn-success"">Sepete Ekle</button>
                    </form>
                </div>
            </div>
        </div>
    </div>

    <div class=""modal fade"" id=""modal12"">
        <div class=""modal-dialog modal-dialog-centered"">
     ");
            WriteLiteral(@"       <div class=""modal-content"">
                <div class=""modal-header"">
                    <h4 class=""modal-title"">Bu Web Sayfasını Beğendiniz Mi?</h4>
                    <buton type=""button"" class=""close"" data-dismiss=""modal"">&times;</buton>
                </div>

                <div class=""modal-body justify-content-center"">
                    <img src=""/tasarimlar/is/59.jpg"" width=""100%"">
                </div>

                <div class=""modal-footer"" id=""modalalt"">
                    <form action=""/Product/Ekle"">
                        <input name=""ProductName"" value=""İş"" type=""hidden"" />
                        <input name=""Price"" value=""100"" type=""hidden"" />
                        <input name=""Category"" value=""İş"" type=""hidden"" />
                        <button style=""background-color:#FB5369;border:1px solid #FB5369; width:200px;height:45px;color:white;font-size:20px;"" type=""submit"" class=""btn btn-success"">Sepete Ekle</button>
                    </form>
              ");
            WriteLiteral(@"  </div>
            </div>
        </div>
    </div>


    <div class=""container-fluid justify-content-center"" id=""orta2"">
        <div class=""row"">
            <div class=""col-sm-12 col-md-6 col-lg-3"" id=""kutu2"" align=""center""><img src=""/tasarimlar/is/48.jpg"" class=""img-fluid"" id=""resim"" data-toggle=""modal"" data-target=""#modal1""><p id=""sayi"">86</p><p id=""kategori"">İş-Hizmet</p><p style=""font-weight: bold"">100₺</p></div>
            <div class=""col-sm-12 col-md-6 col-lg-3"" id=""kutu2"" align=""center""><img src=""/tasarimlar/is/49.jpg"" class=""img-fluid"" id=""resim"" data-toggle=""modal"" data-target=""#modal2""><p id=""sayi"">87</p><p id=""kategori"">İş-Hizmet</p><p style=""font-weight: bold"">100₺</p></div>
            <div class=""col-sm-12 col-md-6 col-lg-3"" id=""kutu2"" align=""center""><img src=""/tasarimlar/is/50.jpg"" class=""img-fluid"" id=""resim"" data-toggle=""modal"" data-target=""#modal3""><p id=""sayi"">88</p><p id=""kategori"">İş-Hizmet</p><p style=""font-weight: bold"">100₺</p></div>
            <div class=""col-sm-12 c");
            WriteLiteral(@"ol-md-6 col-lg-3"" id=""kutu2"" align=""center""><img src=""/tasarimlar/is/51.jpg"" class=""img-fluid"" id=""resim"" data-toggle=""modal"" data-target=""#modal4""><p id=""sayi"">89</p><p id=""kategori"">İş-Hizmet</p><p style=""font-weight: bold"">100₺</p></div>
        </div> <br>

        <div class=""row"">
            <div class=""col-sm-12 col-md-6 col-lg-3"" id=""kutu2"" align=""center""><img src=""/tasarimlar/is/52.jpg"" class=""img-fluid"" id=""resim"" data-toggle=""modal"" data-target=""#modal5""><p id=""sayi"">90</p><p id=""kategori"">İş-Hizmet</p><p style=""font-weight: bold"">100₺</p></div>
            <div class=""col-sm-12 col-md-6 col-lg-3"" id=""kutu2"" align=""center""><img src=""/tasarimlar/is/53.jpg"" class=""img-fluid"" id=""resim"" data-toggle=""modal"" data-target=""#modal6""><p id=""sayi"">91</p><p id=""kategori"">İş-Hizmet</p><p style=""font-weight: bold"">100₺</p></div>
            <div class=""col-sm-12 col-md-6 col-lg-3"" id=""kutu2"" align=""center""><img src=""/tasarimlar/is/54.jpg"" class=""img-fluid"" id=""resim"" data-toggle=""modal"" data-target=""#mod");
            WriteLiteral(@"al7""><p id=""sayi"">92</p><p id=""kategori"">İş-Hizmet</p><p style=""font-weight: bold"">100₺</p></div>
            <div class=""col-sm-12 col-md-6 col-lg-3"" id=""kutu2"" align=""center""><img src=""/tasarimlar/is/55.jpg"" class=""img-fluid"" id=""resim"" data-toggle=""modal"" data-target=""#modal8""><p id=""sayi"">93</p><p id=""kategori"">İş-Hizmet</p><p style=""font-weight: bold"">100₺</p></div>
        </div> <br>

        <div class=""row"">
            <div class=""col-sm-12 col-md-6 col-lg-3"" id=""kutu2"" align=""center""><img src=""/tasarimlar/is/56.jpg"" class=""img-fluid"" id=""resim"" data-toggle=""modal"" data-target=""#modal9""><p id=""sayi"">94</p><p id=""kategori"">İş-Hizmet</p><p style=""font-weight: bold"">100₺</p></div>
            <div class=""col-sm-12 col-md-6 col-lg-3"" id=""kutu2"" align=""center""><img src=""/tasarimlar/is/57.jpg"" class=""img-fluid"" id=""resim"" data-toggle=""modal"" data-target=""#modal10""><p id=""sayi"">95</p><p id=""kategori"">İş-Hizmet</p><p style=""font-weight: bold"">100₺</p></div>
            <div class=""col-sm-12 col-md-6 ");
            WriteLiteral(@"col-lg-3"" id=""kutu2"" align=""center""><img src=""/tasarimlar/is/58.jpg"" class=""img-fluid"" id=""resim"" data-toggle=""modal"" data-target=""#modal11""><p id=""sayi"">96</p><p id=""kategori"">İş-Hizmet</p><p style=""font-weight: bold"">100₺</p></div>
            <div class=""col-sm-12 col-md-6 col-lg-3"" id=""kutu2"" align=""center""><img src=""/tasarimlar/is/59.jpg"" class=""img-fluid"" id=""resim"" data-toggle=""modal"" data-target=""#modal12""><p id=""sayi"">97</p><p id=""kategori"">İş-Hizmet</p><p style=""font-weight: bold"">100₺</p></div>
        </div>
    </div>
</div>
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br");
            WriteLiteral(" />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Products>> Html { get; private set; }
    }
}
#pragma warning restore 1591
