<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Ecommerce.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Registration</title>
    <style>
        /* Reset default styles */
        body, h2, form, input, select, textarea, p, div, span, a {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
            font-family: Arial, sans-serif;
        }

        body {
            background-color: #f4f4f4;
        }

        .register-container {
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }

        .register-box {
            background-color: #fff;
            padding: 20px 40px;
            border-radius: 10px;
            box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
            width: 400px;
            text-align: center;
        }

        h2 {
            margin-bottom: 20px;
            color: #333;
        }

        .input-box {
            width: 100%;
            padding: 10px;
            margin-bottom: 15px;
            border: 1px solid #ccc;
            border-radius: 5px;
            font-size: 14px;
        }

        .checkbox-container {
            display: flex;
            align-items: center;
            margin-bottom: 20px;
        }

        .checkbox-container span {
            margin-left: 10px;
            color: #555;
            font-size: 14px;
        }

        .terms-link {
            color: #007bff;
            text-decoration: none;
        }

        .terms-link:hover {
            text-decoration: underline;
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

<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
    <div class="register-container">
        <div class="register-box">
            <h2>Registration</h2>
            <asp:TextBox ID="TxtFname" runat="server" CssClass="input-box" PlaceHolder="First Name"></asp:TextBox>
            <asp:TextBox ID="TxtLname" runat="server" CssClass="input-box" PlaceHolder="Last Name"></asp:TextBox>
            <asp:TextBox ID="TxtEmail" runat="server" CssClass="input-box" PlaceHolder="Email"></asp:TextBox>
            <asp:TextBox ID="TxtPassword" runat="server" CssClass="input-box" PlaceHolder="Password" TextMode="Password"></asp:TextBox>
            <asp:TextBox ID="TxtPhone" runat="server" CssClass="input-box" PlaceHolder="Phone"></asp:TextBox>
            <asp:DropDownList ID="DDLCity" runat="server" CssClass="input-box">
                <asp:ListItem Value="City">Select City</asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="DDLCityCode" runat="server" CssClass="input-box">
                <asp:ListItem Value="City Code">Select City Code</asp:ListItem>
            </asp:DropDownList>
            <div class="checkbox-container">
                <asp:CheckBox ID="check1" runat="server" />
                <span>I Accept <a href="/Terms.aspx" class="terms-link">Terms Of Use</a></span>
            </div>
            <asp:Button ID="button" runat="server" CssClass="submit-button" Text="Submit" OnClick="button_Click" />
            <asp:Label ID="label" runat="server" CssClass="message-label"></asp:Label>
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FooterCnt" runat="server">
</asp:Content>
