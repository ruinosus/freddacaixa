﻿<%@ Page Title="" Language="C#" MasterPageFile="~/ModuloAdministrador/MasterPageAdministrador.master"
    AutoEventWireup="true" CodeFile="IncluirGaleria.aspx.cs" Inherits="ModuloAdministrador_ModuloGaleria_IncluirGaleria" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHeader" runat="Server">
    Incluir Galeria
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
                <asp:Label ID="lblImagem" runat="server" Text="Imagem:"></asp:Label>
            </td>
            <td>
                 <asp:FileUpload ID="fileUpEx" runat="server" />
            </td>
        </tr>
    <tr>
            <td>
                <asp:Label ID="lblLegenda" runat="server" Text="Legenda:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtLegenda" Width="700px" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
    <asp:Button ID="btnConfirmar" runat="server" Text="Confirmar" OnClick="btnConfirmar_Click" />
    </td></tr>
    </table>
</asp:Content>
