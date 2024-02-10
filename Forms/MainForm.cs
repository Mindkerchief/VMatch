using System.Collections;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using VMatch.Class;
using VMatch.Forms;

namespace VMatch;

public partial class MainForm : Form, ITabLayout
{
    private List<TabLayoutModel> tabLayoutModels;
    //private int hours = 2, minutes = 59, seconds = 60;
    private int hours = 0, minutes = 00, seconds = 05;
    private Point mouseOffset;
    private bool isMouseDown = false;

    public MainForm()
    {
        InitializeComponent();

        if (!checkDirectory())
        {
            btnStartTimer.Enabled = false;
            btnClose.Visible = true;
            btnClose.Click += btnClose_Click;
        }
        else
            tabLayoutModels = new SetupModel().setupTabLayoutModel();
    }

    public bool checkDirectory()
    {
        try
        {
            if (!Directory.Exists(directoryPath))
            {
                // Create and restrict data access to directory
                Directory.CreateDirectory(directoryPath);
                DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);
                DirectorySecurity directorySecurity = directoryInfo.GetAccessControl();
                FileSystemAccessRule accessRule = new FileSystemAccessRule("Everyone",
                    FileSystemRights.ReadAndExecute, AccessControlType.Deny);

                directorySecurity.AddAccessRule(accessRule);
                directoryInfo.SetAccessControl(directorySecurity);

                if (!File.Exists(logPath))
                    File.Create(logPath).Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error!\nCannot proceed to the match.", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        return true;
    }

    private void btnStartTimer_Click(object sender, EventArgs e)
    {
        DialogResult startTimerMessage = MessageBox.Show("The Match will now begin", "Start?",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

        if (startTimerMessage == DialogResult.OK)
        {
            foreach (TabPage tabPage in tabControlQuestions.TabPages)
            {
                TabLayout tabLayout = new TabLayout(this, tabLayoutModels.ElementAt(tabPage.TabIndex));
                tabLayout.Dock = DockStyle.Fill;
                tabPage.Controls.Add(tabLayout);
            }

            logTime("Match Started Time: ", true);

            btnMinimize.Visible = true;
            btnClose.Visible = true;
            btnStartTimer.Dispose();
            timerMatchTime.Start();
        }
    }

    private void timerMatchTime_Tick(object sender, EventArgs e)
    {
        if (seconds == 0)
        {
            if (minutes == 00 && hours == 0)
            {
                timesUp();
                return;
            }
            else if (minutes == 0)
            {
                minutes = 59;
                if (hours > 0)
                    hours--;
            }
            else
            {
                minutes--;
            }
            seconds = 59;
        }
        else
            seconds--;

        lblLiveTime.Text = $"{hours:00}:{minutes:00}:{seconds:00}";
    }

    private void timesUp()
    {
        timerMatchTime.Stop();
        tabControlQuestions.Enabled = false;

        MessageBox.Show("Congratulations on your hardwork." +
            "\nUnfortunately the time is already up.\nThank You!");
        logTime("Times Up Time: ", true);
        attachClosingEvent();
    }

    public void logTime(string subject, bool useRealTime)
    {
        if (checkDirectory())
        {
            using (StreamWriter streamWriter = File.AppendText(logPath))
            {
                if (useRealTime)
                    streamWriter.WriteLine(subject + DateTime.Now.ToString("HH:mm:ss"));
                else
                    streamWriter.WriteLine(subject + $"{hours:00}:{minutes:00}:{seconds:00}".ToString());
            }
        }
    }

    public string getLiveTime()
    {
        return lblLiveTime.Text;
    }

    public bool isQuestionsFinished()
    {
        bool isFinished = true;
        foreach (TabLayoutModel tabLayoutModel in tabLayoutModels)
        {
            if (!tabLayoutModel.IsFinished)
            {
                isFinished = false;
                break;
            }
        }
        return isFinished;
    }

    public void attachClosingEvent()
    {
        btnClose.Click += btnClose_Click;
        timerMatchTime.Stop();
    }

    public string directoryPath
    {
        get
        {
            return Path.Combine(@"~\answers\");
        }
    }

    public string logPath
    {
        get
        {
            return Path.Combine(@"~\answers\time.txt");
        }
    }

    // Border Tools Behavior

    private void btnMinimize_Click(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Minimized;
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void btnMinimize_MouseEnter(object sender, EventArgs e)
    {
        btnMinimize.BackColor = Color.DarkGoldenrod;
    }

    private void btnMinimize_MouseLeave(object sender, EventArgs e)
    {
        btnMinimize.BackColor = Color.Transparent;
    }

    private void btnClose_MouseEnter(object sender, EventArgs e)
    {
        btnClose.BackColor = Color.MidnightBlue;
    }

    private void btnClose_MouseLeave(object sender, EventArgs e)
    {
        btnClose.BackColor = Color.Transparent;
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        // Attach this after development stage to prevent the program from closing
        e.Cancel = true;
    }

    // Simulate moving the windows by dragging the border
    private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            isMouseDown = true;
            mouseOffset = new Point(-e.X, -e.Y);
        }
    }

    private void pnlTitleBar_MouseMove(object sender, MouseEventArgs e)
    {
        if (isMouseDown)
        {
            Point mousePosition = Control.MousePosition;
            mousePosition.Offset(mouseOffset.X, mouseOffset.Y);
            Location = mousePosition;
        }
    }

    private void pnlTitleBar_MouseUp(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            isMouseDown = false;
        }
    }
}
