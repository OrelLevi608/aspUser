<%@ Page Title="" Language="C#" MasterPageFile="~/AdminManage/BackAdmin.Master" AutoEventWireup="true" CodeBehind="ProductsList.aspx.cs" Inherits="Ecommerce.AdminManage.ProductsList" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <h1 class="page-header">ניהול מוצרים</h1>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    מאגר מוצרים במערכת
                </div>
                <div class="panel-body">
                    <div class="table-responsive">
                        <table class="table table-striped table-bordered table-hover" id="MainTbl">
                            <thead>
                                <tr>
                                    <th>קוד מוצר</th>
                                    <th>שם מוצר</th>
                                    <th>מחיר</th>
                                    <th>תיאור</th>
                                    <th>תמונה ראשית</th>
                                    <th>ניהול</th>
                                </tr>
                            </thead>
                            <tbody>
                                <asp:Repeater ID="RptProducts" runat="server">
                                    <ItemTemplate>
                                        <tr class="odd gradeX">
                                            <td><%# Eval("Pid") %></td>
                                            <td><%# Eval("Pname") %></td>
                                            <td><%# Eval("Price") %></td>
                                            <td><%# Eval("Pdesc") %></td>
                                            <td class="center">
                                                <img src="/uploads/products/<%# Eval("Picname") %>" width="30"/>
                                            </td>
                                            <td><%# Eval("Cid") %></td>
                                            <td class="center">
                                                <asp:LinkButton ID="EditButton" runat="server" CommandArgument='<%# Eval("Pid") %>' OnClick="EditButton_Click">ערוך</asp:LinkButton>
                                                <asp:LinkButton ID="DeleteButton" runat="server" CommandArgument='<%# Eval("Pid") %>' OnClick="DeleteButton_Click" OnClientClick="return confirm('Are you sure you want to delete this product?');">מחק</asp:LinkButton>
                                            </td>
                                        </tr>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
