using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /* Loads in data from previous page */
        string DoB = (string)Session["DoB"];
        HappyBirthdayLbl.Text = DoB;

        /* Wishes the user Happy Birthday if it is their birthday */
        if (DoB == DateTime.Now.ToString("dd/MM"))
        {
            HappyBirthdayLbl.Text = "HAPPY BIRTHDAY!";
        }
        else
        {
            HappyBirthdayLbl.Text = "";
        }

    }
    /* This method is used to clean the page ready for a new game */
    protected void New_Game(object sender, EventArgs e)
    {
        PlayAgainBtn.Visible = false;
        MoveRadioList.ClearSelection();
        WinningStatuslbl.Text = "";
        MoveStatuslbl.Text = "Awaiting move to be selected...";
        ComputerStatuslbl.Text = "The computer is thinking...";
        MoveRadioList.Visible = true;
        
    }
    /* Used to check if the player has won against the computers selection */
    protected void Move_Made(object sender, EventArgs e){
        /*Notifies the user which option they have selected */
        if (IsPostBack)
        {
            MoveStatuslbl.Text = "You've selected " + MoveRadioList.SelectedItem.Value + ".";
        }

        /* Randoms a number for the computers move */
        Random random = new Random();
        int computerSelection = random.Next(0, 4);

        /* Logic for all win, lose and draw. 
         * Shows the computer's move and into labels, Once a move has been selected it will show play again
         * Hides Radio buttons to prevent user from selecting another radio button
         * Updates database according result of the game
         */
        if (MoveRadioList.SelectedItem.Text == "Scissors")
        {
            /* If Computer Selects Paper */
            if (computerSelection == 1)
            {
                ComputerStatuslbl.Text = "The Computer has selected Paper!";
                WinningStatuslbl.Text = "You Win!";
                MoveRadioList.Visible = false;
                PlayAgainBtn.Visible = true;
                /* Updates Database */
                SqlDataScoreboard.UpdateCommand = "UPDATE [Table] SET Played = Played + 1, Won = Won + 1";
                SqlDataScoreboard.Update();

            }
            /* If Computer Selects Lizard */
            if (computerSelection == 3)
            {
                ComputerStatuslbl.Text = "The Computer has selected Lizard!";
                WinningStatuslbl.Text = "You Win!";
                PlayAgainBtn.Visible = true;
                MoveRadioList.Visible = false;
                /* Updates Database */
                SqlDataScoreboard.UpdateCommand = "UPDATE [Table] SET Played = Played + 1, Won = Won + 1";
                SqlDataScoreboard.Update();
             
            }
            /* If Computer Selects Scissors */
            if (computerSelection == 2)
            {
                ComputerStatuslbl.Text = "The Computer has selected Scissors!";
                WinningStatuslbl.Text = "You Drew!";
                PlayAgainBtn.Visible = true;
                MoveRadioList.Visible = false;
                /* Updates Database */
                SqlDataScoreboard.UpdateCommand = "UPDATE [Table] SET Played = Played + 1, Draw = Draw + 1";
                SqlDataScoreboard.Update();
            }
            /* If Computer Selects Rock */
            if (computerSelection == 0)
            {
                ComputerStatuslbl.Text = "The Computer has selected Rock!";
                WinningStatuslbl.Text = "You Lose!";
                PlayAgainBtn.Visible = true;
                MoveRadioList.Visible = false;
                /* Updates Database */
                SqlDataScoreboard.UpdateCommand = "UPDATE [Table] SET Played = Played + 1, Lost = Lost + 1";
                SqlDataScoreboard.Update();
            }
            /* If Computer Selects Rock */
            if (computerSelection == 4)
            {
                ComputerStatuslbl.Text = "The Computer has selected Spock!";
                WinningStatuslbl.Text = "You Lose!";
                PlayAgainBtn.Visible = true;
                MoveRadioList.Visible = false;
                /* Updates Database */
                SqlDataScoreboard.UpdateCommand = "UPDATE [Table] SET Played = Played + 1, Lost = Lost + 1";
                SqlDataScoreboard.Update();
            }

        }
        /* Rock Logic for Winning, Losing and Drawing */
        if (MoveRadioList.SelectedItem.Text == "Rock")
        {
            /* If Computer Selects Scissors */
            if (computerSelection == 2)
            {
                ComputerStatuslbl.Text = "The Computer has selected Scissors!";
                WinningStatuslbl.Text = "You Win!";
                PlayAgainBtn.Visible = true;
                MoveRadioList.Visible = false;
                /* Updates Database */
                SqlDataScoreboard.UpdateCommand = "UPDATE [Table] SET Played = Played + 1, Won = Won + 1";
                SqlDataScoreboard.Update();
            }
            /* If Computer Selects Lizard */
            if (computerSelection == 3)
            {
                ComputerStatuslbl.Text = "The Computer has selected Lizard!";
                WinningStatuslbl.Text = "You Win!";
                PlayAgainBtn.Visible = true;
                MoveRadioList.Visible = false;
                /* Updates Database */
                SqlDataScoreboard.UpdateCommand = "UPDATE [Table] SET Played = Played + 1, Won = Won + 1";
                SqlDataScoreboard.Update();
            }
            /* If Computer Selects Rock */
            if (computerSelection == 0)
            {
                ComputerStatuslbl.Text = "The Computer has selected Rock!";
                WinningStatuslbl.Text = "You Drew!";
                PlayAgainBtn.Visible = true;
                MoveRadioList.Visible = false;
                /* Updates Database */
                SqlDataScoreboard.UpdateCommand = "UPDATE [Table] SET Played = Played + 1, Draw = Draw + 1";
                SqlDataScoreboard.Update();
            }
            /* If Computer Selects Paper */
            if (computerSelection == 1)
            {
                ComputerStatuslbl.Text = "The Computer has selected Paper!";
                WinningStatuslbl.Text = "You Lose!";
                PlayAgainBtn.Visible = true;
                MoveRadioList.Visible = false;
                /* Updates Database */
                SqlDataScoreboard.UpdateCommand = "UPDATE [Table] SET Played = Played + 1, Lost = Lost + 1";
                SqlDataScoreboard.Update();

            }
            if (computerSelection == 4)
            {
                ComputerStatuslbl.Text = "The Computer has selected Spock!";
                WinningStatuslbl.Text = "You Lose!";
                PlayAgainBtn.Visible = true;
                MoveRadioList.Visible = false;
                /* Updates Database */
                SqlDataScoreboard.UpdateCommand = "UPDATE [Table] SET Played = Played + 1, Lost = Lost + 1";
                SqlDataScoreboard.Update();
            }

        }
        /* Paper Logic for Winning, Losing and Drawing */
        if (MoveRadioList.SelectedItem.Text == "Paper")
        {
            /* If Computer Selects Rock */
            if (computerSelection == 0)
            {
                ComputerStatuslbl.Text = "The Computer has selected Rock!";
                WinningStatuslbl.Text = "You Win!";
                PlayAgainBtn.Visible = true;
                MoveRadioList.Visible = false;
                /* Updates Database */
                SqlDataScoreboard.UpdateCommand = "UPDATE [Table] SET Played = Played + 1, Won = Won + 1";
                SqlDataScoreboard.Update();
            }
            if (computerSelection == 4)
            {
                ComputerStatuslbl.Text = "The Computer has selected Spock!";
                WinningStatuslbl.Text = "You Win!";
                PlayAgainBtn.Visible = true;
                MoveRadioList.Visible = false;
                /* Updates Database */
                SqlDataScoreboard.UpdateCommand = "UPDATE [Table] SET Played = Played + 1, Won = Won + 1";
                SqlDataScoreboard.Update();
            }
            /* If Computer Selects Paper */
            if (computerSelection == 1)
            {
                ComputerStatuslbl.Text = "The Computer has selected Paper!";
                WinningStatuslbl.Text = "You Drew!";
                PlayAgainBtn.Visible = true;
                MoveRadioList.Visible = false;
                /* Updates Database */
                SqlDataScoreboard.UpdateCommand = "UPDATE [Table] SET Played = Played + 1, Draw = Draw + 1";
                SqlDataScoreboard.Update();
            }
            /* If Computer Selects Scissors */
            if (computerSelection == 2)
            {
                ComputerStatuslbl.Text = "The Computer has selected Scissors!";
                WinningStatuslbl.Text = "You Lose!";
                PlayAgainBtn.Visible = true;
                MoveRadioList.Visible = false;
                /* Updates Database */
                SqlDataScoreboard.UpdateCommand = "UPDATE [Table] SET Played = Played + 1, Lost = Lost + 1";
                SqlDataScoreboard.Update();
            }
            /* If Computer Selects Lizard */
            if (computerSelection == 3)
            {
                ComputerStatuslbl.Text = "The Computer has selected Lizard!";
                WinningStatuslbl.Text = "You Lose!";
                PlayAgainBtn.Visible = true;
                MoveRadioList.Visible = false;
                /* Updates Database */
                SqlDataScoreboard.UpdateCommand = "UPDATE [Table] SET Played = Played + 1, Lost = Lost + 1";
                SqlDataScoreboard.Update();
            }

        }
        /* Lizard Logic for Winning, Losing and Drawing */
        if (MoveRadioList.SelectedItem.Text == "Lizard")
        {
            if (computerSelection == 4)
            {
                ComputerStatuslbl.Text = "The Computer has selected Spock!";
                WinningStatuslbl.Text = "You Win!";
                PlayAgainBtn.Visible = true;
                MoveRadioList.Visible = false;
                /* Updates Database */
                SqlDataScoreboard.UpdateCommand = "UPDATE [Table] SET Played = Played + 1, Won = Won + 1";
                SqlDataScoreboard.Update();
            }
            /* If Computer Selects Paper */
            if (computerSelection == 1)
            {
                ComputerStatuslbl.Text = "The Computer has selected Paper!";
                WinningStatuslbl.Text = "You Win!";
                PlayAgainBtn.Visible = true;
                MoveRadioList.Visible = false;
                /* Updates Database */
                SqlDataScoreboard.UpdateCommand = "UPDATE [Table] SET Played = Played + 1, Won = Won + 1";
                SqlDataScoreboard.Update();
            }
            /* If Computer Selects Lizard */
            if (computerSelection == 3)
            {
                ComputerStatuslbl.Text = "The Computer has selected Lizard!";
                WinningStatuslbl.Text = "You Drew!";
                PlayAgainBtn.Visible = true;
                MoveRadioList.Visible = false;
                /* Updates Database */
                SqlDataScoreboard.UpdateCommand = "UPDATE [Table] SET Played = Played + 1, Draw = Draw + 1";
                SqlDataScoreboard.Update();
            }
            /* If Computer Selects Rock */
            if (computerSelection == 0)
            {
                ComputerStatuslbl.Text = "The Computer has selected Rock!";
                WinningStatuslbl.Text = "You Lose!";
                PlayAgainBtn.Visible = true;
                MoveRadioList.Visible = false;
                /* Updates Database */
                SqlDataScoreboard.UpdateCommand = "UPDATE [Table] SET Played = Played + 1, Lost = Lost + 1";
                SqlDataScoreboard.Update();
            }
            /* If Computer Selects Scissors */
            if (computerSelection == 2)
            {
                ComputerStatuslbl.Text = "The Computer has selected Scissors!";
                WinningStatuslbl.Text = "You Lose!";
                PlayAgainBtn.Visible = true;
                MoveRadioList.Visible = false;
                /* Updates Database */
                SqlDataScoreboard.UpdateCommand = "UPDATE [Table] SET Played = Played + 1, Lost = Lost + 1";
                SqlDataScoreboard.Update();
            }

        }
        /* Spock Logic for Winning, Losing and Drawing */
        if (MoveRadioList.SelectedItem.Text == "Spock")
        {
            /* If Computer Selects Rock */
            if (computerSelection == 0)
            {
                ComputerStatuslbl.Text = "The Computer has selected Rock!";
                WinningStatuslbl.Text = "You Win!";
                PlayAgainBtn.Visible = true;
                MoveRadioList.Visible = false;
                /* Updates Database */
                SqlDataScoreboard.UpdateCommand = "UPDATE [Table] SET Played = Played + 1, Won = Won + 1";
                SqlDataScoreboard.Update();
            }
            /* If Computer Selects Scissors */
            if (computerSelection == 2)
            {
                ComputerStatuslbl.Text = "The Computer has selected Scissors!";
                WinningStatuslbl.Text = "You Win!";
                PlayAgainBtn.Visible = true;
                MoveRadioList.Visible = false;
                /* Updates Database */
                SqlDataScoreboard.UpdateCommand = "UPDATE [Table] SET Played = Played + 1, Won = Won + 1";
                SqlDataScoreboard.Update();
            }
            if (computerSelection == 4)
            {
                ComputerStatuslbl.Text = "The Computer has selected Spock!";
                WinningStatuslbl.Text = "You Drew!";
                PlayAgainBtn.Visible = true;
                MoveRadioList.Visible = false;
                /* Updates Database */
                SqlDataScoreboard.UpdateCommand = "UPDATE [Table] SET Played = Played + 1, Draw = Draw + 1";
                SqlDataScoreboard.Update();
            }
            /* If Computer Selects Paper */
            if (computerSelection == 1)
            {
                ComputerStatuslbl.Text = "The Computer has selected Paper!";
                WinningStatuslbl.Text = "You Lose!";
                PlayAgainBtn.Visible = true;
                MoveRadioList.Visible = false;
                /* Updates Database */
                SqlDataScoreboard.UpdateCommand = "UPDATE [Table] SET Played = Played + 1, Lost = Lost + 1";
                SqlDataScoreboard.Update();
            }
            /* If Computer Selects Lizard */
            if (computerSelection == 3)
            {
                ComputerStatuslbl.Text = "The Computer has selected Lizard!";
                WinningStatuslbl.Text = "You Lose!";
                PlayAgainBtn.Visible = true;
                MoveRadioList.Visible = false;
                /* Updates Database */
                SqlDataScoreboard.UpdateCommand = "UPDATE [Table] SET Played = Played + 1, Lost = Lost + 1";
                SqlDataScoreboard.Update();
            }
        }
    }
}