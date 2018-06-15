<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PersonGrid.ascx.cs" Inherits="WebFormAnyWay.PersonGrid" %>



<%--  ClientIDMode="Static" 让控件的 ClientID 和 ID 一致，比如 UserControl 里的 控件。 --%>

<asp:GridView ID="personGrid" runat="server" AlternatingRowStyle-BackColor="LightBlue" BorderStyle="Dotted"
     ClientIDMode="Static" >

</asp:GridView>