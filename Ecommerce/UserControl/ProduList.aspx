<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProduList.aspx.cs" Inherits="Ecommerce.UserControl.ProduList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product List</title>
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <asp:Repeater ID="RptProducts" runat="server">
                    <ItemTemplate>
                        <div class="col-md-3 mb-4">
                            <div class="card">
                                <img src='<%# ResolveUrl("~/uploads/pics/") + Eval("Picname") %>' class="card-img-top" alt="Product Image">
                                <div class="card-body">
                                    <h5 class="card-title"><%# Eval("Pname") %></h5>
                                    <p class="card-text">$<%# Eval("Price") %></p>
                                    <a href="#" class="btn btn-primary">Add To Cart</a>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </form>
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.5.4/dist/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
</body>
</html>
