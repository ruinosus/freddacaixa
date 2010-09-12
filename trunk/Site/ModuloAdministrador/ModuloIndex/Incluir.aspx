<%@ Page Title="" Language="C#" MasterPageFile="~/ModuloAdministrador/MasterPageAdministrador.master"
    AutoEventWireup="true" CodeFile="Incluir.aspx.cs" Inherits="ModuloAdministrador_ModuloIndex_Incluir" %>



<%@ Register assembly="Infragistics4.WebUI.WebHtmlEditor.v10.2, Version=10.2.20102.1011, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb" namespace="Infragistics.WebUI.WebHtmlEditor" tagprefix="ighedit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHeader" runat="Server">
    Incluir Conteúdo do Index
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
                <asp:Label ID="lblSubTitulo" runat="server" Text="Sub Título:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtSubTitulo" Width="700px"  runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblCorpo" runat="server" Text="Corpo:"></asp:Label>
            </td>
            <td>
                <ighedit:WebHtmlEditor ID="WebHtmlEditorCorpo" runat="server" Width="705px" 
                    Height="10px" FontFormattingList="Heading 1=&lt;h1&gt;&amp;Heading 2=&lt;h2&gt;&amp;Heading 3=&lt;h3&gt;&amp;Heading 4=&lt;h4&gt;&amp;Heading 5=&lt;h5&gt;&amp;Normal=&lt;p&gt;"
                    FontNameList="Arial,Verdana,Tahoma,Courier New,Georgia" FontSizeList="1,2,3,4,5,6,7"
                    FontStyleList="Blue Underline=color:blue;text-decoration:underline;&amp;Red Bold=color:red;font-weight:bold;&amp;ALL CAPS=text-transform:uppercase;&amp;all lowercase=text-transform:lowercase;&amp;Reset="
                    
                    
                    SpecialCharacterList="&amp;#937;,&amp;#931;,&amp;#916;,&amp;#934;,&amp;#915;,&amp;#936;,&amp;#928;,&amp;#920;,&amp;#926;,&amp;#923;,&amp;#958;,&amp;#956;,&amp;#951;,&amp;#966;,&amp;#969;,&amp;#949;,&amp;#952;,&amp;#948;,&amp;#950;,&amp;#968;,&amp;#946;,&amp;#960;,&amp;#963;,&amp;szlig;,&amp;thorn;,&amp;THORN;,&amp;#402,&amp;#1046;,&amp;#1064;,&amp;#1070;,&amp;#1071;,&amp;#1078;,&amp;#1092;,&amp;#1096;,&amp;#1102;,&amp;#1103;,&amp;#12362;,&amp;#12354;,&amp;#32117;,&amp;AElig;,&amp;Aring;,&amp;Ccedil;,&amp;ETH;,&amp;Ntilde;,&amp;Ouml;,&amp;aelig;,&amp;aring;,&amp;atilde;,&amp;ccedil;,&amp;eth;,&amp;euml;,&amp;ntilde;,&amp;cent;,&amp;pound;,&amp;curren;,&amp;yen;,&amp;#8470;,&amp;#153;,&amp;copy;,&amp;reg;,&amp;#151;,@,&amp;#149;,&amp;iexcl;,&amp;#14;,&amp;#8592;,&amp;#8593;,&amp;#8594;,&amp;#8595;,&amp;#8596;,&amp;#8597;,&amp;#8598;,&amp;#8599;,&amp;#8600;,&amp;#8601;,&amp;#18;,&amp;brvbar;,&amp;sect;,&amp;uml;,&amp;ordf;,&amp;not;,&amp;macr;,&amp;para;,&amp;deg;,&amp;plusmn;,&amp;laquo;,&amp;raquo;,&amp;middot;,&amp;cedil;,&amp;ordm;,&amp;sup1;,&amp;sup2;,&amp;sup3;,&amp;frac14;,&amp;frac12;,&amp;frac34;,&amp;iquest;,&amp;times;,&amp;divide;" 
                    Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                    Font-Strikeout="False" Font-Underline="False" 
                    ImageDirectory="~/ig_res/Default/images/htmleditor/" 
                    UploadedFilesDirectory="~/ig_res/upload">
                    <ProgressBar Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                        Font-Strikeout="False" Font-Underline="False" />
                    <RightClickMenu Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                        Font-Strikeout="False" Font-Underline="False">
                        <ighedit:HtmlBoxMenuItem runat="server" Act="Cut" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False">
                            <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                Font-Strikeout="False" Font-Underline="False" />
                        </ighedit:HtmlBoxMenuItem>
                        <ighedit:HtmlBoxMenuItem runat="server" Act="Copy" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False">
                            <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                Font-Strikeout="False" Font-Underline="False" />
                        </ighedit:HtmlBoxMenuItem>
                        <ighedit:HtmlBoxMenuItem runat="server" Act="Paste" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False">
                            <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                Font-Strikeout="False" Font-Underline="False" />
                        </ighedit:HtmlBoxMenuItem>
                        <ighedit:HtmlBoxMenuItem runat="server" Act="PasteHtml" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False">
                            <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                Font-Strikeout="False" Font-Underline="False" />
                        </ighedit:HtmlBoxMenuItem>
                        <ighedit:HtmlBoxMenuItem runat="server" Act="CellProperties" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False">
                            <Dialog InternalDialogType="CellProperties" Font-Bold="False" 
                                Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                                Font-Underline="False"></Dialog>
                        </ighedit:HtmlBoxMenuItem>
                        <ighedit:HtmlBoxMenuItem runat="server" Act="TableProperties" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False">
                            <Dialog InternalDialogType="ModifyTable" Font-Bold="False" Font-Italic="False" 
                                Font-Overline="False" Font-Strikeout="False" Font-Underline="False"></Dialog>
                        </ighedit:HtmlBoxMenuItem>
                        <ighedit:HtmlBoxMenuItem runat="server" Act="InsertImage" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False">
                            <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                Font-Strikeout="False" Font-Underline="False" />
                        </ighedit:HtmlBoxMenuItem>
                    </RightClickMenu>
                    <DownlevelLabel Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                        Font-Strikeout="False" Font-Underline="False" />
                    <DownlevelTextArea Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                        Font-Strikeout="False" Font-Underline="False" />
                    <TabStrip Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                        Font-Strikeout="False" Font-Underline="False" />
                    <Toolbar Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                        Font-Strikeout="False" Font-Underline="False">
                        <ighedit:ToolbarImage runat="server" Type="DoubleSeparator" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False"></ighedit:ToolbarImage>
                        <ighedit:ToolbarButton runat="server" Type="Bold" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False"></ighedit:ToolbarButton>
                        <ighedit:ToolbarButton runat="server" Type="Italic" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False"></ighedit:ToolbarButton>
                        <ighedit:ToolbarButton runat="server" Type="Underline" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False"></ighedit:ToolbarButton>
                        <ighedit:ToolbarButton runat="server" Type="Strikethrough" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False"></ighedit:ToolbarButton>
                        <ighedit:ToolbarImage runat="server" Type="Separator" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False"></ighedit:ToolbarImage>
                        <ighedit:ToolbarButton runat="server" Type="Subscript" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False"></ighedit:ToolbarButton>
                        <ighedit:ToolbarButton runat="server" Type="Superscript" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False"></ighedit:ToolbarButton>
                        <ighedit:ToolbarImage runat="server" Type="Separator" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False"></ighedit:ToolbarImage>
                        <ighedit:ToolbarButton runat="server" Type="Cut" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False"></ighedit:ToolbarButton>
                        <ighedit:ToolbarButton runat="server" Type="Copy" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False"></ighedit:ToolbarButton>
                        <ighedit:ToolbarButton runat="server" Type="Paste" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False"></ighedit:ToolbarButton>
                        <ighedit:ToolbarImage runat="server" Type="Separator" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False"></ighedit:ToolbarImage>
                        <ighedit:ToolbarButton runat="server" Type="Undo" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False"></ighedit:ToolbarButton>
                        <ighedit:ToolbarButton runat="server" Type="Redo" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False"></ighedit:ToolbarButton>
                        <ighedit:ToolbarImage runat="server" Type="Separator" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False"></ighedit:ToolbarImage>
                        <ighedit:ToolbarButton runat="server" Type="JustifyLeft" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False"></ighedit:ToolbarButton>
                        <ighedit:ToolbarButton runat="server" Type="JustifyCenter" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False"></ighedit:ToolbarButton>
                        <ighedit:ToolbarButton runat="server" Type="JustifyRight" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False"></ighedit:ToolbarButton>
                        <ighedit:ToolbarButton runat="server" Type="JustifyFull" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False"></ighedit:ToolbarButton>
                        <ighedit:ToolbarImage runat="server" Type="Separator" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False"></ighedit:ToolbarImage>
                        <ighedit:ToolbarButton runat="server" Type="Indent" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False"></ighedit:ToolbarButton>
                        <ighedit:ToolbarButton runat="server" Type="Outdent" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False"></ighedit:ToolbarButton>
                        <ighedit:ToolbarImage runat="server" Type="Separator" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False"></ighedit:ToolbarImage>
                        <ighedit:ToolbarButton runat="server" Type="UnorderedList" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False"></ighedit:ToolbarButton>
                        <ighedit:ToolbarButton runat="server" Type="OrderedList" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False"></ighedit:ToolbarButton>
                        <ighedit:ToolbarImage runat="server" Type="Separator" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False"></ighedit:ToolbarImage>
                        <ighedit:ToolbarDialogButton runat="server" Type="InsertRule" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False">
                            <Dialog InternalDialogType="InsertRule" Font-Bold="False" Font-Italic="False" 
                                Font-Overline="False" Font-Strikeout="False" Font-Underline="False"></Dialog>
                        </ighedit:ToolbarDialogButton>
                        <ighedit:ToolbarImage runat="server" Type="RowSeparator" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False"></ighedit:ToolbarImage>
                        <ighedit:ToolbarImage runat="server" Type="DoubleSeparator" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False"></ighedit:ToolbarImage>
                        <ighedit:ToolbarDialogButton runat="server" Type="FontColor" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False">
                            <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                Font-Strikeout="False" Font-Underline="False" />
                        </ighedit:ToolbarDialogButton>
                        <ighedit:ToolbarDialogButton runat="server" Type="FontHighlight" 
                            Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                            Font-Strikeout="False" Font-Underline="False">
                            <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                Font-Strikeout="False" Font-Underline="False" />
                        </ighedit:ToolbarDialogButton>
                        <ighedit:ToolbarDialogButton runat="server" Type="SpecialCharacter" 
                            Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                            Font-Strikeout="False" Font-Underline="False">
                            <Dialog InternalDialogType="SpecialCharacterPicker" Type="InternalWindow" 
                                Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                Font-Strikeout="False" Font-Underline="False"></Dialog>
                        </ighedit:ToolbarDialogButton>
                        <ighedit:ToolbarMenuButton runat="server" Type="InsertTable" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False">
                            <Menu Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                Font-Strikeout="False" Font-Underline="False">
                                <ighedit:HtmlBoxMenuItem runat="server" Act="TableProperties" Font-Bold="False" 
                                    Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                                    Font-Underline="False">
                                    <Dialog InternalDialogType="InsertTable" Font-Bold="False" Font-Italic="False" 
                                        Font-Overline="False" Font-Strikeout="False" Font-Underline="False"></Dialog>
                                </ighedit:HtmlBoxMenuItem>
                                <ighedit:HtmlBoxMenuItem runat="server" Act="InsertColumnRight" 
                                    Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                    Font-Strikeout="False" Font-Underline="False">
                                    <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                        Font-Strikeout="False" Font-Underline="False" />
                                </ighedit:HtmlBoxMenuItem>
                                <ighedit:HtmlBoxMenuItem runat="server" Act="InsertColumnLeft" 
                                    Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                    Font-Strikeout="False" Font-Underline="False">
                                    <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                        Font-Strikeout="False" Font-Underline="False" />
                                </ighedit:HtmlBoxMenuItem>
                                <ighedit:HtmlBoxMenuItem runat="server" Act="InsertRowAbove" Font-Bold="False" 
                                    Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                                    Font-Underline="False">
                                    <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                        Font-Strikeout="False" Font-Underline="False" />
                                </ighedit:HtmlBoxMenuItem>
                                <ighedit:HtmlBoxMenuItem runat="server" Act="InsertRowBelow" Font-Bold="False" 
                                    Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                                    Font-Underline="False">
                                    <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                        Font-Strikeout="False" Font-Underline="False" />
                                </ighedit:HtmlBoxMenuItem>
                                <ighedit:HtmlBoxMenuItem runat="server" Act="DeleteRow" Font-Bold="False" 
                                    Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                                    Font-Underline="False">
                                    <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                        Font-Strikeout="False" Font-Underline="False" />
                                </ighedit:HtmlBoxMenuItem>
                                <ighedit:HtmlBoxMenuItem runat="server" Act="DeleteColumn" Font-Bold="False" 
                                    Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                                    Font-Underline="False">
                                    <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                        Font-Strikeout="False" Font-Underline="False" />
                                </ighedit:HtmlBoxMenuItem>
                                <ighedit:HtmlBoxMenuItem runat="server" Act="IncreaseColspan" Font-Bold="False" 
                                    Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                                    Font-Underline="False">
                                    <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                        Font-Strikeout="False" Font-Underline="False" />
                                </ighedit:HtmlBoxMenuItem>
                                <ighedit:HtmlBoxMenuItem runat="server" Act="DecreaseColspan" Font-Bold="False" 
                                    Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                                    Font-Underline="False">
                                    <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                        Font-Strikeout="False" Font-Underline="False" />
                                </ighedit:HtmlBoxMenuItem>
                                <ighedit:HtmlBoxMenuItem runat="server" Act="IncreaseRowspan" Font-Bold="False" 
                                    Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                                    Font-Underline="False">
                                    <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                        Font-Strikeout="False" Font-Underline="False" />
                                </ighedit:HtmlBoxMenuItem>
                                <ighedit:HtmlBoxMenuItem runat="server" Act="DecreaseRowspan" Font-Bold="False" 
                                    Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                                    Font-Underline="False">
                                    <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                        Font-Strikeout="False" Font-Underline="False" />
                                </ighedit:HtmlBoxMenuItem>
                                <ighedit:HtmlBoxMenuItem runat="server" Act="CellProperties" Font-Bold="False" 
                                    Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                                    Font-Underline="False">
                                    <Dialog InternalDialogType="CellProperties" Font-Bold="False" 
                                        Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                                        Font-Underline="False"></Dialog>
                                </ighedit:HtmlBoxMenuItem>
                                <ighedit:HtmlBoxMenuItem runat="server" Act="TableProperties" Font-Bold="False" 
                                    Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                                    Font-Underline="False">
                                    <Dialog InternalDialogType="ModifyTable" Font-Bold="False" Font-Italic="False" 
                                        Font-Overline="False" Font-Strikeout="False" Font-Underline="False"></Dialog>
                                </ighedit:HtmlBoxMenuItem>
                            </Menu>
                        </ighedit:ToolbarMenuButton>
                        <ighedit:ToolbarButton runat="server" Type="ToggleBorders" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False"></ighedit:ToolbarButton>
                        <ighedit:ToolbarImage runat="server" Type="Separator" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False"></ighedit:ToolbarImage>
                        <ighedit:ToolbarButton runat="server" Type="InsertLink" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False"></ighedit:ToolbarButton>
                        <ighedit:ToolbarButton runat="server" Type="RemoveLink" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False"></ighedit:ToolbarButton>
                        <ighedit:ToolbarImage runat="server" Type="Separator" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False"></ighedit:ToolbarImage>
                        <ighedit:ToolbarButton runat="server" Type="Save" RaisePostback="True" 
                            Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                            Font-Strikeout="False" Font-Underline="False"></ighedit:ToolbarButton>
                        <ighedit:ToolbarUploadButton runat="server" Type="Open" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False">
                            <Upload Mode="File" Filter="*.htm,*.html,*.asp,*.aspx" Height="350px" 
                                Width="500px" Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                Font-Strikeout="False" Font-Underline="False">
                            </Upload>
                        </ighedit:ToolbarUploadButton>
                        <ighedit:ToolbarButton runat="server" Type="Preview" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False"></ighedit:ToolbarButton>
                        <ighedit:ToolbarImage runat="server" Type="Separator" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False"></ighedit:ToolbarImage>
                        <ighedit:ToolbarDialogButton runat="server" Type="FindReplace" 
                            Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                            Font-Strikeout="False" Font-Underline="False">
                            <Dialog InternalDialogType="FindReplace" Font-Bold="False" Font-Italic="False" 
                                Font-Overline="False" Font-Strikeout="False" Font-Underline="False"></Dialog>
                        </ighedit:ToolbarDialogButton>
                        <ighedit:ToolbarDialogButton runat="server" Type="InsertBookmark" 
                            Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                            Font-Strikeout="False" Font-Underline="False">
                            <Dialog InternalDialogType="InsertBookmark" Font-Bold="False" 
                                Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                                Font-Underline="False"></Dialog>
                        </ighedit:ToolbarDialogButton>
                        <ighedit:ToolbarUploadButton runat="server" Type="InsertImage" 
                            Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                            Font-Strikeout="False" Font-Underline="False">
                            <Upload Height="420px" Width="500px" Font-Bold="False" Font-Italic="False" 
                                Font-Overline="False" Font-Strikeout="False" Font-Underline="False"></Upload>
                        </ighedit:ToolbarUploadButton>
                        <ighedit:ToolbarUploadButton runat="server" Type="InsertFlash" 
                            Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                            Font-Strikeout="False" Font-Underline="False">
                            <Upload Mode="Flash" Filter="*.swf" Height="440px" Width="500px" 
                                Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                Font-Strikeout="False" Font-Underline="False"></Upload>
                        </ighedit:ToolbarUploadButton>
                        <ighedit:ToolbarUploadButton runat="server" Type="InsertWindowsMedia" 
                            Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                            Font-Strikeout="False" Font-Underline="False">
                            <Upload Mode="WindowsMedia" Filter="*.asf,*.wma,*.wmv,*.wm,*.avi,*.mpg,*.mpeg,*.m1v,*.mp2,*.mp3,*.mpa,*.mpe,*.mpv2,*.m3u,*.mid,*.midi,*.rmi,*.aif,*.aifc,*.aiff,*.au,*.snd,*.wav,*.cda,*.ivf"
                                Height="400px" Width="500px" Font-Bold="False" Font-Italic="False" 
                                Font-Overline="False" Font-Strikeout="False" Font-Underline="False"></Upload>
                        </ighedit:ToolbarUploadButton>
                        <ighedit:ToolbarDialogButton runat="server" Type="Help" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False">
                            <Dialog InternalDialogType="Text" Font-Bold="False" Font-Italic="False" 
                                Font-Overline="False" Font-Strikeout="False" Font-Underline="False"></Dialog>
                        </ighedit:ToolbarDialogButton>
                        <ighedit:ToolbarButton runat="server" Type="CleanWord" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False"></ighedit:ToolbarButton>
                        <ighedit:ToolbarButton runat="server" Type="WordCount" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False"></ighedit:ToolbarButton>
                        <ighedit:ToolbarButton runat="server" Type="PasteHtml" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False"></ighedit:ToolbarButton>
                        <ighedit:ToolbarMenuButton runat="server" Type="Zoom" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False">
                            <Menu Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                Font-Strikeout="False" Font-Underline="False">
                                <ighedit:HtmlBoxMenuItem runat="server" Act="Zoom25" Font-Bold="False" 
                                    Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                                    Font-Underline="False">
                                    <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                        Font-Strikeout="False" Font-Underline="False" />
                                </ighedit:HtmlBoxMenuItem>
                                <ighedit:HtmlBoxMenuItem runat="server" Act="Zoom50" Font-Bold="False" 
                                    Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                                    Font-Underline="False">
                                    <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                        Font-Strikeout="False" Font-Underline="False" />
                                </ighedit:HtmlBoxMenuItem>
                                <ighedit:HtmlBoxMenuItem runat="server" Act="Zoom75" Font-Bold="False" 
                                    Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                                    Font-Underline="False">
                                    <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                        Font-Strikeout="False" Font-Underline="False" />
                                </ighedit:HtmlBoxMenuItem>
                                <ighedit:HtmlBoxMenuItem runat="server" Act="Zoom100" Font-Bold="False" 
                                    Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                                    Font-Underline="False">
                                    <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                        Font-Strikeout="False" Font-Underline="False" />
                                </ighedit:HtmlBoxMenuItem>
                                <ighedit:HtmlBoxMenuItem runat="server" Act="Zoom200" Font-Bold="False" 
                                    Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                                    Font-Underline="False">
                                    <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                        Font-Strikeout="False" Font-Underline="False" />
                                </ighedit:HtmlBoxMenuItem>
                                <ighedit:HtmlBoxMenuItem runat="server" Act="Zoom300" Font-Bold="False" 
                                    Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                                    Font-Underline="False">
                                    <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                        Font-Strikeout="False" Font-Underline="False" />
                                </ighedit:HtmlBoxMenuItem>
                                <ighedit:HtmlBoxMenuItem runat="server" Act="Zoom400" Font-Bold="False" 
                                    Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                                    Font-Underline="False">
                                    <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                        Font-Strikeout="False" Font-Underline="False" />
                                </ighedit:HtmlBoxMenuItem>
                                <ighedit:HtmlBoxMenuItem runat="server" Act="Zoom500" Font-Bold="False" 
                                    Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                                    Font-Underline="False">
                                    <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                        Font-Strikeout="False" Font-Underline="False" />
                                </ighedit:HtmlBoxMenuItem>
                                <ighedit:HtmlBoxMenuItem runat="server" Act="Zoom600" Font-Bold="False" 
                                    Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                                    Font-Underline="False">
                                    <Dialog Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                                        Font-Strikeout="False" Font-Underline="False" />
                                </ighedit:HtmlBoxMenuItem>
                            </Menu>
                        </ighedit:ToolbarMenuButton>
                        <ighedit:ToolbarButton runat="server" Type="TogglePositioning" 
                            Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                            Font-Strikeout="False" Font-Underline="False"></ighedit:ToolbarButton>
                        <ighedit:ToolbarButton runat="server" Type="BringForward" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False"></ighedit:ToolbarButton>
                        <ighedit:ToolbarButton runat="server" Type="SendBackward" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False"></ighedit:ToolbarButton>
                        <ighedit:ToolbarImage runat="server" Type="RowSeparator" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False"></ighedit:ToolbarImage>
                        <ighedit:ToolbarImage runat="server" Type="DoubleSeparator" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False"></ighedit:ToolbarImage>
                        <ighedit:ToolbarDropDown runat="server" Type="FontName" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False">
                        </ighedit:ToolbarDropDown>
                        <ighedit:ToolbarDropDown runat="server" Type="FontSize" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False">
                        </ighedit:ToolbarDropDown>
                        <ighedit:ToolbarDropDown runat="server" Type="FontFormatting" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False">
                        </ighedit:ToolbarDropDown>
                        <ighedit:ToolbarDropDown runat="server" Type="FontStyle" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False">
                        </ighedit:ToolbarDropDown>
                        <ighedit:ToolbarDropDown runat="server" Type="Insert" Font-Bold="False" 
                            Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                            Font-Underline="False">
                            <Items>
                                <ighedit:ToolbarDropDownItem runat="server" Act="Greeting" Font-Bold="False" 
                                    Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                                    Font-Underline="False"></ighedit:ToolbarDropDownItem>
                                <ighedit:ToolbarDropDownItem runat="server" Act="Signature" Font-Bold="False" 
                                    Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                                    Font-Underline="False"></ighedit:ToolbarDropDownItem>
                            </Items>
                        </ighedit:ToolbarDropDown>
                    </Toolbar>
                    <TextWindow Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                        Font-Strikeout="False" Font-Underline="False" />
                    <DropDownStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" 
                        Font-Strikeout="False" Font-Underline="False" />
                </ighedit:WebHtmlEditor>
            </td>
        </tr>
        <tr>
        <td colspan="2" align="right">  <asp:Button ID="btnConfirmar" runat="server" 
                Text="Confirmar" onclick="btnConfirmar_Click" /></td>
        </tr>
    </table>
  
</asp:Content>
