#pragma checksum "C:\Users\eduar\Desktop\ETEC\MODULO2\DS\Projetos\RpgMvc\Views\Personagens\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2170f12ac258db7cbb966f81235d2bfd8ea304f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personagens_Index), @"mvc.1.0.view", @"/Views/Personagens/Index.cshtml")]
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
#line 1 "C:\Users\eduar\Desktop\ETEC\MODULO2\DS\Projetos\RpgMvc\Views\_ViewImports.cshtml"
using RpgMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eduar\Desktop\ETEC\MODULO2\DS\Projetos\RpgMvc\Views\_ViewImports.cshtml"
using RpgMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2170f12ac258db7cbb966f81235d2bfd8ea304f5", @"/Views/Personagens/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ea8742186739939b51d95376aeaeffef3697b50", @"/Views/_ViewImports.cshtml")]
    public class Views_Personagens_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RpgMvc.Models.PersonagemViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!--Namespace da classe de Modelo para esta view-->\n");
#nullable restore
#line 3 "C:\Users\eduar\Desktop\ETEC\MODULO2\DS\Projetos\RpgMvc\Views\Personagens\Index.cshtml"
  
    ViewBag.Title = "Autenticar"; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\eduar\Desktop\ETEC\MODULO2\DS\Projetos\RpgMvc\Views\Personagens\Index.cshtml"
 if (@TempData["Mensagem"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\n        ");
#nullable restore
#line 9 "C:\Users\eduar\Desktop\ETEC\MODULO2\DS\Projetos\RpgMvc\Views\Personagens\Index.cshtml"
   Write(TempData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
#nullable restore
#line 10 "C:\Users\eduar\Desktop\ETEC\MODULO2\DS\Projetos\RpgMvc\Views\Personagens\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--Configuração para exibir mensagem de erro -->\n");
#nullable restore
#line 12 "C:\Users\eduar\Desktop\ETEC\MODULO2\DS\Projetos\RpgMvc\Views\Personagens\Index.cshtml"
 if (@TempData["MensagemErro"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\n        ");
#nullable restore
#line 15 "C:\Users\eduar\Desktop\ETEC\MODULO2\DS\Projetos\RpgMvc\Views\Personagens\Index.cshtml"
   Write(TempData["MensagemErro"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
#nullable restore
#line 16 "C:\Users\eduar\Desktop\ETEC\MODULO2\DS\Projetos\RpgMvc\Views\Personagens\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!--Inclua os TempData para Sucesso e Erro aqui, conforme exemplo na view de Autenticação-->\n");
#nullable restore
#line 19 "C:\Users\eduar\Desktop\ETEC\MODULO2\DS\Projetos\RpgMvc\Views\Personagens\Index.cshtml"
  ViewBag.Title = "Personagens"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--Título da página para o navegador-->\n<h2>Relação de Personagens</h2><!--Título da página-->\n<p>\n\n <!--Links apontando para views na mesma pasta-->\n");
#nullable restore
#line 24 "C:\Users\eduar\Desktop\ETEC\MODULO2\DS\Projetos\RpgMvc\Views\Personagens\Index.cshtml"
Write(Html.ActionLink("Criar Novo Personagem", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \n</p>\n\n<table class=\"table\">\n <tr><!--Títulos das colunas da tabela--> \n    <th>");
#nullable restore
#line 29 "C:\Users\eduar\Desktop\ETEC\MODULO2\DS\Projetos\RpgMvc\Views\Personagens\Index.cshtml"
   Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th> \n    <th>");
#nullable restore
#line 30 "C:\Users\eduar\Desktop\ETEC\MODULO2\DS\Projetos\RpgMvc\Views\Personagens\Index.cshtml"
   Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th> \n    <th>");
#nullable restore
#line 31 "C:\Users\eduar\Desktop\ETEC\MODULO2\DS\Projetos\RpgMvc\Views\Personagens\Index.cshtml"
   Write(Html.DisplayNameFor(model => model.Classe));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th> \n    <th>");
#nullable restore
#line 32 "C:\Users\eduar\Desktop\ETEC\MODULO2\DS\Projetos\RpgMvc\Views\Personagens\Index.cshtml"
   Write(Html.DisplayNameFor(model => model.Disputas));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n    <th>");
#nullable restore
#line 33 "C:\Users\eduar\Desktop\ETEC\MODULO2\DS\Projetos\RpgMvc\Views\Personagens\Index.cshtml"
   Write(Html.DisplayNameFor(model => model.Vitorias));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n    <th>");
#nullable restore
#line 34 "C:\Users\eduar\Desktop\ETEC\MODULO2\DS\Projetos\RpgMvc\Views\Personagens\Index.cshtml"
   Write(Html.DisplayNameFor(model => model.Derrotas));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n    <th></th>\n </tr>\n\n<!--Looping para escrever os dados na tabela-->\n");
#nullable restore
#line 39 "C:\Users\eduar\Desktop\ETEC\MODULO2\DS\Projetos\RpgMvc\Views\Personagens\Index.cshtml"
 foreach (var item in Model) 
 { 

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n        <td>");
#nullable restore
#line 42 "C:\Users\eduar\Desktop\ETEC\MODULO2\DS\Projetos\RpgMvc\Views\Personagens\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 43 "C:\Users\eduar\Desktop\ETEC\MODULO2\DS\Projetos\RpgMvc\Views\Personagens\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \n        <td>");
#nullable restore
#line 44 "C:\Users\eduar\Desktop\ETEC\MODULO2\DS\Projetos\RpgMvc\Views\Personagens\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Classe));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \n        <td>");
#nullable restore
#line 45 "C:\Users\eduar\Desktop\ETEC\MODULO2\DS\Projetos\RpgMvc\Views\Personagens\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Disputas ));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \n        <td>");
#nullable restore
#line 46 "C:\Users\eduar\Desktop\ETEC\MODULO2\DS\Projetos\RpgMvc\Views\Personagens\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Vitorias));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \n        <td>");
#nullable restore
#line 47 "C:\Users\eduar\Desktop\ETEC\MODULO2\DS\Projetos\RpgMvc\Views\Personagens\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Derrotas));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \n        <td><!--Coluna para Links/botões-->\n        ");
#nullable restore
#line 49 "C:\Users\eduar\Desktop\ETEC\MODULO2\DS\Projetos\RpgMvc\Views\Personagens\Index.cshtml"
   Write(Html.ActionLink("Editar", "Edit", new { id = item.Id } ));

#line default
#line hidden
#nullable disable
            WriteLiteral(" | \n        ");
#nullable restore
#line 50 "C:\Users\eduar\Desktop\ETEC\MODULO2\DS\Projetos\RpgMvc\Views\Personagens\Index.cshtml"
   Write(Html.ActionLink("Detalhes", "Details", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" | \n        ");
#nullable restore
#line 51 "C:\Users\eduar\Desktop\ETEC\MODULO2\DS\Projetos\RpgMvc\Views\Personagens\Index.cshtml"
   Write(Html.ActionLink("Deletar", "Delete", new { id = item.Id }
         , new {onclick = "return confirm('Deseja realmente deletar este personagem ?');"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("; \n        </td>\n    </tr>\n");
#nullable restore
#line 55 "C:\Users\eduar\Desktop\ETEC\MODULO2\DS\Projetos\RpgMvc\Views\Personagens\Index.cshtml"
 } 

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n\n");
#nullable restore
#line 58 "C:\Users\eduar\Desktop\ETEC\MODULO2\DS\Projetos\RpgMvc\Views\Personagens\Index.cshtml"
Write(Html.ActionLink("Clique aqui para um embate com armas!!!", "Index", "Disputas",
null, new { @class = "btn btn-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 61 "C:\Users\eduar\Desktop\ETEC\MODULO2\DS\Projetos\RpgMvc\Views\Personagens\Index.cshtml"
Write(Html.ActionLink("Clique aqui para um embate com habilidades!!!", "IndexHabilidades", "Disputas",
null, new { @class = "btn btn-dark" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 64 "C:\Users\eduar\Desktop\ETEC\MODULO2\DS\Projetos\RpgMvc\Views\Personagens\Index.cshtml"
Write(Html.ActionLink("Clique aqui para um embate em grupo!!!", "DisputaGeral", "Disputas",
null, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RpgMvc.Models.PersonagemViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
