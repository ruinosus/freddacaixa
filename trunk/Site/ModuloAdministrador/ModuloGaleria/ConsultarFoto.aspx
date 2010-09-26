﻿<%@ Page Title="" Language="C#" MasterPageFile="~/ModuloAdministrador/MasterPageAdministrador.master" AutoEventWireup="true" CodeFile="ConsultarFoto.aspx.cs" Inherits="ModuloAdministrador_ModuloFoto_ConsultarFoto" %>

<%@ Register src="~/ModuloAdministrador/ModuloGaleria/FotoSelecionar.ascx" tagname="FotoSelecionar" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHeader" Runat="Server">
Consultar Postagens Foto
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="AvisoDeErro1" style="text-align: center;">
        <asp:ValidationSummary ID="vsuAvisoDeErro" Visible="false" runat="server" ValidationGroup="AvisoDeErro">
        </asp:ValidationSummary>
        
        <asp:ValidationSummary ID="vsuAvisoDeInformacao" runat="server" ValidationGroup="AvisoDeInformacao"
            ForeColor="#14A351" Visible="false"></asp:ValidationSummary>
        <asp:CustomValidator ID="cvaAvisoDeErro" runat="server" ValidationGroup="AvisoDeErro"
            Visible="false"></asp:CustomValidator>
        <asp:CustomValidator ID="cvaAvisoDeInformacao" runat="server" ValidationGroup="AvisoDeInformacao"
            ForeColor="#14A351" Visible="False"></asp:CustomValidator>    </div>
            <uc1:FotoSelecionar ID="FotoSelecionar1" runat="server" />
             <table width="100%">
            <tr align="center">
                <td>
                    <table>
                        <tr>
                            <td>
                                <asp:Button ID="btnIncluir" runat="server" Text="Incluir" CssClass="botao" Font-Bold="True" ForeColor="#0033CC" PostBackUrl="~/ModuloAdministrador/ModuloGaleria/IncluirFoto.aspx" />
                                <asp:Button ID="btnAlterar" runat="server" Text="Alterar" CssClass="botao" Font-Bold="True" ForeColor="#0033CC" OnClick="btnAlterar_Click" />
                                <asp:Button ID="btnExcluir" runat="server" Text="Excluir" CssClass="botao" Font-Bold="True" ForeColor="#0033CC" OnClick="btnExcluir_Click" />
                                
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
</asp:Content>
