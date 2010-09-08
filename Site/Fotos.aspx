<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="Fotos.aspx.cs" Inherits="Fotos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="intro">
        <div class="pad">
            <p>
                <span class="style1">
                    <br>
                </span>
                <br />
            </p>
        </div>
    </div>
    <div class="mpart">
        <asp:GridView runat="server" ID="gridFotos" AutoGenerateColumns="false" BorderColor="White"
            BorderWidth="0px" EnableTheming="True">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <h3>
                            <asp:Label ID="lblTitulo" runat="server" Text='<%# Eval("Titulo") %>' />
                        </h3>
                        <p>
                            <asp:Image runat="server" ID="imgFoto" Height="200px" Width="300px" ImageUrl='<%# Eval("ImagemUrl") %>' />
                        </p>
                        <p>
                            <asp:Label ID="lblLegenda" runat="server" Text='<%# Eval("Legenda") %>' />
                        </p>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
