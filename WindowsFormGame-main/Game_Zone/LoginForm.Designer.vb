<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.SignUpBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.LoginButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.GameShows = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2GradientTileButton2 = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.Guna2GradientTileButton1 = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.Guna2ImageButton1 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.GameShows.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(2, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1047, 113)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(246, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(562, 39)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "WELCOME (SIGN IN OR SIGN UP)"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Guna2Panel2.Controls.Add(Me.SignUpBtn)
        Me.Guna2Panel2.Controls.Add(Me.LoginButton)
        Me.Guna2Panel2.Controls.Add(Me.Guna2TextBox2)
        Me.Guna2Panel2.Controls.Add(Me.Guna2TextBox1)
        Me.Guna2Panel2.Location = New System.Drawing.Point(329, 99)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(371, 422)
        Me.Guna2Panel2.TabIndex = 1
        '
        'SignUpBtn
        '
        Me.SignUpBtn.CheckedState.Parent = Me.SignUpBtn
        Me.SignUpBtn.CustomImages.Parent = Me.SignUpBtn
        Me.SignUpBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.SignUpBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.SignUpBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.SignUpBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.SignUpBtn.DisabledState.Parent = Me.SignUpBtn
        Me.SignUpBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.SignUpBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignUpBtn.ForeColor = System.Drawing.Color.White
        Me.SignUpBtn.HoverState.Parent = Me.SignUpBtn
        Me.SignUpBtn.Location = New System.Drawing.Point(103, 338)
        Me.SignUpBtn.Name = "SignUpBtn"
        Me.SignUpBtn.ShadowDecoration.Parent = Me.SignUpBtn
        Me.SignUpBtn.Size = New System.Drawing.Size(172, 45)
        Me.SignUpBtn.TabIndex = 3
        Me.SignUpBtn.Text = "CREATE ACCOUNT"
        '
        'LoginButton
        '
        Me.LoginButton.Animated = True
        Me.LoginButton.CheckedState.Parent = Me.LoginButton
        Me.LoginButton.CustomImages.Parent = Me.LoginButton
        Me.LoginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.LoginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.LoginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.LoginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.LoginButton.DisabledState.Parent = Me.LoginButton
        Me.LoginButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.LoginButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LoginButton.ForeColor = System.Drawing.Color.White
        Me.LoginButton.HoverState.Parent = Me.LoginButton
        Me.LoginButton.Location = New System.Drawing.Point(103, 274)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.ShadowDecoration.Parent = Me.LoginButton
        Me.LoginButton.Size = New System.Drawing.Size(172, 45)
        Me.LoginButton.TabIndex = 2
        Me.LoginButton.Text = "LOGIN"
        '
        'Guna2TextBox2
        '
        Me.Guna2TextBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Guna2TextBox2.BorderThickness = 2
        Me.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox2.DefaultText = ""
        Me.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.Parent = Me.Guna2TextBox2
        Me.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.FocusedState.Parent = Me.Guna2TextBox2
        Me.Guna2TextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.HoverState.Parent = Me.Guna2TextBox2
        Me.Guna2TextBox2.Location = New System.Drawing.Point(78, 196)
        Me.Guna2TextBox2.Name = "Guna2TextBox2"
        Me.Guna2TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Guna2TextBox2.PlaceholderText = "Password"
        Me.Guna2TextBox2.SelectedText = ""
        Me.Guna2TextBox2.ShadowDecoration.Parent = Me.Guna2TextBox2
        Me.Guna2TextBox2.Size = New System.Drawing.Size(242, 41)
        Me.Guna2TextBox2.TabIndex = 1
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Guna2TextBox1.BorderThickness = 2
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.HoverState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Location = New System.Drawing.Point(78, 124)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = "Username"
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.ShadowDecoration.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Size = New System.Drawing.Size(242, 42)
        Me.Guna2TextBox1.TabIndex = 0
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.FillColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Guna2Panel3.Location = New System.Drawing.Point(-5, 0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(21, 113)
        Me.Guna2Panel3.TabIndex = 3
        '
        'GameShows
        '
        Me.GameShows.Controls.Add(Me.Guna2ImageButton1)
        Me.GameShows.Controls.Add(Me.Label2)
        Me.GameShows.Controls.Add(Me.Guna2GradientTileButton2)
        Me.GameShows.Controls.Add(Me.Guna2GradientTileButton1)
        Me.GameShows.FillColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.GameShows.Location = New System.Drawing.Point(-5, 0)
        Me.GameShows.Name = "GameShows"
        Me.GameShows.ShadowDecoration.Parent = Me.GameShows
        Me.GameShows.Size = New System.Drawing.Size(1054, 596)
        Me.GameShows.TabIndex = 4
        Me.GameShows.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(232, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(509, 39)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CHOOSE ONE GAME TO PLAY"
        '
        'Guna2GradientTileButton2
        '
        Me.Guna2GradientTileButton2.BorderRadius = 3
        Me.Guna2GradientTileButton2.CheckedState.Parent = Me.Guna2GradientTileButton2
        Me.Guna2GradientTileButton2.CustomImages.Parent = Me.Guna2GradientTileButton2
        Me.Guna2GradientTileButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientTileButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientTileButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientTileButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientTileButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientTileButton2.DisabledState.Parent = Me.Guna2GradientTileButton2
        Me.Guna2GradientTileButton2.FillColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Guna2GradientTileButton2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Guna2GradientTileButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GradientTileButton2.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientTileButton2.HoverState.Parent = Me.Guna2GradientTileButton2
        Me.Guna2GradientTileButton2.Location = New System.Drawing.Point(376, 391)
        Me.Guna2GradientTileButton2.Name = "Guna2GradientTileButton2"
        Me.Guna2GradientTileButton2.ShadowDecoration.Parent = Me.Guna2GradientTileButton2
        Me.Guna2GradientTileButton2.Size = New System.Drawing.Size(222, 72)
        Me.Guna2GradientTileButton2.TabIndex = 1
        Me.Guna2GradientTileButton2.Text = "TYPING SPEED TEST"
        '
        'Guna2GradientTileButton1
        '
        Me.Guna2GradientTileButton1.BorderRadius = 3
        Me.Guna2GradientTileButton1.CheckedState.Parent = Me.Guna2GradientTileButton1
        Me.Guna2GradientTileButton1.CustomImages.Parent = Me.Guna2GradientTileButton1
        Me.Guna2GradientTileButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientTileButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientTileButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientTileButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientTileButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientTileButton1.DisabledState.Parent = Me.Guna2GradientTileButton1
        Me.Guna2GradientTileButton1.FillColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Guna2GradientTileButton1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Guna2GradientTileButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GradientTileButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientTileButton1.HoverState.Parent = Me.Guna2GradientTileButton1
        Me.Guna2GradientTileButton1.Location = New System.Drawing.Point(376, 246)
        Me.Guna2GradientTileButton1.Name = "Guna2GradientTileButton1"
        Me.Guna2GradientTileButton1.ShadowDecoration.Parent = Me.Guna2GradientTileButton1
        Me.Guna2GradientTileButton1.Size = New System.Drawing.Size(222, 72)
        Me.Guna2GradientTileButton1.TabIndex = 0
        Me.Guna2GradientTileButton1.Text = "QUIZ GAME"
        '
        'Guna2ImageButton1
        '
        Me.Guna2ImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ImageButton1.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton1.CheckedState.Parent = Me.Guna2ImageButton1
        Me.Guna2ImageButton1.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton1.HoverState.Parent = Me.Guna2ImageButton1
        Me.Guna2ImageButton1.Image = CType(resources.GetObject("Guna2ImageButton1.Image"), System.Drawing.Image)
        Me.Guna2ImageButton1.ImageOffset = New System.Drawing.Point(0, 0)
        Me.Guna2ImageButton1.ImageRotate = 0!
        Me.Guna2ImageButton1.Location = New System.Drawing.Point(454, 482)
        Me.Guna2ImageButton1.Name = "Guna2ImageButton1"
        Me.Guna2ImageButton1.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton1.PressedState.Parent = Me.Guna2ImageButton1
        Me.Guna2ImageButton1.ShadowDecoration.Parent = Me.Guna2ImageButton1
        Me.Guna2ImageButton1.Size = New System.Drawing.Size(77, 90)
        Me.Guna2ImageButton1.TabIndex = 10
        Me.Guna2ImageButton1.UseTransparentBackground = True
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 593)
        Me.Controls.Add(Me.GameShows)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginForm"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.GameShows.ResumeLayout(False)
        Me.GameShows.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents SignUpBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LoginButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GameShows As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2GradientTileButton2 As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents Guna2GradientTileButton1 As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents Guna2ImageButton1 As Guna.UI2.WinForms.Guna2ImageButton
End Class
