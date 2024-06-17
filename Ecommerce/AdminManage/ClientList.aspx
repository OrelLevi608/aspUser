<%@ Page Title="" Language="C#" MasterPageFile="~/AdminManage/BackAdmin.Master" AutoEventWireup="true" CodeBehind="ClientList.aspx.cs" Inherits="Ecommerce.AdminManage.ClientList" %>


<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <h1 class="page-header">רשימת לקוחות</h1>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    מאגר לקוחות במערכת
                </div>
                <div class="panel-body">
                    <div class="table-responsive">
                        <table class="table table-striped table-bordered table-hover" id="MainTbl">
                            <thead>
                                <tr>
                                    <th>קוד משתמש</th>
                                    <th>שם פרטי</th>
                                    <th>שם משפחה</th>
                                    <th>עיר</th>
                                    <th>קוד עיר</th>
                                    <th>טלפון</th>
                                    <th>מייל</th>
                                    <th>תאריך הוספה</th>
                                    <th>ניהול</th>
                                </tr>
                            </thead>
                            <tbody>
                                <asp:Repeater ID="RptClient" runat="server">
                                    <ItemTemplate>
                                        <tr class="odd gradeX">
                                            <td><%#Eval("Uid") %></td>
                                            <td><%#Eval("FirstName") %></td>
                                            <td><%#Eval("LastName") %></td>
                                            <td><%#Eval("City") %></td>
                                            <td><%#Eval("CityCode") %></td>
                                            <td><%#Eval("Phone") %></td>
                                            <td><%#Eval("Email") %></td>
                                            <td><%#Eval("AddDate") %></td>
                                            <td class="center">
                                                <a href="ClientAddEdit.aspx?Uid=<%#Eval("Uid") %>">ערוך<span class="fa fa-pencil"></span></a>
                                                <a href="ClientList.aspx?delUid=<%#Eval("Uid") %>" onclick="return confirm('Are you sure you want to delete this client?');">מחק<span class="fa fa-trash"></span></a>
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
