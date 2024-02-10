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

                tabLayoutInterface.logTime(tabLayoutModel.QuestionTitle + " Answer Time: ", false);
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

                (dialogResult, uploadFileDialog, targetDirectory) = openFile();

                if (dialogResult == DialogResult.Yes)
                {
                    File.Copy(uploadFileDialog.FileName, targetDirectory);
                    lblSubmitted.Text += tabLayoutInterface.getLiveTime();
                    tabLayoutModel.IsFinished = true;
                    tabLayoutInterface.logTime(tabLayoutModel.ProblemTitle + " Submitted Time: ", false);

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
                tabLayoutInterface.logTime("Time Finished: ", true);
                MessageBox.Show("Well done! With the teamwork you have,\nyou answered all the questions."
                    + "\nThank you for joining");
                tabLayoutInterface.attachClosingEvent();
            }
        }
    }

    private (DialogResult, OpenFileDialog, string) openFile()
    {
        OpenFileDialog uploadFileDialog = new OpenFileDialog();
        string targetDirectory = tabLayoutInterface.directoryPath;
        tabLayoutInterface.checkDirectory();

        try
        {
            if (uploadFileDialog.ShowDialog() == DialogResult.OK)
            {
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

    private void txtBoxSubmit_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            btnSubmit.PerformClick();
        }
    }
}
