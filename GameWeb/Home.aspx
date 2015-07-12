<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>RocK, Paper, Scissors, Lizard, Spock!</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
        <h1>Welcome Player!</h1>
        <asp:Label ID="CurrentdateLbl" runat="server" Text=""></asp:Label>
            <br />
        <asp:Label ID="DobLbl" runat="server" Text="Enter your date of birth (DD/MM/YYYY): "></asp:Label>
        <asp:TextBox ID="DayTxtbox" runat="server" Width="40px" MaxLength="2"></asp:TextBox>
        <asp:TextBox ID="MonthTxtbox" runat="server" Width="40px" MaxLength="2"></asp:TextBox>
        <asp:TextBox ID="YearTxtbox" runat="server" Width="80px" MaxLength="4"></asp:TextBox>
        <asp:Button ID="SubmitBtn" runat="server" Text="Submit" OnClick="SubmitBtn_Click"/>
            <br />
        </center>
    </div>
    </form>
</body>
</html>
