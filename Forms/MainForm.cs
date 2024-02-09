using System.Collections;
using System.Runtime.InteropServices;
using VMatch.Class;
using VMatch.Forms;

namespace VMatch;

public partial class MainForm : Form, ITabLayout
{
    private List<TabLayoutModel> tabLayoutModels;
    private int hours = 2, minutes = 59, seconds = 60;

    public MainForm()
    {
        InitializeComponent();
    }

    private void btnStartTimer_Click(object sender, EventArgs e)
    {
        DialogResult startTimerMessage = MessageBox.Show("Valentine Match will now begin", "Start?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        if (startTimerMessage == DialogResult.OK)
        {
            SetupModel setupModel = new SetupModel();
            tabLayoutModels = setupModel.setupTabLayoutModel();

            foreach (TabPage tabPage in tabControlQuestions.TabPages)
            {
                TabLayout tabLayout = new TabLayout(this, tabLayoutModels.ElementAt(tabPage.TabIndex));
                tabLayout.Dock = DockStyle.Fill;
                tabPage.Controls.Add(tabLayout);
            }

            btnStartTimer.Dispose();
            timerMatchTime.Start();
        }
    }

    private void timerMatchTime_Tick(object sender, EventArgs e)
    {
        lblLiveTime.Text = DateTime.Now.ToString("HH:mm:ss");

        if (seconds == 0)
        {
            if (minutes == 00 && hours == 0)
            {
                MessageBox.Show("Times Up!");
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

    private void btnMinimize_Click(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Minimized;
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void btnClose_MouseLeave(object sender, EventArgs e)
    {
        btnClose.BackColor = Color.Transparent;
    }

    private void btnClose_MouseEnter(object sender, EventArgs e)
    {
        btnClose.BackColor = Color.Blue;
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        e.Cancel = true;
    }

    public string getLiveTime()
    {
        return $"{hours:00}:{minutes:00}:{seconds:00}";
    }

    public bool isQuestionsFinished()
    {
        bool isFinised = true;
        foreach (TabLayoutModel tabLayoutModel in tabLayoutModels)
        {
            if (!tabLayoutModel.IsFinished)
            {
                isFinised = false;
                break;
            }
        }
        return isFinised;
    }
}
