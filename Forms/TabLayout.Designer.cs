namespace VMatch.Forms;

partial class TabLayout
{
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        lblProblem = new Label();
        lblProblemTitle = new Label();
        pnlSubmission = new Panel();
        btnSubmit = new Button();
        txtBoxSubmit = new TextBox();
        lblSubmitTitle = new Label();
        lblQuestion = new Label();
        lblQuestionTitle = new Label();
        pnlSubmission.SuspendLayout();
        SuspendLayout();
        // 
        // lblProblem
        // 
        lblProblem.Dock = DockStyle.Top;
        lblProblem.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblProblem.ForeColor = Color.White;
        lblProblem.Location = new Point(0, 170);
        lblProblem.Margin = new Padding(5, 0, 5, 0);
        lblProblem.Name = "lblProblem";
        lblProblem.Size = new Size(400, 100);
        lblProblem.TabIndex = 11;
        lblProblem.Text = "Write a program that takes a list of couples and returns a randomly assigned table for a Valentine's Day dinner party.";
        lblProblem.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblProblemTitle
        // 
        lblProblemTitle.Dock = DockStyle.Top;
        lblProblemTitle.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblProblemTitle.ForeColor = Color.White;
        lblProblemTitle.Location = new Point(0, 135);
        lblProblemTitle.Margin = new Padding(5, 0, 5, 0);
        lblProblemTitle.Name = "lblProblemTitle";
        lblProblemTitle.Size = new Size(400, 35);
        lblProblemTitle.TabIndex = 10;
        lblProblemTitle.Text = "Problem Title";
        lblProblemTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // pnlSubmission
        // 
        pnlSubmission.AutoSize = true;
        pnlSubmission.Controls.Add(btnSubmit);
        pnlSubmission.Controls.Add(txtBoxSubmit);
        pnlSubmission.Controls.Add(lblSubmitTitle);
        pnlSubmission.Dock = DockStyle.Bottom;
        pnlSubmission.Location = new Point(0, 362);
        pnlSubmission.Margin = new Padding(4);
        pnlSubmission.Name = "pnlSubmission";
        pnlSubmission.Size = new Size(400, 38);
        pnlSubmission.TabIndex = 9;
        // 
        // btnSubmit
        // 
        btnSubmit.AutoSize = true;
        btnSubmit.Cursor = Cursors.Hand;
        btnSubmit.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnSubmit.ForeColor = Color.White;
        btnSubmit.Location = new Point(300, 3);
        btnSubmit.Margin = new Padding(4);
        btnSubmit.Name = "btnSubmit";
        btnSubmit.Size = new Size(75, 31);
        btnSubmit.TabIndex = 8;
        btnSubmit.Text = "ENTER";
        btnSubmit.UseVisualStyleBackColor = false;
        // 
        // txtBoxSubmit
        // 
        txtBoxSubmit.Cursor = Cursors.IBeam;
        txtBoxSubmit.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtBoxSubmit.Location = new Point(93, 4);
        txtBoxSubmit.Margin = new Padding(4);
        txtBoxSubmit.Name = "txtBoxSubmit";
        txtBoxSubmit.Size = new Size(200, 29);
        txtBoxSubmit.TabIndex = 5;
        // 
        // lblSubmitTitle
        // 
        lblSubmitTitle.AutoSize = true;
        lblSubmitTitle.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblSubmitTitle.ForeColor = Color.White;
        lblSubmitTitle.Location = new Point(10, 0);
        lblSubmitTitle.Margin = new Padding(5, 0, 5, 0);
        lblSubmitTitle.Name = "lblSubmitTitle";
        lblSubmitTitle.Padding = new Padding(10, 6, 0, 0);
        lblSubmitTitle.Size = new Size(81, 27);
        lblSubmitTitle.TabIndex = 4;
        lblSubmitTitle.Text = "Answer:";
        lblSubmitTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblQuestion
        // 
        lblQuestion.Dock = DockStyle.Top;
        lblQuestion.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblQuestion.ForeColor = Color.White;
        lblQuestion.Location = new Point(0, 35);
        lblQuestion.Margin = new Padding(5, 0, 5, 0);
        lblQuestion.Name = "lblQuestion";
        lblQuestion.Size = new Size(400, 100);
        lblQuestion.TabIndex = 8;
        lblQuestion.Text = "You want to give your significant other chocolates, but you only have milk, dark, and white chocolate. What should you do to find out which type they like?";
        lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblQuestionTitle
        // 
        lblQuestionTitle.Dock = DockStyle.Top;
        lblQuestionTitle.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblQuestionTitle.ForeColor = Color.White;
        lblQuestionTitle.Location = new Point(0, 0);
        lblQuestionTitle.Margin = new Padding(5, 0, 5, 0);
        lblQuestionTitle.Name = "lblQuestionTitle";
        lblQuestionTitle.Size = new Size(400, 35);
        lblQuestionTitle.TabIndex = 7;
        lblQuestionTitle.Text = "Question Title";
        lblQuestionTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // TabLayout
        // 
        AutoScaleDimensions = new SizeF(9F, 21F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Maroon;
        Controls.Add(lblProblem);
        Controls.Add(lblProblemTitle);
        Controls.Add(pnlSubmission);
        Controls.Add(lblQuestion);
        Controls.Add(lblQuestionTitle);
        Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(4);
        Name = "TabLayout";
        Size = new Size(400, 400);
        pnlSubmission.ResumeLayout(false);
        pnlSubmission.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblProblem;
    private Label lblProblemTitle;
    private Panel pnlSubmission;
    private Button btnSubmit;
    private TextBox txtBoxSubmit;
    private Label lblSubmitTitle;
    private Label lblQuestion;
    private Label lblQuestionTitle;
}
