<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Game.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>RocK, Paper, Scissors, Lizard, Spock!</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
        <h1>Lets Play...</h1>
        <asp:Label ID="HappyBirthdayLbl" runat="server" ForeColor="Red"></asp:Label>
        <p>Select A Move:</p><br />

        <asp:RadioButtonList ID="MoveRadioList" runat="server" RepeatDirection="Horizontal" AutoPostBack="True" OnSelectedIndexChanged="Move_Made">
            <asp:ListItem>Rock</asp:ListItem>
            <asp:ListItem>Paper</asp:ListItem>
            <asp:ListItem>Scissors</asp:ListItem>
            <asp:ListItem>Lizard</asp:ListItem>
            <asp:ListItem>Spock</asp:ListItem>
            </asp:RadioButtonList>

            <asp:Label ID="MoveStatuslbl" runat="server" Text="Awaiting move to be selected..."></asp:Label><br />
            <asp:Label ID="ComputerStatuslbl" runat="server" Text="The computer is thinking..."></asp:Label><br />
            <asp:Label ID="WinningStatuslbl" runat="server" ForeColor="Red"></asp:Label><br />

            <asp:Button ID="PlayAgainBtn" runat="server" Text="Play Again?" Visible="False" OnClick="New_Game"></asp:Button><br />

                <asp:SqlDataSource ID="SqlDataScoreboard" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Played], [Won], [Lost], [Draw] FROM [Table]">
                </asp:SqlDataSource>

                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataScoreboard">
                    <Columns>
                        <asp:BoundField DataField="Played" HeaderText="Played" SortExpression="Played" />
                        <asp:BoundField DataField="Won" HeaderText="Won" SortExpression="Won" />
                        <asp:BoundField DataField="Lost" HeaderText="Lost" SortExpression="Lost" />
                        <asp:BoundField DataField="Draw" HeaderText="Draw" SortExpression="Draw" />
                    </Columns>
                </asp:GridView>
            <p>
                <b>Rules:</b> <br />
                -----------------------------------------------------<br />
                · Scissors beats paper (because scissors cut paper). <br />
                · Paper beats rock (because you can wrap a rock with paper). <br />
                · Rock beats lizard (you can crush a lizard with a rock). <br />
                · Lizard beats Spock (because it poisons him). <br />
                · Spock beats scissors (because he smashes them) <br />
                · Scissors beats lizard (because it can cut it's head off). <br />
                · Lizard beats paper (because the lizard eats the paper)  <br />
                · Paper beats Spock (because it disproves him) <br />
                · Spock beats rock (because he vaporizes it). <br />
                · Rock beats scissors (because it blunts them). <br />
            </p>

        </center>
    </div>
    </form>
</body>
</html>
