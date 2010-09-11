<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="Contato.aspx.cs" Inherits="Contato" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table>
        <tr>
            <td>
                <asp:Label Text="Informe o seu nome:" runat="server" ID="lblNome" /><br />
                <asp:TextBox runat="server" ID="txtNome" Width="400px" />    <asp:RequiredFieldValidator ControlToValidate="txtNome" ErrorMessage="Informe o nome."
                ID ="RequiredFieldValidator1" runat="server" ToolTip="Informe o nome." ValidationGroup="contatoForm">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label Text="Informe o seu email:" runat="server" ID="lblEmail" /><br />
                <asp:TextBox runat="server" ID="txtEmail" Width="400px" />    <asp:RequiredFieldValidator ControlToValidate="txtEmail" ErrorMessage="Informe o email."
                ID ="EmailRequired" runat="server" ToolTip="Informe o email." ValidationGroup="contatoForm">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail"
                    ErrorMessage="Email inválido" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                    ValidationGroup="contatoForm"></asp:RegularExpressionValidator>
            
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label Text="Assunto da Mensagem:" runat="server" ID="lblAssunto" /><br />
                <asp:TextBox runat="server" ID="txtAssunto" Width="400px" />    <asp:RequiredFieldValidator ControlToValidate="txtAssunto" ErrorMessage="Informe o assunto."
                ID ="RequiredFieldValidator2" runat="server" ToolTip="Informe o assunto." ValidationGroup="contatoForm">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label Text="Digite sua Mensagem:" runat="server" ID="lblMensagem" /><br />
                <asp:TextBox runat="server" ID="txtMensagem" TextMode="MultiLine" Height="101px"
                    Width="400px" /> <asp:RequiredFieldValidator ControlToValidate="txtMensagem" ErrorMessage="Informe a mensagem."
                ID ="RequiredFieldValidator3" runat="server" ToolTip="Informe a mensagem." ValidationGroup="contatoForm">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:CheckBox Text="Desejo receber informações por email" Checked="false" runat="server" ID="ckbInformação" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button Text="Enviar" ID="btnEnviar" runat="server"  
                    ValidationGroup="contatoForm" onclick="btnEnviar_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
