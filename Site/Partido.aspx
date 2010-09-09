<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Partido.aspx.cs" Inherits="Partido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
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
        <asp:GridView ID="gridIndex" runat="server" AutoGenerateColumns="false" BorderColor="White"
            BorderWidth="0px" EnableTheming="True">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <h3>
                            <asp:Label ID="lblTitulo" runat="server" Text='<%# Eval("Titulo") %>' />
                        </h3>
                        <p>
                            <asp:Label ID="lblCorpo" runat="server" Text='<%# Eval("Corpo") %>' />
                        </p>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
       
    </div>
</asp:Content>

