<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="Prod.aspx.cs" Inherits="Ecommerce.Prod" %>
<%@ Register Src="~/UserControl/ProductList.ascx" TagName="ProductList" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
    <div>
        <!-- פרטי המוצר הנבחר -->
        <h1>פרטי מוצר</h1>
        <!-- תוכן פרטי המוצר -->
    </div>
    <h2>מוצרים משלימים</h2>
    <uc1:ProductList ID="ComplementaryProducts" runat="server" MaxProducts="5" />
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FooterCnt" runat="server">
</asp:Content>
