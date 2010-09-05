<%@ Page Title="" Language="C#" MasterPageFile="~/ModuloAdministrador/MasterPageAdministrador.master"
    AutoEventWireup="true" CodeFile="Incluir.aspx.cs" Inherits="ModuloAdministrador_ModuloUsuario_Incluir" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderHeader" runat="server">
    Incluir Usuário
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
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
    <asp:Label ID="lblLogin" runat="server" Text="Login:"></asp:Label>
    <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox>
    <asp:Label ID="lblSenha" runat="server" Text="Senha:"></asp:Label>
    <asp:TextBox ID="txtSenha" TextMode="Password" runat="server"></asp:TextBox>


    <asp:Button ID="btnConfirmar" runat="server" Text="Confirmar" onclick="btnConfirmar_Click" />

</asp:Content>
