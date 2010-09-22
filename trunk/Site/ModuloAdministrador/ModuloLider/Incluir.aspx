<%@ Page Title="" Language="C#" MasterPageFile="~/ModuloAdministrador/MasterPageAdministrador.master"
    AutoEventWireup="true" CodeFile="Incluir.aspx.cs" Inherits="ModuloAdministrador_ModuloLider_Incluir" %>



<%@ Register assembly="Infragistics4.WebUI.WebHtmlEditor.v10.2, Version=10.2.20102.1011, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" namespace="Infragistics.WebUI.WebHtmlEditor" tagprefix="ighedit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHeader" runat="Server">
    Incluir Conteúdo do Lider
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
                <asp:Label ID="lblNome" runat="server" Text="Nome:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNome" Width="700px" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblLogradouro" runat="server" Text="Logradouro:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtLogradouro" Width="700px"  runat="server"></asp:TextBox>
            </td>
        </tr> <tr>
            <td>
                <asp:Label ID="lblNumero" runat="server" Text="Numero:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNumero" Width="700px"  runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>
                <asp:Label ID="lblComplemento" runat="server" Text="Complemento:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtComplemento" Width="700px"  runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lbBairro" runat="server" Text="Bairro:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtBairro" Width="700px"  runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>
                <asp:Label ID="lblCep" runat="server" Text="Cep:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtCep" Width="700px"  runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>
                <asp:Label ID="lblCidade" runat="server" Text="Cidade:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtCidade" Width="700px"  runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>
                <asp:Label ID="lblLocal" runat="server" Text="Local:"></asp:Label>
            </td>
            <td>
             <asp:DropDownList runat="server" ID="cmbLocal">
                    <asp:ListItem>Ponta de Pedras</asp:ListItem>
                    <asp:ListItem>Goiana</asp:ListItem>
                    <asp:ListItem>Tejucupapo</asp:ListItem>
                    <asp:ListItem>Timbauba</asp:ListItem>
                    <asp:ListItem>Carne de Vaca</asp:ListItem>
                     <asp:ListItem>Condado</asp:ListItem>
                     <asp:ListItem> Itaquitinga</asp:ListItem>
                     <asp:ListItem> Aliança</asp:ListItem>
                     <asp:ListItem> Nazaré</asp:ListItem>
                     <asp:ListItem> Gambá</asp:ListItem>
                     <asp:ListItem> São Loutenço</asp:ListItem>
                     <asp:ListItem> Carne de vaca</asp:ListItem>
                     <asp:ListItem> Barra de Catuama</asp:ListItem>
                </asp:DropDownList>

            </td>
        </tr>
         <tr>
            <td>
                <asp:Label ID="lblCpf" runat="server" Text="Cpf:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtCpf" Width="700px"  runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>
                <asp:Label ID="lblRg" runat="server" Text="Rg:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtRg" Width="700px"  runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>
                <asp:Label ID="lblTelefone1" runat="server" Text="Telefone 1:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtTelefone1" Width="700px"  runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>
                <asp:Label ID="lblTelefone2" runat="server" Text="Telefone 2:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtTelefone2" Width="700px"  runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>
                <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtEmail" Width="700px"  runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>
                <asp:Label ID="lblObs" runat="server" Text="Obs:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtObs" Width="700px"  runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
        <td colspan="2" align="right">  <asp:Button ID="btnConfirmar" runat="server" 
                Text="Confirmar" onclick="btnConfirmar_Click" /></td>
        </tr>
    </table>
  
</asp:Content>
