<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="kassakvitto.Default"  ViewStateMode="Disabled"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kassakvitto</title>
    <link href="~/Content/Site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <h1>Kassakvitto</h1>
    <p>Total köpesummma:</p>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="Summa" runat="server"></asp:TextBox><p>kr</p>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Måste innehålla ett tal" Text="Du måste skriva i ett tal större än 0" Type="Double"  ControlToValidate="Summa" Operator="GreaterThan" ValueToCompare="0" Display="Dynamic"></asp:CompareValidator>
       
         <asp:Button ID="Sendbutton" runat="server" Text="Beräkna rabatt" />

        <div id="kvitto">
        <h2>DeVe</h2>
        <span class="italic">en del av EllenU</span>
            <div class="dotted">

            </div>
        </div>

    </div>
    </form>
</body>
</html>
