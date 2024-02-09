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
        lblProblemTitle.Text = tabLayoutModel.Problem;
        lblProblem.Text = tabLayoutModel.Problem;
    }

    private void btnSubmit_Click(object sender, EventArgs e)
    {
        if (btnSubmit.Text == "ENTER")
        {
            if (txtBoxSubmit.Text.ToUpperInvariant() == tabLayoutModel.QuestionAnswer)
            {
                lblQuestionTitle.Dispose();
                lblQuestion.Dispose();
                lblProblemTitle.Visible = true;
                lblProblem.Visible = true;

                lblSubmitTitle.Text = "FILE";
                btnSubmit.Text = "UPLOAD";
            }
            else
                MessageBox.Show("Wrong Answer!", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
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
                    submitTime(tabLayoutModel.QuestionTitle);

                    lblQuestionTitle.Visible = false;
                    lblQuestion.Visible = false;
                    lblSubmitted.Visible = true;
                    pnlSubmission.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (tabLayoutInterface.isQuestionsFinished())
            {
                submitTime("Time Finished");
            }
        }
    }

    public static (DialogResult, OpenFileDialog, string) submitFile()
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

                return (MessageBox.Show("Are you sure you want to upload this file " + uploadFileDialog.FileName.Split('\\')[uploadFileDialog.FileName.Split('\\').Length - 1] + " ?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question), uploadFileDialog, targetDirectory);
            }

            return (MessageBox.Show("There is an error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error), uploadFileDialog, targetDirectory);
        }
        catch (Exception ex)
        {
            return (MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error), uploadFileDialog, targetDirectory);
        }
    }

    public void submitTime(string subject)
    {
        try
        {
            string path = Path.Combine(@"~\answers\");

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            path = Path.Combine(@"~\answers\time.txt");

            if (!File.Exists(path))
                File.Create(path).Close();

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine($"{subject} Submitted time: {tabLayoutInterface.getLiveTime}");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
