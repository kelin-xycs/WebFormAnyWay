<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebFormAnyWay.WebForm1"
    ClientIDMode="Static" EnableViewState="false" %>
<%--  ClientIDMode="Static" 让控件的 ClientID 和 ID 一致，比如 UserControl 里的 控件。 --%>
<%--  EnableViewState="false" 禁用 ViewState， 我们不使用 Postback 事件， 所以不需要 ViewState。 
      没有 ViewState 可以减少页面内容， 提高网络传输速度。 总之 页面 变得 更 轻快。 --%>
<%@ Register TagPrefix="me" TagName="Header" Src="~/Header.ascx" %>
<%@ Register TagPrefix="me" TagName="Footer" Src="~/Footer.ascx" %>
<%@ Register TagPrefix="me" TagName="PersonGrid" Src="~/PersonGrid.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript" src="jquery-3.3.1.min.js"></script>
    <script type="text/javascript">

        function btnQuery_Click( btn )
        {
            $("#divLoading").html("<img style='width:100px;height:20px' src='loading.gif' />");
            $.get("WebForm1Action.aspx?action=Query", btnQuery_Click_c)
        }
        function btnQuery_Click_c( result )
        {
            $("#divPersonGrid").html(result);
            $("#divLoading").html("");
        }

        function btnUpdate_Click(btn)
        {
            $("#divLoading").html("<img style='width:100px;height:20px' src='loading.gif' />");
            $.get("WebForm1Action.aspx?action=Update", btnUpdate_Click_c)
        }
        function btnUpdate_Click_c(result)
        {
            $("#divPersonGrid").html(result);
            $("#divLoading").html("");

            alert("更新成功！");
        }

    </script>
</head>
<body>
    <form id="form1" runat="server">


        <me:Header runat="server"></me:Header>

        <div>
            这是  WebForm1
        </div>

        下面是一个 GridView  
        <br />

        <asp:GridView ID="gridView" runat="server" AlternatingRowStyle-BackColor="LightBlue" BorderStyle="Dotted" >
        </asp:GridView>

        <br />

        <input type="button" value="查询" onclick="btnQuery_Click(this);"/>
        <input type="button" value="更新" onclick="btnUpdate_Click(this);"/>

        <div id="divLoading"></div>
        <div id="divPersonGrid">
            <me:PersonGrid ID="personGrid" runat="server" />
        </div>


        <me:Footer runat="server"></me:Footer>
        
    </form>
</body>
</html>
