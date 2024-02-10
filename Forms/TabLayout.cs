using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VMatch.Class;
using static System.Windows.Forms.DataFormats;

namespace VMatch.Forms;

public partial class TabLayout : UserControl
{
    private ITabLayout tabLayoutInterface;
    private TabLayoutModel tabLayoutModel;

    public TabLayout(ITabLayout tabLayoutInterface, TabLayoutModel tabLayoutModel)
    {
        InitializeComponent();
        this.tabLayoutInterface = tabLayoutInterface;
        this.tabLayoutModel = tabLayoutModel;

        lblQuestionTitle.Text = tabLayoutModel.QuestionTitle;
        lblQuestion.Text = tabLayoutModel.Question;
        lblProblemTitle.Text = tabLayoutModel.ProblemTitle;
        lblProblem.Text = tabLayoutModel.Problem;
    }

    private void btnSubmit_Click(object sender, EventArgs e)
    {
        // Answer Submission
        if (btnSubmit.Text == "ENTER")
        {
            if (txtBoxSubmit.Text.ToUpperInvariant() == tabLayoutModel.QuestionAnswer)
            {
                lblQuestionTitle.Dispose();
                lblQuestion.Dispose();
                lblProblemTitle.Visible = true;
                lblProblem.Visible = true;

                txtBoxSubmit.Text = "";
                lblSubmitTitle.Text = "Submit:";
                btnSubmit.Text = "UPLOAD";

                submitTime(tabLayoutModel.QuestionTitle + " Answer Time");
            }
            else
                MessageBox.Show("Wrong Answer!", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        // File Submission
        else if (btnSubmit.Text == "UPLOAD")
        {
            try
            {
                OpenFileDialog uploadFileDialog;
                DialogResult dialogResult;
                string targetDirectory;

                (dialogResult, uploadFileDialog, targetDirectory) = submitFile();

                if (dialogResult == DialogResult.Yes)
                {
                    File.Copy(uploadFileDialog.FileName, targetDirectory);
                    lblSubmitted.Text += tabLayoutInterface.getLiveTime();
                    tabLayoutModel.IsFinished = true;
                    submitTime(tabLayoutModel.ProblemTitle + " Submitted Time: ");

                    lblProblemTitle.Dispose();
                    lblProblem.Dispose();
                    lblSubmitted.Visible = true;
                    pnlSubmission.Dispose();
                }
            }   
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (tabLayoutInterface.isQuestionsFinished())
            {
                submitTime("Time Finished: ");
                MessageBox.Show("Well done! With the teamwork you have,\nyou answered all the questions."
                    + "\nThank you for joining");
                tabLayoutInterface.attachClosingEvent();
            }
        }
    }

    private (DialogResult, OpenFileDialog, string) submitFile()
    {
        OpenFileDialog uploadFileDialog = new OpenFileDialog();
        string targetDirectory = "";

        try
        {
            if (uploadFileDialog.ShowDialog() == DialogResult.OK)
            {
                targetDirectory = Path.Combine(@"~\answers\");

                if (!Directory.Exists(targetDirectory))
                {
                    // Create and restrict data access to directory
                    Directory.CreateDirectory(targetDirectory);
                    DirectoryInfo directoryInfo = new DirectoryInfo(targetDirectory);
                    DirectorySecurity directorySecurity = directoryInfo.GetAccessControl();
                    FileSystemAccessRule accessRule = new FileSystemAccessRule("Everyone",
                        FileSystemRights.ReadAndExecute, AccessControlType.Deny);

                    directorySecurity.AddAccessRule(accessRule);
                    directoryInfo.SetAccessControl(directorySecurity);
                }

                string fileName = Path.GetFileName(uploadFileDialog.FileName);
                targetDirectory += fileName;

                return (MessageBox.Show("Are you sure you want to upload this file " 
                    + uploadFileDialog.FileName.Split('\\') [uploadFileDialog.FileName.Split('\\').Length - 1]
                    + " ?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question), 
                    uploadFileDialog, targetDirectory);
            }

            return (MessageBox.Show("There is an error", "Error", 
                MessageBoxButtons.OK, MessageBoxIcon.Error), uploadFileDialog, targetDirectory);
        }
        catch (Exception ex)
        {
            return (MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error), 
                uploadFileDialog, targetDirectory);
        }
    }

    private void submitTime(string subject)
    {
        if (checkDirectory())
        {
            string targetDirectory = Path.Combine(@"~\answers\time.txt");

            using (StreamWriter streamWriter = File.AppendText(targetDirectory))
            {
                streamWriter.WriteLine(subject + tabLayoutInterface.getLiveTime());
            }
        }
    }

    private bool checkDirectory()
    {
        try
        {
            string targetDirectory = Path.Combine(@"~\answers\");

            if (!Directory.Exists(targetDirectory))
                Directory.CreateDirectory(targetDirectory);

            targetDirectory = Path.Combine(@"~\answers\time.txt");

            if (!File.Exists(targetDirectory))
                File.Create(targetDirectory).Close();
        }
        catch (Exception ex) 
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return true;
    }

    private void txtBoxSubmit_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            btnSubmit.PerformClick();
        }
    }
}
