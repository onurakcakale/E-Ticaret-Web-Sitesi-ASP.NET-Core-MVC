#pragma checksum "C:\Users\onur_\OneDrive\Masaüstü\Dersler\Projeler\E-Ticaret Sitesi (Asp.net MVC)\WebApplication1\WebApplication1\Views\Product\Cicek.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8f843a1c97ae51ea4794e9ebb82a93bd3a9bd95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Cicek), @"mvc.1.0.view", @"/Views/Product/Cicek.cshtml")]
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
#line 1 "C:\Users\onur_\OneDrive\Masaüstü\Dersler\Projeler\E-Ticaret Sitesi (Asp.net MVC)\WebApplication1\WebApplication1\Views\Product\Cicek.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8f843a1c97ae51ea4794e9ebb82a93bd3a9bd95", @"/Views/Product/Cicek.cshtml")]
    public class Views_Product_Cicek : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Products>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\onur_\OneDrive\Masaüstü\Dersler\Projeler\E-Ticaret Sitesi (Asp.net MVC)\WebApplication1\WebApplication1\Views\Product\Cicek.cshtml"
  
    ViewData["Title"] = "Cicek";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""stylesheet"" href=""/css/style.css"">
<link rel=""stylesheet"" href=""/css/stylecicek.css"">
<link rel=""stylesheet"" href=""/css/bootstrap.css"">

