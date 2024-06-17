<%@ Page Title="" Language="C#" MasterPageFile="~/AdminManage/BackAdmin.Master" AutoEventWireup="true" CodeBehind="CategoryList.aspx.cs" Inherits="Ecommerce.AdminManage.CategoryList" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <h1 class="page-header">רשימת קטגוריות</h1>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    מאגר קטגוריות במערכת
                </div>
                <div class="panel-body">
                    <div class="table-responsive">
                        <table class="table table-striped table-bordered table-hover" id="MainTbl">
                            <thead>
                                <tr>
                                    <th>קוד קטגוריה</th>
                                    <th>שם קטגוריה</th>
                                    <th>תיאור</th>
                                    <th>תמונה ראשית</th>
                                    <th>תאריך הוספה</th>
                                    <th>ניהול</th>
                                </tr>
                            </thead>
                            <tbody>
                                <asp:Repeater ID="RptCat" runat="server">
                                    <ItemTemplate>
                                        <tr class="odd gradeX">
                                            <td><%#Eval("Cid") %></td>
                                            <td><%#Eval("Cname") %></td>
                                            <td><%#Eval("Cdesc") %></td>
                                            <td class="center"><img src="/Uploads/categories/<%#Eval("Picname") %>" width="30" /></td>
                                            <td><%#Eval("AddDate") %></td>
                                            <td class="center">
                                                <a href="CategoryAddEdit.aspx?Cid=<%#Eval("Cid") %>">ערוך<span class="fa fa-pencil"></span></a>
                                                <a href="CategoryList.aspx?delCid=<%#Eval("Cid") %>" onclick="return confirm('Are you sure you want to delete this category?');">מחק<span class="fa fa-trash"></span></a>
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
