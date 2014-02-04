<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="kassakvitto.Default"  ViewStateMode="Disabled"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kassakvitto</title>
    <link href="~/Content/Site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <div id="page">
    <h1>Kassakvitto</h1>
    <p>Total köpesummma:</p>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="Summa" runat="server"></asp:TextBox><p class ="pinline">kr</p>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Måste innehålla ett tal" Text="Du måste skriva i ett tal större än 0" Type="Double"  ControlToValidate="Summa" Operator="GreaterThan" ValueToCompare="0" Display="Dynamic"></asp:CompareValidator>
       
         <asp:Button ID="Sendbutton" runat="server" Text="Beräkna rabatt" OnClick="Sendbutton_Click" ViewStateMode="Enabled" />

        <div id="kvitto">
        <h2>DeVe</h2>
        <span class="italics">en del av EllenU</span>
        <p>Tel: 0722-28 80 00</p>
        <p>Öppettider 8-17</p>
           
           <div class="dotted">
               <asp:Label ID="Totalt" runat="server" Text=""></asp:Label>
               <asp:Label ID="Rabattsats" runat="server" Text=""></asp:Label>  
               <asp:Label ID="Rabatt" runat="server" Text=""></asp:Label>  
               <asp:Label ID="Slutsumma" runat="server" Text=""></asp:Label>  
           </div>
        </div>

    </div>
    </form>
    </div>
</body>
</html>
