﻿namespace VMatch.Forms;

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
        pnlSubmission = new Panel();
        btnSubmit = new Button();
        txtBoxSubmit = new TextBox();
        lblSubmitTitle = new Label();
        lblQuestion = new Label();
        lblQuestionTitle = new Label();
        lblSubmitted = new Label();
        pnlSubmission.SuspendLayout();
        SuspendLayout();
        // 
        // pnlSubmission
        // 
        pnlSubmission.AutoSize = true;
        pnlSubmission.Controls.Add(btnSubmit);
        pnlSubmission.Controls.Add(txtBoxSubmit);
        pnlSubmission.Controls.Add(lblSubmitTitle);
        pnlSubmission.Dock = DockStyle.Bottom;
        pnlSubmission.Location = new Point(10, 330);
        pnlSubmission.Margin = new Padding(5);
        pnlSubmission.Name = "pnlSubmission";
        pnlSubmission.Size = new Size(472, 44);
        pnlSubmission.TabIndex = 0;
        // 
        // btnSubmit
        // 
        btnSubmit.AutoSize = true;
        btnSubmit.BackColor = Color.FromArgb(240, 96, 147);
        btnSubmit.Cursor = Cursors.Hand;
        btnSubmit.FlatAppearance.BorderSize = 2;
        btnSubmit.FlatStyle = FlatStyle.Flat;
        btnSubmit.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnSubmit.ForeColor = Color.White;
        btnSubmit.Location = new Point(333, 5);
        btnSubmit.Margin = new Padding(5);
        btnSubmit.Name = "btnSubmit";
        btnSubmit.Size = new Size(70, 34);
        btnSubmit.TabIndex = 0;
        btnSubmit.Text = "ENTER";
        btnSubmit.UseVisualStyleBackColor = false;
        btnSubmit.Click += btnSubmit_Click;
        // 
        // txtBoxSubmit
        // 
        txtBoxSubmit.BackColor = Color.FromArgb(240, 96, 147);
        txtBoxSubmit.Cursor = Cursors.IBeam;
        txtBoxSubmit.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        txtBoxSubmit.ForeColor = Color.White;
        txtBoxSubmit.Location = new Point(127, 6);
        txtBoxSubmit.Margin = new Padding(5);
        txtBoxSubmit.Name = "txtBoxSubmit";
        txtBoxSubmit.Size = new Size(200, 33);
        txtBoxSubmit.TabIndex = 0;
        txtBoxSubmit.KeyDown += txtBoxSubmit_KeyDown;
        // 
        // lblSubmitTitle
        // 
        lblSubmitTitle.AutoSize = true;
        lblSubmitTitle.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblSubmitTitle.ForeColor = Color.White;
        lblSubmitTitle.Location = new Point(45, 9);
        lblSubmitTitle.Margin = new Padding(6, 0, 6, 0);
        lblSubmitTitle.Name = "lblSubmitTitle";
        lblSubmitTitle.Size = new Size(84, 25);
        lblSubmitTitle.TabIndex = 0;
        lblSubmitTitle.Text = "Answer:";
        lblSubmitTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblQuestion
        // 
        lblQuestion.Dock = DockStyle.Top;
        lblQuestion.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblQuestion.ForeColor = Color.White;
        lblQuestion.Location = new Point(10, 52);
        lblQuestion.Margin = new Padding(6, 0, 6, 0);
        lblQuestion.Name = "lblQuestion";
        lblQuestion.Size = new Size(472, 170);
        lblQuestion.TabIndex = 0;
        lblQuestion.Text = "You want to give your significant other chocolates, but you only have milk, dark, and white chocolate. What should you do to find out which type they like?";
        lblQuestion.TextAlign = ContentAlignment.TopCenter;
        // 
        // lblQuestionTitle
        // 
        lblQuestionTitle.Dock = DockStyle.Top;
        lblQuestionTitle.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblQuestionTitle.ForeColor = Color.White;
        lblQuestionTitle.Location = new Point(10, 10);
        lblQuestionTitle.Margin = new Padding(6, 0, 6, 0);
        lblQuestionTitle.Name = "lblQuestionTitle";
        lblQuestionTitle.Size = new Size(472, 42);
        lblQuestionTitle.TabIndex = 0;
        lblQuestionTitle.Text = "Question Title";
        lblQuestionTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblSubmitted
        // 
        lblSubmitted.Dock = DockStyle.Fill;
        lblSubmitted.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblSubmitted.ForeColor = Color.FromArgb(240, 96, 147);
        lblSubmitted.Location = new Point(10, 222);
        lblSubmitted.Margin = new Padding(6, 0, 6, 0);
        lblSubmitted.Name = "lblSubmitted";
        lblSubmitted.Size = new Size(472, 152);
        lblSubmitted.TabIndex = 0;
        lblSubmitted.Text = "Submited on ";
        lblSubmitted.TextAlign = ContentAlignment.MiddleCenter;
        lblSubmitted.Visible = false;
        // 
        // TabLayout
        // 
        AutoScaleDimensions = new SizeF(11F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(162, 30, 33);
        BackgroundImageLayout = ImageLayout.Stretch;
        Controls.Add(pnlSubmission);
        Controls.Add(lblSubmitted);
        Controls.Add(lblQuestion);
        Controls.Add(lblQuestionTitle);
        Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(5);
        Name = "TabLayout";
        Padding = new Padding(10);
        Size = new Size(492, 384);
        pnlSubmission.ResumeLayout(false);
        pnlSubmission.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Panel pnlSubmission;
    private Button btnSubmit;
    private TextBox txtBoxSubmit;
    private Label lblSubmitTitle;
    private Label lblQuestion;
    private Label lblQuestionTitle;
    private Label lblSubmitted;
}
