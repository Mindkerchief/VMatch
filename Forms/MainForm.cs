using System.Collections;
using System.Runtime.InteropServices;
using VMatch.Class;
using VMatch.Forms;

namespace VMatch;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();

        SetupModel setupModel = new SetupModel();
        List<TabLayoutModel> tabLayoutModels = setupModel.setupTabLayoutModel();

        foreach (TabPage tabPage in tabControlQuestions.TabPages)
        {
            TabLayout tabLayout = new TabLayout(tabLayoutModels.ElementAt(tabPage.TabIndex));
            tabLayout.Dock = DockStyle.Fill;
            tabPage.Controls.Add(tabLayout);
        }
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
}
