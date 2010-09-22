<%@ Page Title="" Language="C#" MasterPageFile="~/ModuloAdministrador/MasterPageAdministrador.master" ValidateRequest="false"
    AutoEventWireup="true" CodeFile="Incluir.aspx.cs" Inherits="ModuloAdministrador_ModuloVideo_Incluir" %>



<%@ Register assembly="Infragistics4.WebUI.WebHtmlEditor.v10.2, Version=10.2.20102.1011, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" namespace="Infragistics.WebUI.WebHtmlEditor" tagprefix="ighedit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHeader" runat="Server">
    Incluir Conteúdo do Video
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="AvisoDeErro1" style="text-align: center;">
       
        
        <asp:ValidationSummary ID="vsuAvisoDeErro" Visible="false" runat="server" ValidationGroup="AvisoDeErro">
        </asp:ValidationSummary>
        <asp:ValidationSummary ID="vsuAvisoDeInformacao" runat="server" ValidationGroup="AvisoDeInformacao"
            ForeColor="#14A351" Visible="false"></asp:ValidationSummary>
        <asp:CustomValidator ID="cvaAvisoDeErro" runat="server" ValidationGroup="AvisoDeErro"
            Visible="false"></asp:CustomValidator>
        <asp:CustomValidator ID="cvaAvisoDeInformacao" runat="server" ValidationGroup="AvisoDeInformacao"
            ForeColor="#14A351" Visible="False"></asp:CustomValidator>
    </div>
    <table>
        <tr>
            <td>
                <asp:Label ID="lblTitulo" runat="server" Text="Título:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtTitulo" Width="700px" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblSubTitulo" runat="server" Text="Sub Título:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtSubTitulo" Width="700px"  runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblCorpo" runat="server" Text="Corpo:"></asp:Label>
            </td>
            <td>
               <asp:TextBox ID="txtCorpo" Width="700px" TextMode="MultiLine" runat="server" 
                    Height="146px"></asp:TextBox></td>
        </tr>
        <tr>
        <td colspan="2" align="right">  <asp:Button ID="btnConfirmar" runat="server" 
                Text="Confirmar" onclick="btnConfirmar_Click" /></td>
        </tr>
    </table>
  
</asp:Content>
