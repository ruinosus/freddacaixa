<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="Index.aspx.cs" Inherits="Index" %>

<%@ Register Assembly="Infragistics4.Web.v10.2, Version=10.2.20102.1011, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb"
    Namespace="Infragistics.Web.UI.ListControls" TagPrefix="ig" %>
<%@ Register Assembly="Infragistics4.Web.v10.2, Version=10.2.20102.1011, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb"
    Namespace="Infragistics.Web.UI.EditorControls" TagPrefix="ig" %>
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
        <ig:WebImageViewer ID="WebImageViewer1" Height="120px" Width="640px"
            runat="server" 
            onselectedindexchanged="WebImageViewer1_SelectedIndexChanged"><Templates></Templates>
           
            <ImageItemBinding   ImageUrlField="ImagemUrl" 
            />


           
        </ig:WebImageViewer>
    </div>
    

</asp:Content>
