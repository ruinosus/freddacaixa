<%@ Page Title="" Language="C#" MasterPageFile="~/ModuloAdministrador/MasterPageAdministrador.master"
    AutoEventWireup="true" CodeFile="Incluir.aspx.cs" Inherits="ModuloAdministrador_ModuloIndex_Incluir" %>

<%@ Register Assembly="Infragistics35.WebUI.WebHtmlEditor.v10.1, Version=10.1.20101.1011, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb"
    Namespace="Infragistics.WebUI.WebHtmlEditor" TagPrefix="ighedit" %>
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
                <ighedit:WebHtmlEditor ID="WebHtmlEditorCorpo" runat="server" Width="705px" Height="10px" FontFormattingList="Heading 1=&lt;h1&gt;&amp;Heading 2=&lt;h2&gt;&amp;Heading 3=&lt;h3&gt;&amp;Heading 4=&lt;h4&gt;&amp;Heading 5=&lt;h5&gt;&amp;Normal=&lt;p&gt;"
                    FontNameList="Arial,Verdana,Tahoma,Courier New,Georgia" FontSizeList="1,2,3,4,5,6,7"
                    FontStyleList="Blue Underline=color:blue;text-decoration:underline;&amp;Red Bold=color:red;font-weight:bold;&amp;ALL CAPS=text-transform:uppercase;&amp;all lowercase=text-transform:lowercase;&amp;Reset="
                    SpecialCharacterList="&amp;#937;,&amp;#931;,&amp;#916;,&amp;#934;,&amp;#915;,&amp;#936;,&amp;#928;,&amp;#920;,&amp;#926;,&amp;#923;,&amp;#958;,&amp;#956;,&amp;#951;,&amp;#966;,&amp;#969;,&amp;#949;,&amp;#952;,&amp;#948;,&amp;#950;,&amp;#968;,&amp;#946;,&amp;#960;,&amp;#963;,&amp;szlig;,&amp;thorn;,&amp;THORN;,&amp;#402,&amp;#1046;,&amp;#1064;,&amp;#1070;,&amp;#1071;,&amp;#1078;,&amp;#1092;,&amp;#1096;,&amp;#1102;,&amp;#1103;,&amp;#12362;,&amp;#12354;,&amp;#32117;,&amp;AElig;,&amp;Aring;,&amp;Ccedil;,&amp;ETH;,&amp;Ntilde;,&amp;Ouml;,&amp;aelig;,&amp;aring;,&amp;atilde;,&amp;ccedil;,&amp;eth;,&amp;euml;,&amp;ntilde;,&amp;cent;,&amp;pound;,&amp;curren;,&amp;yen;,&amp;#8470;,&amp;#153;,&amp;copy;,&amp;reg;,&amp;#151;,@,&amp;#149;,&amp;iexcl;,&amp;#14;,&amp;#8592;,&amp;#8593;,&amp;#8594;,&amp;#8595;,&amp;#8596;,&amp;#8597;,&amp;#8598;,&amp;#8599;,&amp;#8600;,&amp;#8601;,&amp;#18;,&amp;brvbar;,&amp;sect;,&amp;uml;,&amp;ordf;,&amp;not;,&amp;macr;,&amp;para;,&amp;deg;,&amp;plusmn;,&amp;laquo;,&amp;raquo;,&amp;middot;,&amp;cedil;,&amp;ordm;,&amp;sup1;,&amp;sup2;,&amp;sup3;,&amp;frac14;,&amp;frac12;,&amp;frac34;,&amp;iquest;,&amp;times;,&amp;divide;">
                    <RightClickMenu>
                        <ighedit:HtmlBoxMenuItem runat="server" Act="Cut">
                        </ighedit:HtmlBoxMenuItem>
                        <ighedit:HtmlBoxMenuItem runat="server" Act="Copy">
                        </ighedit:HtmlBoxMenuItem>
                        <ighedit:HtmlBoxMenuItem runat="server" Act="Paste">
                        </ighedit:HtmlBoxMenuItem>
                        <ighedit:HtmlBoxMenuItem runat="server" Act="PasteHtml">
                        </ighedit:HtmlBoxMenuItem>
                        <ighedit:HtmlBoxMenuItem runat="server" Act="CellProperties">
                            <Dialog InternalDialogType="CellProperties"></Dialog>
                        </ighedit:HtmlBoxMenuItem>
                        <ighedit:HtmlBoxMenuItem runat="server" Act="TableProperties">
                            <Dialog InternalDialogType="ModifyTable"></Dialog>
                        </ighedit:HtmlBoxMenuItem>
                        <ighedit:HtmlBoxMenuItem runat="server" Act="InsertImage">
                        </ighedit:HtmlBoxMenuItem>
                    </RightClickMenu>
                    <Toolbar>
                        <ighedit:ToolbarImage runat="server" Type="DoubleSeparator"></ighedit:ToolbarImage>
                        <ighedit:ToolbarButton runat="server" Type="Bold"></ighedit:ToolbarButton>
                        <ighedit:ToolbarButton runat="server" Type="Italic"></ighedit:ToolbarButton>
                        <ighedit:ToolbarButton runat="server" Type="Underline"></ighedit:ToolbarButton>
                        <ighedit:ToolbarButton runat="server" Type="Strikethrough"></ighedit:ToolbarButton>
                        <ighedit:ToolbarImage runat="server" Type="Separator"></ighedit:ToolbarImage>
                        <ighedit:ToolbarButton runat="server" Type="Subscript"></ighedit:ToolbarButton>
                        <ighedit:ToolbarButton runat="server" Type="Superscript"></ighedit:ToolbarButton>
                        <ighedit:ToolbarImage runat="server" Type="Separator"></ighedit:ToolbarImage>
                        <ighedit:ToolbarButton runat="server" Type="Cut"></ighedit:ToolbarButton>
                        <ighedit:ToolbarButton runat="server" Type="Copy"></ighedit:ToolbarButton>
                        <ighedit:ToolbarButton runat="server" Type="Paste"></ighedit:ToolbarButton>
                        <ighedit:ToolbarImage runat="server" Type="Separator"></ighedit:ToolbarImage>
                        <ighedit:ToolbarButton runat="server" Type="Undo"></ighedit:ToolbarButton>
                        <ighedit:ToolbarButton runat="server" Type="Redo"></ighedit:ToolbarButton>
                        <ighedit:ToolbarImage runat="server" Type="Separator"></ighedit:ToolbarImage>
                        <ighedit:ToolbarButton runat="server" Type="JustifyLeft"></ighedit:ToolbarButton>
                        <ighedit:ToolbarButton runat="server" Type="JustifyCenter"></ighedit:ToolbarButton>
                        <ighedit:ToolbarButton runat="server" Type="JustifyRight"></ighedit:ToolbarButton>
                        <ighedit:ToolbarButton runat="server" Type="JustifyFull"></ighedit:ToolbarButton>
                        <ighedit:ToolbarImage runat="server" Type="Separator"></ighedit:ToolbarImage>
                        <ighedit:ToolbarButton runat="server" Type="Indent"></ighedit:ToolbarButton>
                        <ighedit:ToolbarButton runat="server" Type="Outdent"></ighedit:ToolbarButton>
                        <ighedit:ToolbarImage runat="server" Type="Separator"></ighedit:ToolbarImage>
                        <ighedit:ToolbarButton runat="server" Type="UnorderedList"></ighedit:ToolbarButton>
                        <ighedit:ToolbarButton runat="server" Type="OrderedList"></ighedit:ToolbarButton>
                        <ighedit:ToolbarImage runat="server" Type="Separator"></ighedit:ToolbarImage>
                        <ighedit:ToolbarDialogButton runat="server" Type="InsertRule">
                            <Dialog InternalDialogType="InsertRule"></Dialog>
                        </ighedit:ToolbarDialogButton>
                        <ighedit:ToolbarImage runat="server" Type="RowSeparator"></ighedit:ToolbarImage>
                        <ighedit:ToolbarImage runat="server" Type="DoubleSeparator"></ighedit:ToolbarImage>
                        <ighedit:ToolbarDialogButton runat="server" Type="FontColor">
                        </ighedit:ToolbarDialogButton>
                        <ighedit:ToolbarDialogButton runat="server" Type="FontHighlight">
                        </ighedit:ToolbarDialogButton>
                        <ighedit:ToolbarDialogButton runat="server" Type="SpecialCharacter">
                            <Dialog InternalDialogType="SpecialCharacterPicker" Type="InternalWindow"></Dialog>
                        </ighedit:ToolbarDialogButton>
                        <ighedit:ToolbarMenuButton runat="server" Type="InsertTable">
                            <Menu>
                                <ighedit:HtmlBoxMenuItem runat="server" Act="TableProperties">
                                    <Dialog InternalDialogType="InsertTable"></Dialog>
                                </ighedit:HtmlBoxMenuItem>
                                <ighedit:HtmlBoxMenuItem runat="server" Act="InsertColumnRight">
                                </ighedit:HtmlBoxMenuItem>
                                <ighedit:HtmlBoxMenuItem runat="server" Act="InsertColumnLeft">
                                </ighedit:HtmlBoxMenuItem>
                                <ighedit:HtmlBoxMenuItem runat="server" Act="InsertRowAbove">
                                </ighedit:HtmlBoxMenuItem>
                                <ighedit:HtmlBoxMenuItem runat="server" Act="InsertRowBelow">
                                </ighedit:HtmlBoxMenuItem>
                                <ighedit:HtmlBoxMenuItem runat="server" Act="DeleteRow">
                                </ighedit:HtmlBoxMenuItem>
                                <ighedit:HtmlBoxMenuItem runat="server" Act="DeleteColumn">
                                </ighedit:HtmlBoxMenuItem>
                                <ighedit:HtmlBoxMenuItem runat="server" Act="IncreaseColspan">
                                </ighedit:HtmlBoxMenuItem>
                                <ighedit:HtmlBoxMenuItem runat="server" Act="DecreaseColspan">
                                </ighedit:HtmlBoxMenuItem>
                                <ighedit:HtmlBoxMenuItem runat="server" Act="IncreaseRowspan">
                                </ighedit:HtmlBoxMenuItem>
                                <ighedit:HtmlBoxMenuItem runat="server" Act="DecreaseRowspan">
                                </ighedit:HtmlBoxMenuItem>
                                <ighedit:HtmlBoxMenuItem runat="server" Act="CellProperties">
                                    <Dialog InternalDialogType="CellProperties"></Dialog>
                                </ighedit:HtmlBoxMenuItem>
                                <ighedit:HtmlBoxMenuItem runat="server" Act="TableProperties">
                                    <Dialog InternalDialogType="ModifyTable"></Dialog>
                                </ighedit:HtmlBoxMenuItem>
                            </Menu>
                        </ighedit:ToolbarMenuButton>
                        <ighedit:ToolbarButton runat="server" Type="ToggleBorders"></ighedit:ToolbarButton>
                        <ighedit:ToolbarImage runat="server" Type="Separator"></ighedit:ToolbarImage>
                        <ighedit:ToolbarButton runat="server" Type="InsertLink"></ighedit:ToolbarButton>
                        <ighedit:ToolbarButton runat="server" Type="RemoveLink"></ighedit:ToolbarButton>
                        <ighedit:ToolbarImage runat="server" Type="Separator"></ighedit:ToolbarImage>
                        <ighedit:ToolbarButton runat="server" Type="Save" RaisePostback="True"></ighedit:ToolbarButton>
                        <ighedit:ToolbarUploadButton runat="server" Type="Open">
                            <Upload Mode="File" Filter="*.htm,*.html,*.asp,*.aspx" Height="350px" Width="500px">
                            </Upload>
                        </ighedit:ToolbarUploadButton>
                        <ighedit:ToolbarButton runat="server" Type="Preview"></ighedit:ToolbarButton>
                        <ighedit:ToolbarImage runat="server" Type="Separator"></ighedit:ToolbarImage>
                        <ighedit:ToolbarDialogButton runat="server" Type="FindReplace">
                            <Dialog InternalDialogType="FindReplace"></Dialog>
                        </ighedit:ToolbarDialogButton>
                        <ighedit:ToolbarDialogButton runat="server" Type="InsertBookmark">
                            <Dialog InternalDialogType="InsertBookmark"></Dialog>
                        </ighedit:ToolbarDialogButton>
                        <ighedit:ToolbarUploadButton runat="server" Type="InsertImage">
                            <Upload Height="420px" Width="500px"></Upload>
                        </ighedit:ToolbarUploadButton>
                        <ighedit:ToolbarUploadButton runat="server" Type="InsertFlash">
                            <Upload Mode="Flash" Filter="*.swf" Height="440px" Width="500px"></Upload>
                        </ighedit:ToolbarUploadButton>
                        <ighedit:ToolbarUploadButton runat="server" Type="InsertWindowsMedia">
                            <Upload Mode="WindowsMedia" Filter="*.asf,*.wma,*.wmv,*.wm,*.avi,*.mpg,*.mpeg,*.m1v,*.mp2,*.mp3,*.mpa,*.mpe,*.mpv2,*.m3u,*.mid,*.midi,*.rmi,*.aif,*.aifc,*.aiff,*.au,*.snd,*.wav,*.cda,*.ivf"
                                Height="400px" Width="500px"></Upload>
                        </ighedit:ToolbarUploadButton>
                        <ighedit:ToolbarDialogButton runat="server" Type="Help">
                            <Dialog InternalDialogType="Text"></Dialog>
                        </ighedit:ToolbarDialogButton>
                        <ighedit:ToolbarButton runat="server" Type="CleanWord"></ighedit:ToolbarButton>
                        <ighedit:ToolbarButton runat="server" Type="WordCount"></ighedit:ToolbarButton>
                        <ighedit:ToolbarButton runat="server" Type="PasteHtml"></ighedit:ToolbarButton>
                        <ighedit:ToolbarMenuButton runat="server" Type="Zoom">
                            <Menu>
                                <ighedit:HtmlBoxMenuItem runat="server" Act="Zoom25">
                                </ighedit:HtmlBoxMenuItem>
                                <ighedit:HtmlBoxMenuItem runat="server" Act="Zoom50">
                                </ighedit:HtmlBoxMenuItem>
                                <ighedit:HtmlBoxMenuItem runat="server" Act="Zoom75">
                                </ighedit:HtmlBoxMenuItem>
                                <ighedit:HtmlBoxMenuItem runat="server" Act="Zoom100">
                                </ighedit:HtmlBoxMenuItem>
                                <ighedit:HtmlBoxMenuItem runat="server" Act="Zoom200">
                                </ighedit:HtmlBoxMenuItem>
                                <ighedit:HtmlBoxMenuItem runat="server" Act="Zoom300">
                                </ighedit:HtmlBoxMenuItem>
                                <ighedit:HtmlBoxMenuItem runat="server" Act="Zoom400">
                                </ighedit:HtmlBoxMenuItem>
                                <ighedit:HtmlBoxMenuItem runat="server" Act="Zoom500">
                                </ighedit:HtmlBoxMenuItem>
                                <ighedit:HtmlBoxMenuItem runat="server" Act="Zoom600">
                                </ighedit:HtmlBoxMenuItem>
                            </Menu>
                        </ighedit:ToolbarMenuButton>
                        <ighedit:ToolbarButton runat="server" Type="TogglePositioning"></ighedit:ToolbarButton>
                        <ighedit:ToolbarButton runat="server" Type="BringForward"></ighedit:ToolbarButton>
                        <ighedit:ToolbarButton runat="server" Type="SendBackward"></ighedit:ToolbarButton>
                        <ighedit:ToolbarImage runat="server" Type="RowSeparator"></ighedit:ToolbarImage>
                        <ighedit:ToolbarImage runat="server" Type="DoubleSeparator"></ighedit:ToolbarImage>
                        <ighedit:ToolbarDropDown runat="server" Type="FontName">
                        </ighedit:ToolbarDropDown>
                        <ighedit:ToolbarDropDown runat="server" Type="FontSize">
                        </ighedit:ToolbarDropDown>
                        <ighedit:ToolbarDropDown runat="server" Type="FontFormatting">
                        </ighedit:ToolbarDropDown>
                        <ighedit:ToolbarDropDown runat="server" Type="FontStyle">
                        </ighedit:ToolbarDropDown>
                        <ighedit:ToolbarDropDown runat="server" Type="Insert">
                            <Items>
                                <ighedit:ToolbarDropDownItem runat="server" Act="Greeting"></ighedit:ToolbarDropDownItem>
                                <ighedit:ToolbarDropDownItem runat="server" Act="Signature"></ighedit:ToolbarDropDownItem>
                            </Items>
                        </ighedit:ToolbarDropDown>
                    </Toolbar>
                </ighedit:WebHtmlEditor>
            </td>
        </tr>
        <tr>
        <td colspan="2" align="right">  <asp:Button ID="btnConfirmar" runat="server" 
                Text="Confirmar" onclick="btnConfirmar_Click" /></td>
        </tr>
    </table>
  
</asp:Content>
