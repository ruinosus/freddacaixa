<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="Index.aspx.cs" Inherits="Index" %>

<%@ Register Assembly="Infragistics35.Web.v10.1, Version=10.1.20101.1011, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb"
    Namespace="Infragistics.Web.UI.ListControls" TagPrefix="ig" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
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
        <asp:GridView ID="gridIndex" runat="server" AutoGenerateColumns="false" 
            BorderColor="White" BorderWidth="0px" EnableTheming="True">
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
    <ig:WebImageViewer ID="WebImageViewer1" runat="server" Width="650px" Height="150px">
<PreviousButton AltText="Previous Button"></PreviousButton>

        <Header Visible="true" Text="Imagens">
        </Header>

<NextButton AltText="Next Button"></NextButton>
    </ig:WebImageViewer>
    
</asp:Content>
