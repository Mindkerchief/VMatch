using VMatch.Class;

namespace VMatch.Forms;
public partial class TabLayout : UserControl
{
    private ITabLayout tabLayoutInterface;
    private TabLayoutModel tabLayoutModel;

    public TabLayout(ITabLayout tabLayoutInterface, TabLayoutModel tabLayoutModel)
    {
        InitializeComponent();
        // Take the overriden Interface reference
        // As well as the TabLayoutModel that will populate this UserControl
        this.tabLayoutInterface = tabLayoutInterface;
        this.tabLayoutModel = tabLayoutModel;

        // Set Controls Text based on the TabLayoutModel recieved
        lblQuestionTitle.Text = tabLayoutModel.QuestionTitle;
        lblQuestion.Text = tabLayoutModel.Question;
    }

    private void btnSubmit_Click(object sender, EventArgs e)
    {
        // Answer Submission Part
        if (btnSubmit.Text == "ENTER")
        {
            if (txtBoxSubmit.Text.ToUpperInvariant() == tabLayoutModel.QuestionAnswer)
            {
                // Replace answered question with associate problem
                lblQuestionTitle.Text = tabLayoutModel.ProblemTitle;
                lblQuestion.Text = tabLayoutModel.Problem;

                // Change the Text of the bottom controls to adapt to the requirements
                txtBoxSubmit.Text = null;
                lblSubmitTitle.Text = "Submit:";
                btnSubmit.Text = "UPLOAD";

                tabLayoutInterface.logTime(tabLayoutModel.QuestionTitle + " Answer Time: ", false);
            }
            // This is a developer backdoor to exit the program during match
            else if (txtBoxSubmit.Text == "/close")
                Environment.Exit(0);
            else if (txtBoxSubmit.Text == "") { }
            else
                MessageBox.Show("Wrong Answer!", "Wrong!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        // File Submission Part
        else if (btnSubmit.Text == "UPLOAD")
        {
            try
            {
                OpenFileDialog uploadFileDialog;
                DialogResult dialogResult;
                string targetDirectory;

                // Kind of weird implementation but I dont want to mess with this yet
                (dialogResult, uploadFileDialog, targetDirectory) = openFile();

                if (dialogResult == DialogResult.Yes)
                {
                    File.Copy(uploadFileDialog.FileName, targetDirectory);
                    // Mark the problem as finished and log the event
                    tabLayoutModel.IsFinished = true;
                    tabLayoutInterface.logTime(tabLayoutModel.ProblemTitle + " Submitted Time: ", false);

                    // Remove the problem controls then show a new message as Submitted
                    lblQuestionTitle.Dispose();
                    lblQuestion.Dispose();
                    lblSubmitted.Text += tabLayoutInterface.getLiveTime();
                    lblSubmitted.Visible = true;
                    pnlSubmission.Dispose();
                }
            }   
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Every upload, check if all the questions are answered
            if (tabLayoutInterface.isProblemsFinished())
            {
                tabLayoutInterface.logTime("Time Finished: ", true);
                MessageBox.Show("Well done with the teamwork!,\nYou answered all the questions."
                    + "\nThank you for joining.", "Challenge Complete!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabLayoutInterface.attachClosingEvent();
            }
        }
    }

    private (DialogResult, OpenFileDialog, string) openFile()
    {
        OpenFileDialog uploadFileDialog = new OpenFileDialog();
        string targetDirectory = tabLayoutInterface.directoryPath;

        try
        {
            tabLayoutInterface.checkDirectory();

            if (uploadFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Update targetDirectory of the file to copy
                // By combining main directory and chosen file name
                targetDirectory += Path.GetFileName(uploadFileDialog.FileName);

                return (MessageBox.Show("Confirm uploading this file " 
                    + uploadFileDialog.FileName.Split('\\') [uploadFileDialog.FileName.Split('\\').Length - 1]
                    + "?", "Submit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question), 
                    uploadFileDialog, targetDirectory);
            }

            return (MessageBox.Show("Error!", "Error!", 
                MessageBoxButtons.OK, MessageBoxIcon.Error), uploadFileDialog, targetDirectory);
        }
        catch (Exception ex)
        {
            return (MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error), 
                uploadFileDialog, targetDirectory);
        }
    }

    private void txtBoxSubmit_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            btnSubmit.PerformClick();
        }
    }
}
