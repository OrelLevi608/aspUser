<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Ecommerce.Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <style>
        /* Reset default styles */
        body, h2, form, input, p, div, span, a {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
            font-family: Arial, sans-serif;
        }

        body {
            background-color: #f4f4f4;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }

        .login-container {
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

        .submit-button {
            width: 100%;
            padding: 10px;
            border: none;
            border-radius: 5px;
            background-color: #28a745;
            color: white;
            font-size: 16px;
            cursor: pointer;
        }

        .submit-button:hover {
            background-color: #218838;
        }

        .message-label {
            color: red;
            margin-top: 20px;
            font-size: 14px;
        }

        .forgot-password {
            display: block;
            margin-top: 10px;
            color: #007bff;
            text-decoration: none;
        }

        .forgot-password:hover {
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-container">
            <h2>Login</h2>
            <asp:TextBox ID="TxtEmail" runat="server" CssClass="input-box" PlaceHolder="Email"></asp:TextBox>
            <asp:TextBox ID="TxtPassword" runat="server" CssClass="input-box" PlaceHolder="Password" TextMode="Password"></asp:TextBox>
            <asp:Button ID="button" runat="server" CssClass="submit-button" Text="Submit" OnClick="button_Click" />
            <asp:Label ID="LtlMsg" runat="server" CssClass="message-label"></asp:Label>
            <a href="#" class="forgot-password">Forgot Password?</a>
        </div>
    </form>
</body>
</html>