<div class=""a"">
    <div class=""container"" id=""orta1"">
        <div class=""row"">
            <div class=""col-sm-12 col-md-2"" id=""menu2"">
                <p id=""baslik""><a href=""/Product/Urunler/"">Avukatlık-Hukuk</a></p>
            </div>

            <div class=""col-sm-12 col-md-2"" id=""menu2"">
                <p id=""baslik"" style=""font-weight: bold""><a href=""/Product/Cicek/"">Çiçek-Peyzaj</a></p>
            </div>

            <div class=""col-sm-12 col-md-2"" id=""menu2"">
                <p id=""baslik""><a href=""/Product/Otomotiv/"">Otomotiv</a></p>
            </div>

            <div class=""col-sm-12 col-md-2"" id=""menu2"">
                <p id=""baslik""><a href=""/Product/Temizlik/"">Temizlik</a></p>
            </div>

            <div class=""col-sm-12 col-md-2"" id=""menu2"">
                <p id=""baslik""><a href=""/Product/Insaat/"">İnşaat-Mim");
            WriteLiteral(@"arlık</a></p>
            </div>

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
                <p id=""baslik""><a href=""/Product/Is/"">İş-Hizmet</a></p>
            </div>

            <div class=""col-sm-12 col-md-2"" id=""menu2"">
");
            WriteLiteral(@"                <p id=""baslik""><a href=""/Product/Sigorta/"">Sigorta</a></p>
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
                    <img src=""/tasarimlar/cicek/11.jpg"" width=""100%"">
                </div>

                <div class=""modal-footer"" id=""modalalt"">
                    <form action=""/Product/Ekle"">
                        <input name=""ProductName"" value=""Çiçek"" type=""hidden"" />
                        <input name=""Price"" value=""100"" type=""hidden"" />
                        <input name=""Category"" value=""Çiçek"" type=""hidden"" />
      ");
            WriteLiteral(@"                  <button style=""background-color:#FB5369;border:1px solid #FB5369; width:200px;height:45px;color:white;font-size:20px;"" type=""submit"" class=""btn btn-success"">Sepete Ekle</button>
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
                    <img src=""/tasarimlar/cicek/12.jpg"" width=""460px"">
                </div>

                <div class=""modal-footer"" id=""modalalt"">
                    <form action=""/Product/Ekle"">
                        <input name=""ProductName"" value=""Çiçek"" ");
            WriteLiteral(@"type=""hidden"" />
                        <input name=""Price"" value=""100"" type=""hidden"" />
                        <input name=""Category"" value=""Çiçek"" type=""hidden"" />
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
                    <img src=""/tasarimlar/cicek/13.jpg"" width=""460px"">
                </div>
");
            WriteLiteral(@"
                <div class=""modal-footer"" id=""modalalt"">
                    <form action=""/Product/Ekle"">
                        <input name=""ProductName"" value=""Çiçek"" type=""hidden"" />
                        <input name=""Price"" value=""100"" type=""hidden"" />
                        <input name=""Category"" value=""Çiçek"" type=""hidden"" />
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
            ");
            WriteLiteral(@"    </div>

                <div class=""modal-body justify-content-center"">
                    <img src=""/tasarimlar/cicek/14.jpg"" width=""460px"">
                </div>

                <div class=""modal-footer"" id=""modalalt"">
                    <form action=""/Product/Ekle"">
                        <input name=""ProductName"" value=""Çiçek"" type=""hidden"" />
                        <input name=""Price"" value=""100"" type=""hidden"" />
                        <input name=""Category"" value=""Çiçek"" type=""hidden"" />
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
            ");
            WriteLiteral(@"        <h4 class=""modal-title"">Bu Web Sayfasını Beğendiniz Mi?</h4>
                    <buton type=""button"" class=""close"" data-dismiss=""modal"">&times;</buton>
                </div>

                <div class=""modal-body justify-content-center"">
                    <img src=""/tasarimlar/cicek/15.jpg"" width=""460px"">
                </div>

                <div class=""modal-footer"" id=""modalalt"">
                    <form action=""/Product/Ekle"">
                        <input name=""ProductName"" value=""Çiçek"" type=""hidden"" />
                        <input name=""Price"" value=""100"" type=""hidden"" />
                        <input name=""Category"" value=""Çiçek"" type=""hidden"" />
                        <button style=""background-color:#FB5369;border:1px solid #FB5369; width:200px;height:45px;color:white;font-size:20px;"" type=""submit"" class=""btn btn-success"">Sepete Ekle</button>
                    </form>
                </div>
            </div>
        </div>
    </div>

    <div class=""modal ");
            WriteLiteral(@"fade"" id=""modal6"">
        <div class=""modal-dialog modal-dialog-centered"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h4 class=""modal-title"">Bu Web Sayfasını Beğendiniz Mi?</h4>
                    <buton type=""button"" class=""close"" data-dismiss=""modal"">&times;</buton>
                </div>

                <div class=""modal-body justify-content-center"">
                    <img src=""/tasarimlar/cicek/16.jpg"" width=""460px"">
                </div>

                <div class=""modal-footer"" id=""modalalt"">
                    <form action=""/Product/Ekle"">
                        <input name=""ProductName"" value=""Çiçek"" type=""hidden"" />
                        <input name=""Price"" value=""100"" type=""hidden"" />
                        <input name=""Category"" value=""Çiçek"" type=""hidden"" />
                        <button style=""background-color:#FB5369;border:1px solid #FB5369; width:200px;height:45px;color:white;font-size:20px;"" type=""subm");
            WriteLiteral(@"it"" class=""btn btn-success"">Sepete Ekle</button>
                    </form>
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
                    <img src=""/tasarimlar/cicek/17.jpg"" width=""460px"">
                </div>

                <div class=""modal-footer"" id=""modalalt"">
                    <form action=""/Product/Ekle"">
                        <input name=""ProductName"" value=""Çiçek"" type=""hidden"" />
                        <input name=""Price"" value=""100"" type=""hidden"" />
                        <input name=""Category"" value=""Çiç");
            WriteLiteral(@"ek"" type=""hidden"" />
                        <button style=""background-color:#FB5369;border:1px solid #FB5369; width:200px;height:45px;color:white;font-size:20px;"" type=""submit"" class=""btn btn-success"">Sepete Ekle</button>
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
                    <img src=""/tasarimlar/cicek/18.jpg"" width=""460px"">
                </div>

                <div class=""modal-footer"" id=""modalalt"">
                    <form action=""/Product/Ekle"">
                        <input name=""P");
            WriteLiteral(@"roductName"" value=""Çiçek"" type=""hidden"" />
                        <input name=""Price"" value=""100"" type=""hidden"" />
                        <input name=""Category"" value=""Çiçek"" type=""hidden"" />
                        <button style=""background-color:#FB5369;border:1px solid #FB5369; width:200px;height:45px;color:white;font-size:20px;"" type=""submit"" class=""btn btn-success"">Sepete Ekle</button>
                    </form>
                </div>
            </div>
        </div>
    </div>




    <div class=""container-fluid justify-content-center"" id=""orta2"">
        <div class=""row"">
            <div class=""col-sm-12 col-md-6 col-lg-3"" id=""kutu2"" align=""center""><img src=""/tasarimlar/cicek/11.jpg"" class=""img-fluid"" id=""resim"" data-toggle=""modal"" data-target=""#modal1""><p id=""sayi"">11</p><p id=""kategori"">Çiçek-Peyzaj</p><p style=""font-weight: bold"">100₺</p></div>
            <div class=""col-sm-12 col-md-6 col-lg-3"" id=""kutu2"" align=""center""><img src=""/tasarimlar/cicek/12.jpg"" class=""img-fluid"" id=");
            WriteLiteral(@"""resim"" data-toggle=""modal"" data-target=""#modal2""><p id=""sayi"">12</p><p id=""kategori"">Çiçek-Peyzaj</p><p style=""font-weight: bold"">100₺</p></div>
            <div class=""col-sm-12 col-md-6 col-lg-3"" id=""kutu2"" align=""center""><img src=""/tasarimlar/cicek/13.jpg"" class=""img-fluid"" id=""resim"" data-toggle=""modal"" data-target=""#modal3""><p id=""sayi"">13</p><p id=""kategori"">Çiçek-Peyzaj</p><p style=""font-weight: bold"">100₺</p></div>
            <div class=""col-sm-12 col-md-6 col-lg-3"" id=""kutu2"" align=""center""><img src=""/tasarimlar/cicek/14.jpg"" class=""img-fluid"" id=""resim"" data-toggle=""modal"" data-target=""#modal4""><p id=""sayi"">14</p><p id=""kategori"">Çiçek-Peyzaj</p><p style=""font-weight: bold"">100₺</p></div>
        </div> <br>

        <div class=""row"">
            <div class=""col-sm-12 col-md-6 col-lg-3"" id=""kutu2"" align=""center""><img src=""/tasarimlar/cicek/15.jpg"" class=""img-fluid"" id=""resim"" data-toggle=""modal"" data-target=""#modal5""><p id=""sayi"">15</p><p id=""kategori"">Çiçek-Peyzaj</p><p style=""font-weight: ");
            WriteLiteral(@"bold"">100₺</p></div>
            <div class=""col-sm-12 col-md-6 col-lg-3"" id=""kutu2"" align=""center""><img src=""/tasarimlar/cicek/16.jpg"" class=""img-fluid"" id=""resim"" data-toggle=""modal"" data-target=""#modal6""><p id=""sayi"">16</p><p id=""kategori"">Çiçek-Peyzaj</p><p style=""font-weight: bold"">100₺</p></div>
            <div class=""col-sm-12 col-md-6 col-lg-3"" id=""kutu2"" align=""center""><img src=""/tasarimlar/cicek/17.jpg"" class=""img-fluid"" id=""resim"" data-toggle=""modal"" data-target=""#modal7""><p id=""sayi"">17</p><p id=""kategori"">Çiçek-Peyzaj</p><p style=""font-weight: bold"">100₺</p></div>
            <div class=""col-sm-12 col-md-6 col-lg-3"" id=""kutu2"" align=""center""><img src=""/tasarimlar/cicek/18.jpg"" class=""img-fluid"" id=""resim"" data-toggle=""modal"" data-target=""#modal8""><p id=""sayi"">18</p><p id=""kategori"">Çiçek-Peyzaj</p><p style=""font-weight: bold"">100₺</p></div>
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
<br /");
            WriteLiteral(@">
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
<br />");
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
