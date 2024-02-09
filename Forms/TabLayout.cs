using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VMatch.Class;

namespace VMatch.Forms;
public partial class TabLayout : UserControl
{
    private TabLayoutModel tabLayoutModel;

    public TabLayout(TabLayoutModel tabLayoutModel)
    {
        InitializeComponent();
        this.tabLayoutModel = tabLayoutModel;

        lblQuestionTitle.Text = tabLayoutModel.QuestionTitle;
        lblQuestion.Text = tabLayoutModel.Question;
        lblProblemTitle.Text = tabLayoutModel.Problem;
        lblProblem.Text = tabLayoutModel.Problem;
    }
}
