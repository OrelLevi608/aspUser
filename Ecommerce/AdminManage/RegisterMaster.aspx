<%@ Page Title="" Language="C#" MasterPageFile="~/AdminManage/BackAdmin.Master" AutoEventWireup="true" CodeBehind="RegisterMaster.aspx.cs" Inherits="Ecommerce.AdminManage.RegisterMaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Admin Register</title>
    <style>
        .register-container {
            background-color: #fff;
            padding: 20px 40px;
            border-radius: 10px;
            box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
            width: 400px;
            margin: 100px auto;
            text-align: center;
        }
        .input-box {
            width: 100%;
            padding: 10px;
            margin-bottom: 15px;
            border: 1px solid #ccc;
            border-radius: 5px;
            font-size: 14px;
        }
        .submit-button {
            width: 100%;
            padding: 10px;
            border: none;
            border-radius: 5px;
            background-color: #007bff;
            color: white;
            font-size: 16px;
            cursor: pointer;
        }
        .submit-button:hover {
            background-color: #0056b3;
        }
        .message-label {
            color: red;
            margin-top: 20px;
            font-size: 14px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="register-container">
    <div class="register-container">
        <h2>Admin Register</h2>
        <asp:TextBox ID="TxtFname" runat="server" CssClass="input-box" PlaceHolder="First Name"></asp:TextBox>
        <asp:TextBox ID="TxtLname" runat="server" CssClass="input-box" PlaceHolder="Last Name"></asp:TextBox>
        <asp:TextBox ID="TxtEmail" runat="server" CssClass="input-box" PlaceHolder="Email"></asp:TextBox>
        <asp:TextBox ID="TxtPassword" runat="server" CssClass="input-box" PlaceHolder="Password" TextMode="Password"></asp:TextBox>
        <asp:Button ID="button" runat="server" CssClass="submit-button" Text="Register" OnClick="button_Click" />
        <asp:Label ID="LtlMsg" runat="server" CssClass="message-label"></asp:Label>
    </div>
</asp:Content><asp:Content ID="Content3" ContentPlaceHolderID="FooterCnt" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="UnderfooterCnt" runat="server">
</asp:Content>
