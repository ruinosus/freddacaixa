<%@ Control Language="C#" AutoEventWireup="true" CodeFile="GaleriaSelecionar.ascx.cs" Inherits="ModuloAdministrador_ModuloGaleria_GaleriaSelecionar" %>
 <script language="javascript" type="text/javascript" src="../../js/validationScripts.js"></script>
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

    <table width="100%">
    <tr align="center">
        
        <td align="center">
            <asp:Label ID="lblTitulo" runat="server" Font-Bold="True" 
                                ForeColor="#0033CC" Text="Titulo:" Font-Names="Arial"></asp:Label>
            <asp:TextBox ID="txtTitulo" runat="server" Width="300px" ValidationGroup="AvisoDeErro"
                MaxLength="100" AssociatedControlID="btnPesquisar"></asp:TextBox>
            <asp:Button ID="btnPesquisar" runat="server" CssClass="botao" Font-Bold="True" ForeColor="#0033CC" OnClick="btnPesquisar_OnClick" Style="position: relative"
                Text="Pesquisar" TabGaleria="2" />
        </td>
    </tr>
    <tr>
        <td align="center" >
            <asp:GridView ID="GrdGaleria" runat="server" AutoGenerateColumns="False" AllowPaging="True"
                Width="100%" CellPadding="4" GridLines="None" OnPageGaleriaChanging="grdGaleria_PageGaleriaChanging"
                OnRowCreated="grdGaleria_RowCreated" OnPreRender="grdGaleria_PreRender" ForeColor="#333333" PageSize="9">
                <RowStyle BackColor="#EFF3FB" />
                <Columns>
                    <asp:TemplateField HeaderText="&amp;nbsp;">
                        <ItemTemplate>
                            <asp:RadioButton ID="idGaleria" runat="server" value='<%# Eval("ID") %>' onclick='<%# GetOnSelectEvent(Eval("ID"))%>' />
                        </ItemTemplate>
                        <ItemStyle HorizontalAlign="Center" Width="2%" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Título">
                        <ItemTemplate>
                            <asp:Label ID="lblTitulo" AssociatedControlID="idGaleria" runat="server" Text='<%# Eval("Titulo") %>' />
                        </ItemTemplate>
                        <ItemStyle HorizontalAlign="Center" Width="40%" />
                        <HeaderStyle HorizontalAlign="Center" />
                    </asp:TemplateField>
                   
                    
                </Columns>
                <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <EditRowStyle BackColor="#2461BF" />
                <AlternatingRowStyle BackColor="#DCDCDC" />
            </asp:GridView>
        </td>
    </tr>
</table>
